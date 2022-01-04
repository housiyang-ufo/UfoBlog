using AntDesign;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UfoBlog.Domain.Dto.Article;

namespace UfoBlog.Pages.BackStage.Other
{
    public partial class DynamicMan
    {
        private IJSObjectReference module;
        private const string baseUrl = "wwwroot/Upload/image/";

        #region 生命周期函数

        /// <summary>
        /// 生命周期事件-渲染前
        /// </summary>
        /// <returns></returns>
        protected override async Task OnInitializedAsync()
        {
            using var context = _dbFactory.CreateDbContext();
            _total = context.DynamicMan.Where(x => !x.IsDelete).Count();

            await QueryArticleList(_pageIndex, _pageSize);
        }

        /// <summary>
        /// 生命周期事件-渲染后
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await iconService.CreateFromIconfontCN(_configuration.GetSection("DataList")["iconfont"]);

                module = await _js.InvokeAsync<IJSObjectReference>("import",
        "./js/DynamicMan.razor.js");
            }
        }
        #endregion

        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="index"></param>
        /// <param name="number"></param>
        private async Task QueryArticleList(int index, int number = 10)
        {
            using var context = _dbFactory.CreateDbContext();
            dynamicManDtos = await context.DynamicMan
                 .Where(x => !x.IsDelete)
                 .OrderByDescending(x => x.CreateTime)
                 .Skip(number * (index - 1)).Take(number)
                 .Select(x=> _mapper.Map<DynamicManDto>(x))
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        private void Edit(int id)
        {
            //编辑
        }

        #region 对话框事件

        /// <summary>
        /// 添加发布按钮
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
            if (string.IsNullOrWhiteSpace(textContent))
                return await _notice.Error(new NotificationConfig { Message = "错误提示", Description = "内容不能为空！" });

            _loading = true;
            using var context = _dbFactory.CreateDbContext();

            var inpoutDto = new Domain.Model.Article.DynamicMan { Content = textContent};

            var length = imageList.Count;
            var host = conf.GetValue(typeof(String), "URLS");
            for (var i = 1; i <= length; i++)
            {
                var name = "Picture" + i;
                inpoutDto.GetType().GetProperty(name).SetValue(inpoutDto, host + imageList[i-1].Substring(7));
            } 

            await context.DynamicMan.AddAsync(inpoutDto);
            await context.SaveChangesAsync();

            await QueryArticleList(_pageIndex, _pageSize);

            _visible = false;
            textContent = null;
            imageList.Clear();
            _loading = false;

            return await _notice.Success(new NotificationConfig { Message = "成功提示", Description = "动态发布成功！" });
        }

        /// <summary>
        /// 对话框-取消事件
        /// </summary>
        /// <param name="e"></param>
        private void HandleCancel(MouseEventArgs e)
        {
            textContent = null;
            _visible = false;
        }

        #region 封面上传

        /// <summary>
        /// 封面上传
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private async Task LoadFiles(InputFileChangeEventArgs e)
        {
            if (!"image".Equals(e.File.ContentType.Substring(0, 5)) || imageList.Count == 9)
                return;

            var path = baseUrl + Guid.NewGuid().ToString("N") + ".png";
            try
            {
                await using FileStream fs = new(path, FileMode.Create);
                await e.File.OpenReadStream(5120000).CopyToAsync(fs);
            }
            catch (Exception ex)
            {
                //错误处理
                return;
            }
           
            imageList.Add(path);
        }

        /// <summary>
        /// 调用InputFile Click事件
        /// </summary>
        /// <returns></returns>
        private async Task InputFileClick()
        {
            await module.InvokeVoidAsync("InputFileClick", inputFile);
        }

        /// <summary>
        /// 删除图片
        /// </summary>
        private void ImageDelete(int index)
        {
            File.Delete(Path.GetFullPath(imageList[index]));
            imageList.RemoveAt(index);
        }
        #endregion

        #endregion
    }
}
