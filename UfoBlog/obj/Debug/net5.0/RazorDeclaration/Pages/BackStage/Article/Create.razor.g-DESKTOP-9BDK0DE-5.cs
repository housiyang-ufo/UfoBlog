// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UfoBlog.Pages.BackStage.Article
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using UfoBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using UfoBlog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using UfoBlog.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using UfoBlog.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\Create.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\Create.razor"
using UfoBlog.Data.Dto.Article;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\Create.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Article/Create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\Create.razor"
       
    #region 初始化参数
    private string titleValue;

    //标签
    private string tagValue;
    private List<string> tags = new List<string>();
    private List<TagDto> options;
    private bool inputVisible = false;

    //分类
    private int typeValue;
    private List<UfoBlog.Data.Model.Article.Category> types;

    //图片
    private const string url = "https://shawnzeng.com/wp-content/themes/Giligili/img/default_bg.jpg";
    private string imageUrl = "https://shawnzeng.com/wp-content/themes/Giligili/img/default_bg.jpg";

    //加载
    private bool loading = false;
    RenderFragment antIcon =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(0, "<Icon Type=\"loading\" Theme=\"outline\" Style=\"font-size: 24px\" Spin b-8ax2yd75rc></Icon>");
        }
#nullable restore
#line 119 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\Create.razor"
                                                                                                 ;
#endregion

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<BlogContext> _dbFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService _notice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration conf { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMapper _mapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _js { get; set; }
    }
}
#pragma warning restore 1591
