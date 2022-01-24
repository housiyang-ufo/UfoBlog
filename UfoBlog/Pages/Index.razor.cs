using System;
using System.IO;
using System.Linq;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using UfoBlog.Domain.Dto.Article;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace UfoBlog.Pages
{
    public partial class Index
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
            sayList = context.DynamicMan.AsNoTracking() //说说列表
                .Where(x => !x.IsDelete).OrderByDescending(x => x.CreateTime).AsEnumerable()
                .GroupJoin(context.LikeIt.Where(x => !x.IsDelete && x.Type == 2).ToList(), a => a.Id, b => b.TypeId,
                    (a, b) => new { SayIt = a, LikeIt = b })
                    .SelectMany(x => x.LikeIt.DefaultIfEmpty(), (a, b) =>
                    {
                        var data = _mapper.Map<DynamicManDto>(a.SayIt);
                        if (b != null) data.IsLikeIt = true;
                        return data;
                    }).ToList();

            otherInfo.Number = context.DynamicMan.Where(x => !x.IsDelete)?.Count() ?? 0;    //说说数量
            otherInfo.LikeIt = context.LikeIt.Where(x => x.Type == 2 && !x.IsDelete)?.Count() ?? 0; //点赞数量
            otherInfo.Comments = 0; //评论数量-未开通评论功能
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
        /// 说说点赞处理
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sayList"></param>
        /// <returns></returns>
        private async Task LikeDynamicManHandle(int id)
        {
            sayList = await _articleService.LikeDynamicManHandle(id, sayList);
        }

        #region 阅读量处理

        /// <summary>
        /// 阅读量处理
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private async Task ViewDynamicManHandle(int id) 
        {
            using var context = _dbFactory.CreateDbContext();

            var ip = _httpContext.HttpContext.Connection.RemoteIpAddress.ToString();
            var data = context.ViewNum.FirstOrDefault(x => x.Type == 2 && x.IP.Equals(ip));
            
            if (data == null)
            {
                var sayit = context.DynamicMan.FirstOrDefault(x => !x.IsDelete && x.Id == id);
                sayit.ViewNum++;
                context.DynamicMan.Update(sayit);

                context.ViewNum.Add(new Domain.Model.Article.ViewNum { IP = ip, Type = 2, TypeId = id, IsDelete = false });
                await context.SaveChangesAsync();
            }
        }

        #endregion
    }
}
