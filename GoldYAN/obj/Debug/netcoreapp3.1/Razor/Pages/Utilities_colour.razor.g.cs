#pragma checksum "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Utilities_colour.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8edf104be52900e13a1e9748da79faeae36f3faf"
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
#nullable restore
#line 10 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Utilities-colour")]
    public partial class Utilities_colour : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\">\r\n\r\n    \r\n    <h1 class=\"h3 mb-1 text-gray-800\">Color Utilities</h1>\r\n    <p class=\"mb-4\">Bootstrap\'s default utility classes can be found on the official <a href=\"https://getbootstrap.com/docs\">Bootstrap Documentation</a> page. The custom utilities below were created to extend this theme past the default utility classes built into Bootstrap\'s framework.</p>\r\n\r\n    \r\n    <div class=\"row\">\r\n\r\n        \r\n        <div class=\"col-lg-4\">\r\n\r\n            \r\n            <div class=\"card shadow mb-4\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Custom Text Color Utilities</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p class=\"text-gray-100 p-3 bg-dark m-0\">.text-gray-100</p>\r\n                    <p class=\"text-gray-200 p-3 bg-dark m-0\">.text-gray-200</p>\r\n                    <p class=\"text-gray-300 p-3 bg-dark m-0\">.text-gray-300</p>\r\n                    <p class=\"text-gray-400 p-3 bg-dark m-0\">.text-gray-400</p>\r\n                    <p class=\"text-gray-500 p-3 m-0\">.text-gray-500</p>\r\n                    <p class=\"text-gray-600 p-3 m-0\">.text-gray-600</p>\r\n                    <p class=\"text-gray-700 p-3 m-0\">.text-gray-700</p>\r\n                    <p class=\"text-gray-800 p-3 m-0\">.text-gray-800</p>\r\n                    <p class=\"text-gray-900 p-3 m-0\">.text-gray-900</p>\r\n                </div>\r\n            </div>\r\n\r\n            \r\n            <div class=\"card shadow mb-4\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Custom Font Size Utilities</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p class=\"text-xs\">.text-xs</p>\r\n                    <p class=\"text-lg mb-0\">.text-lg</p>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        \r\n        <div class=\"col-lg-4\">\r\n\r\n            \r\n            <div class=\"card shadow mb-4\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Custom Background Gradient Utilities</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"px-3 py-5 bg-gradient-primary text-white\">.bg-gradient-primary</div>\r\n                    <div class=\"px-3 py-5 bg-gradient-success text-white\">.bg-gradient-success</div>\r\n                    <div class=\"px-3 py-5 bg-gradient-info text-white\">.bg-gradient-info</div>\r\n                    <div class=\"px-3 py-5 bg-gradient-warning text-white\">.bg-gradient-warning</div>\r\n                    <div class=\"px-3 py-5 bg-gradient-danger text-white\">.bg-gradient-danger</div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        \r\n        <div class=\"col-lg-4\">\r\n\r\n            \r\n            <div class=\"card shadow mb-4\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Custom Grayscale Background Utilities</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"p-3 bg-gray-100\">.bg-gray-100</div>\r\n                    <div class=\"p-3 bg-gray-200\">.bg-gray-200</div>\r\n                    <div class=\"p-3 bg-gray-300\">.bg-gray-300</div>\r\n                    <div class=\"p-3 bg-gray-400\">.bg-gray-400</div>\r\n                    <div class=\"p-3 bg-gray-500 text-white\">.bg-gray-500</div>\r\n                    <div class=\"p-3 bg-gray-600 text-white\">.bg-gray-600</div>\r\n                    <div class=\"p-3 bg-gray-700 text-white\">.bg-gray-700</div>\r\n                    <div class=\"p-3 bg-gray-800 text-white\">.bg-gray-800</div>\r\n                    <div class=\"p-3 bg-gray-900 text-white\">.bg-gray-900</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BancosController VB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EncomendasController EC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController CC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MoldesController MoldesController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoProdutoController TPRC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoPecaController TPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModelosController MC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ColaboradoresController colaboradoresController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoModeloController CMC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
