using System.Linq;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using UfoBlog.Domain.Dto.Article;

namespace UfoBlog.Pages.OnStage
{
    public partial class Detail
    {
        private IConfiguration builder;
        private IJSObjectReference module;

        #region 生命周期方法

        /// <summary>
        /// 生命周期事件-渲染前
        /// </summary>
        /// <returns></returns>
        protected override void OnInitialized()
        {
            //加载配置文件
            builder = _commonService.LoadJsonFile("/wwwroot");

            //初始化数据
            using var context = _dbFactory.CreateDbContext();
            user = context.Admin.AsNoTracking().First();

            var article = context.Article.FirstOrDefault(x => !x.IsDelete && x.Id == int.Parse(Index));
            var category = context.Category.FirstOrDefault(x => !x.IsDelete && x.Id == article.Type);
            data = _mapper.Map<ArticleDto>(article);
            data.TypeDto = _mapper.Map<CategoryDto>(category);
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
                module = await _js.InvokeAsync<IJSObjectReference>("import",
        "./js/Detail.razor.js");

                await module.InvokeVoidAsync("Initialize", data.Content);
            }
        }

        //_js.InvokeVoidAsync("history.back");
        #endregion
    }
}
