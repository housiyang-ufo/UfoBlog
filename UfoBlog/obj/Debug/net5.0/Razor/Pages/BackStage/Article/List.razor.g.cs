#pragma checksum "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09c3f0599444a05513b27a9a3d758e68efabb607"
// <auto-generated/>
#pragma warning disable 1591
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
using UfoBlog.Domain;

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
#line 3 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
using UfoBlog.Domain.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
using UfoBlog.Domain.Dto.Article;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Article")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "containerDiv");
            __builder.AddAttribute(2, "b-w7m9jshr76");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "topDiv");
            __builder.AddAttribute(5, "b-w7m9jshr76");
            __builder.OpenComponent<AntDesign.Breadcrumb>(6);
            __builder.AddAttribute(7, "Style", "margin-bottom: 20px !important;");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.BreadcrumbItem>(9);
                __builder2.AddAttribute(10, "Href", "/Admin/Index");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "主页");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<AntDesign.BreadcrumbItem>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "文章列表");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenComponent<AntDesign.Button>(18);
            __builder.AddAttribute(19, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                       ButtonType.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                                     ()=> { NavigationManager.NavigateTo("Admin/Article/Create"); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "新建文章");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.OpenComponent<AntDesign.Table<ArticleDto>>(24);
            __builder.AddAttribute(25, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ArticleDto>>(
#nullable restore
#line 25 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                        articles

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Total", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                  _total

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnPageIndexChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.PaginationEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.PaginationEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                              PageIndexChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "PageIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                            _pageIndex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "PageIndexChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _pageIndex = __value, _pageIndex))));
            __builder.AddAttribute(30, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                           _pageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "PageSizeChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _pageSize = __value, _pageSize))));
            __builder.AddAttribute(32, "SelectedRows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ArticleDto>>(
#nullable restore
#line 29 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                               selectedRows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "SelectedRowsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<ArticleDto>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<ArticleDto>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedRows = __value, selectedRows))));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<ArticleDto>)((context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.Selection>(35);
                __builder2.AddAttribute(36, "Key", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                          context.Id.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __Blazor.UfoBlog.Pages.BackStage.Article.List.TypeInference.CreateColumn_0(__builder2, 38, 39, "标题", 40, "400", 41, true, 42, 
#nullable restore
#line 32 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                         context.Title

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Title = __value, context.Title)), 44, () => context.Title, 45, (__builder3) => {
                    __builder3.OpenElement(46, "a");
                    __builder3.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                         ()=> NavigationManager.NavigateTo($"/Detail/{context.Id}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "b-w7m9jshr76");
                    __builder3.AddContent(49, 
#nullable restore
#line 33 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                                                                      context.Title

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                );
                __builder2.AddMarkupContent(50, "\r\n        ");
                __Blazor.UfoBlog.Pages.BackStage.Article.List.TypeInference.CreateColumn_1(__builder2, 51, 52, "类型", 53, 
#nullable restore
#line 35 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                         context.Type

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Type = __value, context.Type)), 55, () => context.Type, 56, (__builder3) => {
                    __builder3.AddContent(57, 
#nullable restore
#line 35 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                                        context.TypeDto.Name

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.AddMarkupContent(58, "\r\n        ");
                __Blazor.UfoBlog.Pages.BackStage.Article.List.TypeInference.CreateColumn_2(__builder2, 59, 60, "标签", 61, 
#nullable restore
#line 36 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                   context.Tag

#line default
#line hidden
#nullable disable
                , 62, "300", 63, true, 64, (__builder3) => {
#nullable restore
#line 37 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
              
                if (!string.IsNullOrWhiteSpace(context.Tag))
                {
                    var tags = context.Tag.Split(",");
                    var length = tags.Count();
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                     for (var i = 1; i <= length; i++)
                    {
                        var index = i - 1;

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<AntDesign.Tag>(65);
                    __builder3.AddAttribute(66, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                     SwitchColor(i)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(68, 
#nullable restore
#line 45 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                                      tags[index]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 46 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                     
                }
            

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(69, "\r\n        ");
                __Blazor.UfoBlog.Pages.BackStage.Article.List.TypeInference.CreateColumn_3(__builder2, 70, 71, "创建时间", 72, "yyyy-MM-dd", 73, 
#nullable restore
#line 50 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                           context.CreateTime

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.CreateTime = __value, context.CreateTime)), 75, () => context.CreateTime);
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenComponent<AntDesign.ActionColumn>(77);
                __builder2.AddAttribute(78, "Title", "操作");
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Space>(80);
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.SpaceItem>(82);
                        __builder4.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Button>(84);
                            __builder5.AddAttribute(85, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                            ()=>Edit(context.Id)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(87, "编辑");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(88, "\r\n                ");
                        __builder4.OpenComponent<AntDesign.SpaceItem>(89);
                        __builder4.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Button>(91);
                            __builder5.AddAttribute(92, "Danger", true);
                            __builder5.AddAttribute(93, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                                   ()=>ShowConfirm(context.Id)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(95, "删除");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(96, (__value) => {
#nullable restore
#line 23 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                 table = (AntDesign.Table<ArticleDto>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
       
    #region 初始化参数

    int _pageIndex = 1;
    int _pageSize = 10;
    int _total = 0;

    IEnumerable<ArticleDto> selectedRows;

    List<ArticleDto> articles;
    ITable table;

    string[] color = { "#f50", "#2db7f5", "#87d068", "#108ee9", "HotPink", "DarkRed", "rgb(143, 201, 146)", "rgb(105, 58, 236)" };

    RenderFragment icon =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<AntDesign.Icon>(97);
            __builder2.AddAttribute(98, "Type", "exclamation-circle");
            __builder2.AddAttribute(99, "Theme", "outline");
            __builder2.CloseComponent();
        }
#nullable restore
#line 74 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Article\List.razor"
                                                                                 ;

    #endregion

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<BlogContext> _dbFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService _notice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModalService _modalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMapper _mapper { get; set; }
    }
}
namespace __Blazor.UfoBlog.Pages.BackStage.Article.List
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateColumn_0<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TData __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Ellipsis", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "FieldChanged", __arg4);
        __builder.AddAttribute(__seq5, "FieldExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateColumn_1<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_2<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TData __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "Ellipsis", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_3<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TData __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Format", __arg1);
        __builder.AddAttribute(__seq2, "Field", __arg2);
        __builder.AddAttribute(__seq3, "FieldChanged", __arg3);
        __builder.AddAttribute(__seq4, "FieldExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
