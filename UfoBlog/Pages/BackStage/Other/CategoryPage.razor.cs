
using AntDesign;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UfoBlog.Domain.Dto.Article;
using UfoBlog.Domain.Model.Article;

namespace UfoBlog.Pages.BackStage.Other
{
    public partial class CategoryPage
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
            categories = await context.Category
                 .Where(x => !x.IsDelete)
                 .OrderByDescending(x => x.CreateTime)
                 .Skip(number * (index - 1)).Take(number)
                 .Select(x=> _mapper.Map<CategoryDto>(x))
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

        #region 分类删除

        /// <summary>
        /// 删除确认框
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private async Task ShowConfirm(int id)
        {
            if (categories.First(x => x.Id == id).Number == 0)
            {
                await _modalService.ConfirmAsync(new ConfirmOptions()
                {
                    Title = "是否要删除分类?",
                    Icon = icon,
                    Content = "想删就删吧 இ௰இ",
                    OnOk = async (e) => await Delete(e, id),
                    OnCancel = onCancel
                });
            }else
                await _notice.Error(new NotificationConfig { Message = "错误提示", Description = "不能删除引用数量大于0的分类！" });
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        private async Task Delete(ModalClosingEventArgs e, int id)
        {
            using var context = _dbFactory.CreateDbContext();

            var data = await context.Category.FirstOrDefaultAsync(x => !x.IsDelete && x.Id == id);
            if (data != null)
            {
                context.Category.Remove(data);
                await context.SaveChangesAsync();

                await QueryArticleList(_pageIndex, _pageSize);
                await _notice.Success(new NotificationConfig { Message = "成功提示", Description = "分类删除成功！" });
            }
        }

        Func<ModalClosingEventArgs, Task> onCancel = (e) =>
        {
            return Task.CompletedTask;
        };

        #endregion

        #region 对话框事件

        /// <summary>
        /// 添加分类按钮
        /// </summary>
        private void ShowModal()
        {
            _visible = true;
        }

        /// <summary>
        /// 对话框-确定事件
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private async Task<NotificationRef> HandleOk(MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName))
                return await _notice.Error(new NotificationConfig { Message = "错误提示", Description = "名称不能为空！" });

            
            using var context = _dbFactory.CreateDbContext();

            var isExist = await context.Category.AnyAsync(x => x.Name.Equals(textName));
            if (isExist)
                return await _notice.Error(new NotificationConfig { Message = "错误提示", Description = "分类已经存在！" });

            _confirmLoading = true;

            await context.Category.AddAsync(new Category { Name = textName, Description = textDescription });
            await context.SaveChangesAsync();

            await QueryArticleList(_pageIndex, _pageSize);

            _visible = false;
            textName = null;
            textDescription = null;
            _confirmLoading = false;

            return await _notice.Success(new NotificationConfig { Message = "成功提示", Description = "分类添加成功！" });
        }

        /// <summary>
        /// 对话框-取消事件
        /// </summary>
        /// <param name="e"></param>
        private void HandleCancel(MouseEventArgs e)
        {
            textName = null;
            textDescription = null;
            _visible = false;
        }

        #endregion
    }
}
