using System.Linq;
using UfoBlog.Domain.Model;
using System.Threading.Tasks;
using UfoBlog.Domain.Interface;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using UfoBlog.Domain.Dto.Article;
using Microsoft.EntityFrameworkCore;

namespace UfoBlog.Application.Service
{
    public class ArticleService : IArticleService
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly IDbContextFactory<BlogContext> _dbFactory;

        public ArticleService(IDbContextFactory<BlogContext> dbFactory, IHttpContextAccessor httpContext)
        {
            _dbFactory = dbFactory;
            _httpContext = httpContext;
        }

        #region 点赞处理

        /// <summary>
        /// 说说点赞处理
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sayList"></param>
        /// <returns></returns>
        public async Task<List<DynamicManDto>> LikeDynamicManHandle(int id, List<DynamicManDto> sayList)
        {
            using var context = _dbFactory.CreateDbContext();

            var _list = (List<DynamicManDto>)null;
            var ip = _httpContext.HttpContext.Connection.RemoteIpAddress.ToString();
            var data = context.LikeIt.FirstOrDefault(x => x.Type == 2 && x.IP.Equals(ip));
            var sayit = context.DynamicMan.FirstOrDefault(x => !x.IsDelete && x.Id == id);
            if (data != null)
            {
                sayit.LikeIt--;
                context.DynamicMan.Update(sayit);
                context.LikeIt.Remove(data);
                _list = UpdateSayList(false, id, sayList);
            }
            else
            {
                sayit.LikeIt++;
                context.DynamicMan.Update(sayit);
                context.LikeIt.Add(new Domain.Model.Article.LikeIt { IP = ip, Type = 2, TypeId = sayit.Id, IsDelete = false });
                _list = UpdateSayList(true, id, sayList);
            }

            await context.SaveChangesAsync();
            return _list;
        }

        /// <summary>
        /// 点赞数量和状态更新
        /// </summary>
        /// <param name="isTrue"></param>
        /// <param name="id"></param>
        private List<DynamicManDto> UpdateSayList(bool isTrue, int id, List<DynamicManDto> sayList)
        {
            sayList.FirstOrDefault(x => x.Id == id).IsLikeIt = isTrue;

            if (isTrue)
                sayList.FirstOrDefault(x => x.Id == id).LikeIt++;
            else
                sayList.FirstOrDefault(x => x.Id == id).LikeIt--;

            return sayList;
        }

        #endregion
    }
}
