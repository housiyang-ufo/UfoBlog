#pragma checksum "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b27c3fce16468ac4488e1996dfdb923b10c66f92"
// <auto-generated/>
#pragma warning disable 1591
namespace UfoBlog.Pages.BackStage.Other
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
#line 4 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
using AutoMapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
using UfoBlog.Domain.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
using UfoBlog.Domain.Dto.Article;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BackLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Dynamic")]
    public partial class DynamicMan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "containerDiv");
            __builder.AddAttribute(2, "b-piaw6fpzea");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "topDiv");
            __builder.AddAttribute(5, "b-piaw6fpzea");
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
                    __builder3.AddMarkupContent(16, "动态列表");
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
#line 22 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                       ButtonType.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                     ShowModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "发布动态");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.OpenComponent<AntDesign.Table<DynamicManDto>>(24);
            __builder.AddAttribute(25, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<DynamicManDto>>(
#nullable restore
#line 27 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                        dynamicManDtos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Total", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                  _total

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnPageIndexChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AntDesign.PaginationEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AntDesign.PaginationEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                              PageIndexChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "PageIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                            _pageIndex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "PageIndexChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _pageIndex = __value, _pageIndex))));
            __builder.AddAttribute(30, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                           _pageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "PageSizeChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _pageSize = __value, _pageSize))));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<DynamicManDto>)((context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.Selection>(33);
                __builder2.AddAttribute(34, "Key", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                          context.Id.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __Blazor.UfoBlog.Pages.BackStage.Other.DynamicMan.TypeInference.CreateColumn_0(__builder2, 36, 37, "内容", 38, "200", 39, true, 40, 
#nullable restore
#line 33 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                         context.Content

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Content = __value, context.Content)), 42, () => context.Content);
                __builder2.AddMarkupContent(43, "\r\n        ");
                __Blazor.UfoBlog.Pages.BackStage.Other.DynamicMan.TypeInference.CreateColumn_1(__builder2, 44, 45, "点赞量", 46, "600", 47, 
#nullable restore
#line 34 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                                             ColumnAlign.Center

#line default
#line hidden
#nullable disable
                , 48, 
#nullable restore
#line 34 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                          context.LikeIt

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.LikeIt = __value, context.LikeIt)), 50, () => context.LikeIt);
                __builder2.AddMarkupContent(51, "\r\n        ");
                __Blazor.UfoBlog.Pages.BackStage.Other.DynamicMan.TypeInference.CreateColumn_2(__builder2, 52, 53, "阅读量", 54, 
#nullable restore
#line 35 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                                  ColumnAlign.Center

#line default
#line hidden
#nullable disable
                , 55, 
#nullable restore
#line 35 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                          context.ViewNum

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.ViewNum = __value, context.ViewNum)), 57, () => context.ViewNum);
                __builder2.AddMarkupContent(58, "\r\n        ");
                __Blazor.UfoBlog.Pages.BackStage.Other.DynamicMan.TypeInference.CreateColumn_3(__builder2, 59, 60, "创建时间", 61, "yyyy-MM-dd", 62, 
#nullable restore
#line 36 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                           context.CreateTime

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.CreateTime = __value, context.CreateTime)), 64, () => context.CreateTime);
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.OpenComponent<AntDesign.ActionColumn>(66);
                __builder2.AddAttribute(67, "Title", "操作");
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Space>(69);
                    __builder3.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.SpaceItem>(71);
                        __builder4.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Button>(73);
                            __builder5.AddAttribute(74, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                            ()=>Edit(context.Id)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(76, "编辑");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(77, "\r\n                ");
                        __builder4.OpenComponent<AntDesign.SpaceItem>(78);
                        __builder4.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.Button>(80);
                            __builder5.AddAttribute(81, "Danger", true);
                            __builder5.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(83, "删除");
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
            __builder.AddComponentReferenceCapture(84, (__value) => {
#nullable restore
#line 25 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                 table = (AntDesign.Table<DynamicManDto>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 45 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
      
        RenderFragment footer = 

#line default
#line hidden
#nullable disable
            (__builder2) => {
                __builder2.OpenComponent<AntDesign.Template>(85);
                __builder2.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Button>(87);
                    __builder3.AddAttribute(88, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                              InputFileClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(89, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                           ButtonType.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "Loading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                              _loading

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(92, "\r\n                上传\r\n            ");
                    }
                    ));
                    __builder3.SetKey(
#nullable restore
#line 47 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                       "Upload" 

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.Button>(94);
                    __builder3.AddAttribute(95, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                              HandleOk

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(96, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                           ButtonType.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "Loading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                              _loading

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(99, "\r\n                发布\r\n            ");
                    }
                    ));
                    __builder3.SetKey(
#nullable restore
#line 52 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                 "Submit" 

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.Button>(101);
                    __builder3.AddAttribute(102, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                              HandleCancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(104, "取消");
                    }
                    ));
                    __builder3.SetKey(
#nullable restore
#line 57 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                     "Cancel" 

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
#nullable restore
#line 58 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                   ;
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Modal>(105);
            __builder.AddAttribute(106, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                    "发布动态"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                     _visible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "OnOk", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                  HandleOk

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(109, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                      HandleCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(110, "Footer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>?>(
#nullable restore
#line 64 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                    footer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "modelDiv");
                __builder2.AddAttribute(114, "b-piaw6fpzea");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(115);
                __builder2.AddAttribute(116, "id", "inputFile");
                __builder2.AddAttribute(117, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                 LoadFiles

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(118, "multiple", true);
                __builder2.AddAttribute(119, "style", "display:none");
                __builder2.AddComponentReferenceCapture(120, (__value) => {
#nullable restore
#line 66 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                                                                inputFile = (Microsoft.AspNetCore.Components.Forms.InputFile)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n            ");
                __builder2.OpenComponent<AntDesign.TextArea>(122);
                __builder2.AddAttribute(123, "Placeholder", "内容....");
                __builder2.AddAttribute(124, "AutoSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 67 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                                         textContent

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(126, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => textContent = __value, textContent))));
                __builder2.AddAttribute(127, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => textContent));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n            ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "img");
                __builder2.AddAttribute(131, "b-piaw6fpzea");
#nullable restore
#line 69 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                  
                    if (imageList != null && imageList.Count > 0)
                    {
                        var length = imageList.Count;
                        var host = conf.GetValue(typeof(String), "URLS");
                        for (var i = 1; i <= length; i++)
                        {
                            var index = i - 1;

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "b-piaw6fpzea");
                __builder2.OpenComponent<AntDesign.IconFont>(134);
                __builder2.AddAttribute(135, "Type", "icon-ziyuan");
                __builder2.AddAttribute(136, "Style", "position: relative; z-index: 5; top: -7px; left: 86px;cursor:pointer;");
                __builder2.AddAttribute(137, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                                                                                                                    ()=>ImageDelete(index)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n                                ");
                __builder2.OpenComponent<AntDesign.Image>(139);
                __builder2.AddAttribute(140, "Preview", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 79 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(141, "Src", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 79 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                              host + imageList[index].Substring(7)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(142, "Style", " position: relative; top: -22px;");
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 81 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                        }
                    }
                

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
       
    int _pageIndex = 1;
    int _pageSize = 10;
    int _total = 0;

    List<DynamicManDto> dynamicManDtos;
    ITable table;

    //对话框
    bool _visible = false;
    string textContent = null;

    //上传图片
    private List<string> imageList = new List<string>();

    RenderFragment icon =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<AntDesign.Icon>(143);
            __builder2.AddAttribute(144, "Type", "exclamation-circle");
            __builder2.AddAttribute(145, "Theme", "outline");
            __builder2.CloseComponent();
        }
#nullable restore
#line 104 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\BackStage\Other\DynamicMan.razor"
                                                                                 ;

private bool _loading = false;
private InputFile inputFile;



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<BlogContext> _dbFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService _notice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IconService iconService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration conf { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMapper _mapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _js { get; set; }
    }
}
namespace __Blazor.UfoBlog.Pages.BackStage.Other.DynamicMan
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateColumn_0<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TData __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Ellipsis", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "FieldChanged", __arg4);
        __builder.AddAttribute(__seq5, "FieldExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateColumn_1<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::AntDesign.ColumnAlign __arg2, int __seq3, TData __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "Align", __arg2);
        __builder.AddAttribute(__seq3, "Field", __arg3);
        __builder.AddAttribute(__seq4, "FieldChanged", __arg4);
        __builder.AddAttribute(__seq5, "FieldExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateColumn_2<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::AntDesign.ColumnAlign __arg1, int __seq2, TData __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Title", __arg0);
        __builder.AddAttribute(__seq1, "Align", __arg1);
        __builder.AddAttribute(__seq2, "Field", __arg2);
        __builder.AddAttribute(__seq3, "FieldChanged", __arg3);
        __builder.AddAttribute(__seq4, "FieldExpression", __arg4);
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