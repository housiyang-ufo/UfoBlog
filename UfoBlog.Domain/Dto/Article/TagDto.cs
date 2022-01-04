using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Dto.Article
{
    public class TagDto : BaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 引用数量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool Checked { get; set; }
    }
}
