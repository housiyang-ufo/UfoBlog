using AntDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UfoBlog.Shared
{
    public partial class SiderNav
    {
        /// <summary>
        /// 当前选择项
        /// </summary>
        private string Selected { get; set; }

        protected override void OnInitialized()
        {
            Selected = Navs.FirstOrDefault().Icon;
        }

        /// <summary>
        /// 导航选中 Class
        /// </summary>
        /// <param name="name"></param>
        private void OnClickTar(string name)
        {
            if (Selected.Equals(name))
                return;

            Selected = name;
            _navigationManager.NavigateTo(Navs.Find(x=>x.Icon.Equals(name)).Url);
        }
    }
}
