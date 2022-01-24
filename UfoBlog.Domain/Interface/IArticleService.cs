using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UfoBlog.Domain.Dto.Article;

namespace UfoBlog.Domain.Interface
{
    public interface IArticleService
    {
        /// <summary>
        /// 说说点赞处理
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sayList"></param>
        /// <returns></returns>
        Task<List<DynamicManDto>> LikeDynamicManHandle(int id, List<DynamicManDto> sayList);
    }
}
