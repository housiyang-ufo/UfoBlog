#pragma checksum "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d090d5fb6fd89236906c45a2a88a31e0420f1ea"
// <auto-generated/>
#pragma warning disable 1591
namespace UfoBlog.Pages.OnStage
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
#line 2 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
using UfoBlog.Domain.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
using UfoBlog.Domain.Dto.Article;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Article")]
    public partial class Article : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "project");
            __builder.AddAttribute(2, "b-6c3d05uvsy");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "userInfo");
            __builder.AddAttribute(5, "b-6c3d05uvsy");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "myDiv");
            __builder.AddAttribute(8, "b-6c3d05uvsy");
            __builder.AddMarkupContent(9, "<p b-6c3d05uvsy>文章列表</p>\r\n            ");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "b-6c3d05uvsy");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                 $"{DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-GB"))} {DateTime.Now.Day}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "secondDiv");
            __builder.AddAttribute(16, "b-6c3d05uvsy");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "itemDiv");
            __builder.AddAttribute(19, "b-6c3d05uvsy");
            __builder.OpenComponent<AntDesign.Tooltip>(20);
            __builder.AddAttribute(21, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.Placement>(
#nullable restore
#line 19 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                     Placement.Top

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>>(
#nullable restore
#line 19 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                                             "写作数量"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "item-span");
                __builder2.AddAttribute(26, "b-6c3d05uvsy");
                __builder2.OpenElement(27, "span");
                __builder2.AddAttribute(28, "class", "span");
                __builder2.AddAttribute(29, "b-6c3d05uvsy");
                __builder2.AddContent(30, 
#nullable restore
#line 21 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                            otherInfo.Number.ToString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.AddMarkupContent(32, "<span class=\"span-second\" b-6c3d05uvsy>The Number</span>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenComponent<AntDesign.Tooltip>(34);
            __builder.AddAttribute(35, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.Placement>(
#nullable restore
#line 25 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                     Placement.Top

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>>(
#nullable restore
#line 25 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                                             "点赞数量"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "item-span");
                __builder2.AddAttribute(40, "b-6c3d05uvsy");
                __builder2.OpenElement(41, "span");
                __builder2.AddAttribute(42, "class", "span");
                __builder2.AddAttribute(43, "b-6c3d05uvsy");
                __builder2.AddContent(44, 
#nullable restore
#line 27 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                            otherInfo.LikeIt.ToString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.AddMarkupContent(46, "<span class=\"span-second\" b-6c3d05uvsy>The Like It</span>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenComponent<AntDesign.Tooltip>(48);
            __builder.AddAttribute(49, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.Placement>(
#nullable restore
#line 31 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                     Placement.Top

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>>(
#nullable restore
#line 31 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                                             "评论数量"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "item-span");
                __builder2.AddAttribute(54, "b-6c3d05uvsy");
                __builder2.OpenElement(55, "span");
                __builder2.AddAttribute(56, "class", "span");
                __builder2.AddAttribute(57, "b-6c3d05uvsy");
                __builder2.AddContent(58, 
#nullable restore
#line 33 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                            otherInfo.Comments.ToString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.AddMarkupContent(60, "<span class=\"span-second\" b-6c3d05uvsy>The Comments</span>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            <div b-6c3d05uvsy></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
      
        if (articles != null && articles.Count > 0)
        {
            var length = articles.Count;
            for (var i = 1; i <= length; i++)
            {
                var index = i - 1;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "containerDiv");
            __builder.AddAttribute(64, "b-6c3d05uvsy");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "imgDiv");
            __builder.AddAttribute(67, "style", "background-image:url(" + (
#nullable restore
#line 49 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                                                     articles[index].Image

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddAttribute(68, "b-6c3d05uvsy");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "context-p");
            __builder.AddAttribute(72, "b-6c3d05uvsy");
            __builder.OpenElement(73, "a");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                     ()=>NavToDetailById(articles[index].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "b-6c3d05uvsy");
            __builder.OpenElement(76, "h3");
            __builder.AddAttribute(77, "style", "font-size: 16px;font-weight:700;");
            __builder.AddAttribute(78, "b-6c3d05uvsy");
            __builder.AddContent(79, 
#nullable restore
#line 52 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                                                          articles[index].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.OpenElement(81, "p");
            __builder.AddAttribute(82, "class", "p");
            __builder.AddAttribute(83, "b-6c3d05uvsy");
            __builder.AddContent(84, 
#nullable restore
#line 53 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
                                          articles[index].Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
            }
        }

    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.OpenComponent<UfoBlog.Pages.Components.Message>(86);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\OnStage\Article.razor"
       
    int _pageIndex = 1;
    int _pageSize = 10;
    int _total = 0;
    List<ArticleDto> articles;

    OtherInfo otherInfo = new OtherInfo();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<BlogContext> _dbFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMapper _mapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _js { get; set; }
    }
}
#pragma warning restore 1591