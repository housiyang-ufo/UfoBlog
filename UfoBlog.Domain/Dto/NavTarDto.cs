using System.Collections.Generic;

namespace UfoBlog.Domain.Dto
{
    /// <summary>
    /// 导航栏
    /// </summary>
    public class NavTarDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 标签别名
        /// </summary>
        public string IconName { get; set; }

        /// <summary>
        /// 子项
        /// </summary>
        public List<NavTarDto> navTarDtos { get; set; }
    }
}
