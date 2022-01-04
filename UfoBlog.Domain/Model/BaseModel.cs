using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Model
{
    /// <summary>
    /// 实体基类
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 软删除
        /// </summary>
        [Required]
        [Column(TypeName = "bit")]
        public bool IsDelete { get; set; } = false;
    }
}
