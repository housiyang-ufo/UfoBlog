using AntDesign;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using UfoBlog.Domain.Dto.Article;

namespace UfoBlog.Pages.BackStage.Article
{
    public partial class List
    {
        #region 生命周期方法

        /// <summary>
        /// 生命周期事件-渲染前
        /// </summary>
        /// <returns></returns>
        protected override void OnInitialized()
        {
            using var context = _dbFactory.CreateDbContext();
            _total = context.Article.Where(x => !x.IsDelete).Count();

            QueryArticleList(_pageIndex, _pageSize);
        }

        #endregion

        /// <summary>
        /// 加载文章
        /// </summary>
        /// <param name="index"></param>
        /// <param name="number"></param>
        private void QueryArticleList(int index, int number = 10)
        {
            using var context = _dbFactory.CreateDbContext();



            articles = context.Article
                 .Where(x => !x.IsDelete)
                 .OrderByDescending(x => x.CreateTime)
                 .Skip(number * (index - 1)).Take(number).AsEnumerable()
                 .Join(context.Category.Where(x => !x.IsDelete).ToList(), a => a.Type, b => b.Id, (a, b) => { 
                     var data = _mapper.Map<ArticleDto>(a);
                     data.TypeDto = _mapper.Map<CategoryDto>(b);
                     return data; })
                 .ToList();    
        }

        /// <summary>
        /// 翻页事件
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private void PageIndexChanged(PaginationEventArgs args)
        {
            QueryArticleList(_pageIndex, _pageSize);
        }

        /// <summary>
        /// 文章选中
        /// </summary>
        /// <param name="id"></param>
        public void RemoveSelection(int id)
        {
            var selected = selectedRows.Where(x => x.Id != id);
            selectedRows = selected;
        }

        #region 说说删除

        /// <summary>
        /// 删除确认框
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private async Task ShowConfirm(int id)
        {
            await _modalService.ConfirmAsync(new ConfirmOptions()
            {
                Title = "是否要删除这条文章?",
                Icon = icon,
                Content = "想删就删吧 இ௰இ!",
                OnOk = async (e) => await Delete(id),
                OnCancel = onCancel
            });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        private async Task Delete(int id)
        {
            using var context = _dbFactory.CreateDbContext();

            var data = await context.Article.FirstOrDefaultAsync(x => !x.IsDelete && x.Id == id);

            if (data != null)
            {
                data.IsDelete = true;
                context.Article.Update(data);

                //标签处理
                var arrayTags = data.Tag.Split(",");
                if (arrayTags.Length > 0)
                {
                    var tagMap = context.TagMap
                        .Where(x => !x.IsDelete && x.ArticleId == id).AsEnumerable()
                        .Select(x => { x.IsDelete = true; return x; })
                        .ToList();
                    context.TagMap.UpdateRange(tagMap);

                    var tag = context.Tag
                        .Where(x => !x.IsDelete && tagMap.Any(y => !y.IsDelete && y.Id == x.Id)).AsEnumerable()
                        .Select(x => { x.Number--; return x; })
                        .ToList();
                    context.Tag.UpdateRange(tag);
                }

                //分类处理
                var category = await context.Category.FirstOrDefaultAsync(x => !x.IsDelete && x.Id == data.Type);
                context.Category.Update(category);

                await context.SaveChangesAsync();

                QueryArticleList(_pageIndex, _pageSize);
                Task.Run(async () => await _notice.Success(new NotificationConfig { Message = "成功提示", Description = "文章删除成功！" }));
            }
        }

        Func<ModalClosingEventArgs, Task> onCancel = (e) =>
        {
            return Task.CompletedTask;
        };

        #endregion

        private void Edit(int id)
        {
            //编辑
        }

        /// <summary>
        /// Tag随机颜色
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private string SwitchColor(int index)
        {
            int i;
            if (index <= 8)
            {
                i = index - 1;
            }
            else
            {
                i = (index % 8) - 1;
            }

            return color[i];
        }
    }
}
