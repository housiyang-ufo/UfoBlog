// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Login.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Login.razor"
       
    public class Model
    {
        [Required, DisplayName("")]
        public string Username { get; set; }
        [Required, DisplayName("")]
        public string Password { get; set; }
    }

    private bool loading = false;

    private Model model = new Model();

    /// <summary>
    /// 登录
    /// </summary>
    /// <param name="editContext"></param>
    private async Task OnFinish(EditContext editContext)
    {
        if (loading)
            return;

        try
        {
            loading = true;
            using var context = DbFactory.CreateDbContext();

            var list = await context.Admin.AsNoTracking().Where(x => x.Uno.Equals(model.Username) && x.PassWord.Equals(model.Password)).ToListAsync();
            if (list.Count > 0)
            {
                NavigationManager.NavigateTo("/Admin/index");
            }

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\ufo233\OneDrive\Documents\UfoBlog\UfoBlog\Pages\Components\Login.razor"
                                        
        }
        finally 
        {
            loading = false;
        }


    }

    private void OnFinishFailed(EditContext editContext)
    {
        Console.WriteLine($"登录失败:请输入用户名和秘密");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<BlogContext> DbFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService _message { get; set; }
    }
}
#pragma warning restore 1591
