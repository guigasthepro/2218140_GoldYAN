#pragma checksum "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Utilities_other.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ae90a2d31caa4520badf5a807e13c9301f4d99f"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Utilities-other")]
    public partial class Utilities_other : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\">\r\n\r\n    \r\n    <h1 class=\"h3 mb-1 text-gray-800\">Animation Utilities</h1>\r\n    <p class=\"mb-4\">Bootstrap\'s default utility classes can be found on the official <a href=\"https://getbootstrap.com/docs\">Bootstrap Documentation</a> page. The custom utilities below were created to extend this theme past the default utility classes built into Bootstrap\'s framework.</p>\r\n\r\n    \r\n    <div class=\"row\">\r\n\r\n        \r\n        <div class=\"col-lg-6\">\r\n\r\n            <div class=\"card position-relative\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Grow In Animation Utilty</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"mb-3\">\r\n                        <code>.animated--grow-in</code>\r\n                    </div>\r\n                    <div class=\"small mb-1\">Navbar Dropdown Example:</div>\r\n                    <nav class=\"navbar navbar-expand navbar-light bg-light mb-4\">\r\n                        <a class=\"navbar-brand\" href=\"#\">Navbar</a>\r\n                        <ul class=\"navbar-nav ml-auto\">\r\n                            <li class=\"nav-item dropdown\">\r\n                                <a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                                    Dropdown\r\n                                </a>\r\n                                <div class=\"dropdown-menu dropdown-menu-right animated--grow-in\" aria-labelledby=\"navbarDropdown\">\r\n                                    <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                                    <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                                    <div class=\"dropdown-divider\"></div>\r\n                                    <a class=\"dropdown-item\" href=\"#\">Something else here</a>\r\n                                </div>\r\n                            </li>\r\n                        </ul>\r\n                    </nav>\r\n                    <p class=\"mb-0 small\">Note: This utility animates the CSS transform property, meaning it will override any existing transforms on an element being animated! In this theme, the grow in animation is only being used on dropdowns within the navbar.</p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        \r\n        <div class=\"col-lg-6\">\r\n\r\n            <div class=\"card position-relative\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Fade In Animation Utilty</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"mb-3\">\r\n                        <code>.animated--fade-in</code>\r\n                    </div>\r\n                    <div class=\"small mb-1\">Navbar Dropdown Example:</div>\r\n                    <nav class=\"navbar navbar-expand navbar-light bg-light mb-4\">\r\n                        <a class=\"navbar-brand\" href=\"#\">Navbar</a>\r\n                        <ul class=\"navbar-nav ml-auto\">\r\n                            <li class=\"nav-item dropdown\">\r\n                                <a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                                    Dropdown\r\n                                </a>\r\n                                <div class=\"dropdown-menu dropdown-menu-right animated--fade-in\" aria-labelledby=\"navbarDropdown\">\r\n                                    <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                                    <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                                    <div class=\"dropdown-divider\"></div>\r\n                                    <a class=\"dropdown-item\" href=\"#\">Something else here</a>\r\n                                </div>\r\n                            </li>\r\n                        </ul>\r\n                    </nav>\r\n                    <div class=\"small mb-1\">Dropdown Button Example:</div>\r\n                    <div class=\"dropdown mb-4\">\r\n                        <button class=\"btn btn-primary dropdown-toggle\" type=\"button\" id=\"dropdownMenuButton\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                            Dropdown\r\n                        </button>\r\n                        <div class=\"dropdown-menu animated--fade-in\" aria-labelledby=\"dropdownMenuButton\" x-placement=\"bottom-start\" style=\"position: absolute; will-change: transform; top: 0px; left: 0px; transform: translate3d(0px, 38px, 0px);\">\r\n                            <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                            <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                            <a class=\"dropdown-item\" href=\"#\">Something else here</a>\r\n                        </div>\r\n                    </div>\r\n                    <p class=\"mb-0 small\">Note: This utility animates the CSS opacity property, meaning it will override any existing opacity on an element being animated!</p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
