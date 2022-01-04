using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using System;
using System.IO;
using System.Linq;
using UfoBlog.Domain.Dto.Article;
using System.Threading.Tasks;

namespace UfoBlog.Pages
{
    public partial class Index
    {
        private IJSObjectReference module;
        private IConfiguration builder;

        #region 生命周期方法

        /// <summary>
        /// 生命周期事件-渲染前
        /// </summary>
        /// <returns></returns>
        protected override async Task OnInitializedAsync()
        {
            UfoBlog.Domain.Dto.Article.ArticleDto aaa = _mapper.Map<UfoBlog.Domain.Dto.Article.ArticleDto>(new Domain.Model.Article.Article { Id = 1 } );

            //加载配置文件
            builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory() + "/wwwroot")
            .AddJsonFile("appsettings.json").Build();

            //初始化数据
            using var context = _dbFactory.CreateDbContext();
            user = context.Admin.AsNoTracking().First();
            sayList = await context.DynamicMan.AsNoTracking().Where(x => !x.IsDelete).OrderByDescending(x => x.CreateTime).Select(x=> _mapper.Map<DynamicManDto>(x)).ToListAsync();

            otherInfo.Number = context.DynamicMan.Where(x => !x.IsDelete)?.Count() ?? 0;
            otherInfo.LikeIt = context.LikeIt.Where(x => x.Type == 2 && !x.IsDelete)?.Count() ?? 0;
            otherInfo.Comments = 0;
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
        "./js/Index.razor.js");

                await module.InvokeVoidAsync("Initialize");
            }
        }

        #endregion

        /// <summary>
        /// 相对时间转换 
        /// </summary>
        /// <param name="dynamicTime"></param>
        /// <returns></returns>
        public string GetIntervalTime(DateTime dynamicTime)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan ts = currentDate - dynamicTime; 
            int month = (currentDate.Year - dynamicTime.Year) * 12 + (currentDate.Month - dynamicTime.Month);  
            string en; 
            if (month >= 12)
            {
                int year = month / 12; 
                en = year + "年前";
            }
            else if (month > 0)
            {
                en = month + "个月前";  
            }
            else if (ts.Days != 0)
            {
                en = ts.Days + "天前"; 
            }
            else if (ts.Hours != 0)
            {
                en = ts.Hours + "小时前";
            }
            else if (ts.Minutes != 0)
            {
                en = ts.Minutes + "分钟前";
            }
            else if (ts.Seconds != 0)
            {
                en = ts.Seconds + "秒前";
            }
            else
            {
                en = ts.Milliseconds + "毫秒前";
            }
            return en;
        }

    }
}
