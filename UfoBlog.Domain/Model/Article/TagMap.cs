using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Model.Article
{
    /// <summary>
    /// 标签-文章映射表（拥有快捷的查询优势）
    /// </summary>
    public class TagMap : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 标签Id
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int TagId { get; set; }

        /// <summary>
        /// 文章Id
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int ArticleId { get; set; }
    }
}
