using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UfoBlog.Domain.Model.Article
{
    /// <summary>
    /// 标签表
    /// </summary>
    public class Tag : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string Name { get; set; }

        /// <summary>
        /// 引用数量
        /// </summary>
        [Column(TypeName = "int")]
        public int Number { get; set; }
    }
}
