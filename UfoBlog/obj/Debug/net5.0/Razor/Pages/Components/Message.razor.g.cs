#pragma checksum "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6afaa21e5cb94bfcaa116ea1748b8e15b84190d4"
// <auto-generated/>
#pragma warning disable 1591
namespace UfoBlog.Pages.Components
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
#line 1 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor"
using UfoBlog.Domain.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor"
using UfoBlog.Domain.Dto.OnStage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor"
using UfoBlog.Domain.Dto.Article;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    public partial class Message : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "message");
            __builder.AddAttribute(2, "id", "message");
            __builder.AddAttribute(3, "b-4r2cu95arz");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "Hitokoto");
            __builder.AddAttribute(6, "id", "Hitokoto");
            __builder.AddAttribute(7, "b-4r2cu95arz");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "font");
            __builder.AddAttribute(10, "b-4r2cu95arz");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor"
                           wordStr.Hitokoto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "from");
            __builder.AddAttribute(15, "b-4r2cu95arz");
            __builder.AddMarkupContent(16, "——");
            __builder.AddContent(17, 
#nullable restore
#line 13 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor"
                             wordStr.From

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        <div style=\"clear:both;\" b-4r2cu95arz></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    <div class=\"contentDiv\" id=\"other\" b-4r2cu95arz></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Message.razor"
       
    private List<TagDto> tagDto = new List<TagDto>();
    private WordString wordStr = new WordString();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<BlogContext> _dbFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration conf { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMapper _mapper { get; set; }
    }
}
#pragma warning restore 1591