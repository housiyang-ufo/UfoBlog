using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UfoBlog.Domain.Model.Article
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [Required]
        [Column(TypeName = "text")]
        public string Content { get; set; }

        /// <summary>
        /// 图片 
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Image { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        /// <summary>
        /// 标签（逗号,分割）
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Tag { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int Type { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int LikeIt { get; set; }

        /// <summary>
        /// 评论数量
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int Comments { get; set; }

        /// <summary>
        /// 阅读量
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int ViewNum { get; set; }
    }
}
