using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UfoBlog.Domain.Model.Article
{
    /// <summary>
    /// 文章类型
    /// </summary>
    public class Category : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        /// <summary>
        /// 引用数量
        /// </summary>
        [Column(TypeName = "int")]
        public int Number { get; set; }
    }
}
