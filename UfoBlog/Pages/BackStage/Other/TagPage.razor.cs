using AntDesign;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UfoBlog.Domain.Dto.Article;

namespace UfoBlog.Pages.BackStage.Other
{
    public partial class TagPage
    {
        #region 生命周期函数

        /// <summary>
        /// 生命周期事件-渲染前
        /// </summary>
        /// <returns></returns>
        protected override async Task OnInitializedAsync()
        {
            using var context = _dbFactory.CreateDbContext();
            _total = context.Article.Where(x => !x.IsDelete).Count();

            await QueryArticleList(_pageIndex, _pageSize);
        }

        #endregion

        /// <summary>
        /// 加载文章
        /// </summary>
        /// <param name="index"></param>
        /// <param name="number"></param>
        private async Task QueryArticleList(int index, int number = 10)
        {
            using var context = _dbFactory.CreateDbContext();
            tagDtos = await context.Tag
                 .Where(x => !x.IsDelete)
                 .OrderByDescending(x => x.CreateTime)
                 .Skip(number * (index - 1)).Take(number)
                 .Select(x => _mapper.Map<TagDto>(x))
                 .ToListAsync();
        }

        /// <summary>
        /// 翻页事件
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private async Task PageIndexChanged(PaginationEventArgs args)
        {
            await QueryArticleList(_pageIndex, _pageSize);
        }

        private void Edit(int id)
        {
            //编辑
        }

        #region 标签删除

        /// <summary>
        /// 删除确认框
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private async Task ShowConfirm(int id)
        {
            await _modalService.ConfirmAsync(new ConfirmOptions()
            {
                Title = "是否要删除标签?",
                Icon = icon,
                Content = "删除标签后，对应的文章将失去这项标签!",
                OnOk = async (e) => await Delete(e, id),
                OnCancel = onCancel
            });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        private async Task Delete(ModalClosingEventArgs e, int id)
        {
            using var context = _dbFactory.CreateDbContext();

            var data = await context.Tag.FirstOrDefaultAsync(x => !x.IsDelete && x.Id == id);
            
            if (data != null)
            {
                context.Tag.Remove(data);

                var dataMap = await context.TagMap.Where(x => !x.IsDelete && x.TagId == id).ToListAsync();
                if (dataMap != null && dataMap.Count > 0)
                    context.TagMap.RemoveRange(dataMap);
                
                await context.SaveChangesAsync();

                await QueryArticleList(_pageIndex, _pageSize);
                Task.Run(async ()=> await _notice.Success(new NotificationConfig { Message = "成功提示", Description = "标签删除成功！" })); 
            }
        }

        Func<ModalClosingEventArgs, Task> onCancel = (e) =>
        {
            return Task.CompletedTask;
        };

        #endregion
    }
}
