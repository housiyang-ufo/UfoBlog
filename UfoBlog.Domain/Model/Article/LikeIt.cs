using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UfoBlog.Domain.Model.Article
{
    /// <summary>
    /// 点赞
    /// </summary>
    public class LikeIt : BaseModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 用户IP地址
        /// </summary>
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string IP { get; set; }

        /// <summary>
        /// 1文章, 2说说
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int Type { get; set; }

        /// <summary>
        /// 外键Id
        /// </summary>
        [Required]
        [Column(TypeName = "int")]
        public int TypeId { get; set; }
    }
}
