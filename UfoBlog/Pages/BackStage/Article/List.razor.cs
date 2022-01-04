using AntDesign;
using System.Linq;
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
                     data.TypeName = b.Name;
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

        private void Delete(int id)
        {
            //删除
        }

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
