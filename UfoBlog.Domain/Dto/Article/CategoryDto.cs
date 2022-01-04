using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Dto.Article
{
    public class CategoryDto : BaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Number { get; set; }
    }
}
