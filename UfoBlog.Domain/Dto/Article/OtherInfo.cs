using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Dto.Article
{
    public class OtherInfo
    {
        /// <summary>
        /// 点赞数量
        /// </summary>
        public int LikeIt { get; set; }

        /// <summary>
        /// 评论数量
        /// </summary>
        public int Comments { get; set; }

        /// <summary>
        /// 写作数量
        /// </summary>
        public int Number { get; set; }


    }
}
