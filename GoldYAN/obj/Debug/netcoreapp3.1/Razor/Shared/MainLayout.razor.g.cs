#pragma checksum "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2479915b2a041677ac2a3b3f6a43be1deb17e103"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "wrapper");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.OpenComponent<GoldYAN.Shared.SidebarNav>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    \r\n    \r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "content-wrapper");
            __builder.AddAttribute(7, "class", "d-flex flex-column");
            __builder.AddMarkupContent(8, "\r\n        \r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "content");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "top-row px-4 auth");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenComponent<GoldYAN.Shared.LoginDisplay>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddMarkupContent(17, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n            \r\n            ");
            __builder.OpenComponent<GoldYAN.Shared.TopNavBar>(19);
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n            \r\n            \r\n            ");
            __builder.AddContent(21, 
#nullable restore
#line 23 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n        \r\n        \r\n        ");
            __builder.OpenElement(24, "footer");
            __builder.AddAttribute(25, "class", "sticky-footer bg-white");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "container my-auto");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenComponent<GoldYAN.Shared.Footer>(30);
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(36, "<a class=\"scroll-to-top rounded\" href=\"#page-top\">\r\n    <i class=\"fas fa-angle-up\"></i>\r\n</a>\r\n\r\n");
            __builder.AddMarkupContent(37, @"<div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <form method=""post"" action=""Identity/Account/LogOut"">
                    <button type=""submit"" class=""nav-link btn btn-link btn-primary"">Log out</button>
                </form>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Shared\MainLayout.razor"
 
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavManager.NavigateTo("Identity/Account/Login");
        }
        else
        {

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
