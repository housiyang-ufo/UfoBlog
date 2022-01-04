using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Dto.Article
{
    public class DynamicManDto : BaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 内容
        /// </summary>

        public string Content { get; set; }

        #region 图片1~9

        public string Picture1 { get; set; }

        public string Picture2 { get; set; }

        public string Picture3 { get; set; }

        public string Picture4 { get; set; }

        public string Picture5 { get; set; }

        public string Picture6 { get; set; }

        public string Picture7 { get; set; }

        public string Picture8 { get; set; }

        public string Picture9 { get; set; }
        #endregion

        /// <summary>
        /// 点赞数量
        /// </summary>
        public int LikeIt { get; set; }

        /// <summary>
        /// 评论数量
        /// </summary>
        public int Comments { get; set; }

        /// <summary>
        /// 阅读量
        /// </summary>]
        public int ViewNum { get; set; }
    }
}
