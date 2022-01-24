using System.Linq;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using UfoBlog.Domain.Dto.Article;

namespace UfoBlog.Pages.OnStage
{
    public partial class Article
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
            otherInfo.Number = context.Article.Where(x => !x.IsDelete)?.Count() ?? 0;
            otherInfo.LikeIt = context.LikeIt.Where(x => x.Type == 1 && !x.IsDelete)?.Count() ?? 0;
            otherInfo.Comments = 0;

            QueryArticleList(_pageIndex, _pageSize);
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
        "./js/Index.razor.js");

                await module.InvokeVoidAsync("Initialize");
            }
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
                     return data;
                 })
                 .ToList();
        }

        /// <summary>
        /// 详情页面跳转
        /// </summary>
        /// <param name="Id"></param>
        private void NavToDetailById(int Id) 
        {
            _navigationManager.NavigateTo($"/Detail/{Id}");
        }
    }
}
