using System;
using UfoBlog.Domain.Dto;

namespace UfoBlog.Domain.Dto.Article
{
    public class ArticleDto : BaseModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 图片 
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 描述
        /// </summary>]
        public string Description { get; set; }

        /// <summary>
        /// 标签（逗号,分割）
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

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
        /// </summary>
        public int ViewNum { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string TypeName { get; set; }
    }
}
