// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UfoBlog.Pages.BackStage.Other
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using UfoBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using UfoBlog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using UfoBlog.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\_Imports.razor"
using UfoBlog.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\TagPage.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\TagPage.razor"
using UfoBlog.Domain.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\TagPage.razor"
using UfoBlog.Domain.Dto.Article;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Tag")]
    public partial class TagPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\TagPage.razor"
       
    int _pageIndex = 1;
    int _pageSize = 10;
    int _total = 0;

    List<TagDto> tagDtos;
    ITable table;

    RenderFragment icon =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(0, "<Icon Type=\"exclamation-circle\" Theme=\"outline\" b-jy0oqwv0cr></Icon>");
        }
#nullable restore
#line 48 "c:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\TagPage.razor"
                                                                                 ;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<BlogContext> _dbFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService _notice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModalService _modalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMapper _mapper { get; set; }
    }
}
#pragma warning restore 1591
