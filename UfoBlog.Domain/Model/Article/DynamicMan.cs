using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Model.Article
{
    /// <summary>
    /// 个人动态（起的屎一样的名字 = DynamicMan）
    /// </summary>
    public class DynamicMan : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [Required]
        [Column(TypeName = "text")]
        public string Content { get; set; }

        #region 图片1~9
        [Column(TypeName = "nvarchar(500)")]
        public string Picture1 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Picture2 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Picture3 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Picture4 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Picture5 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Picture6 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Picture7 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Picture8 { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Picture9 { get; set; }
        #endregion

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
