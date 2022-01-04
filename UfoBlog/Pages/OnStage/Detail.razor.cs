using System.Linq;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace UfoBlog.Pages.OnStage
{
    public partial class Detail
    {
        private IJSObjectReference module;

        #region 生命周期方法

        /// <summary>
        /// 生命周期事件-渲染前
        /// </summary>
        /// <returns></returns>
        protected override void OnInitialized()
        {
            //初始化数据
            using var context = _dbFactory.CreateDbContext();
            data = context.Article.FirstOrDefault(x => x.Id == int.Parse(Index));
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
