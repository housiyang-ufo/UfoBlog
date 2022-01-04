using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UfoBlog.Domain.Model
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class Admin : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Uno { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PassWord { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string ImageUrl { get; set; }

    }
}
