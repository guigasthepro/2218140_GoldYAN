#pragma checksum "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Buttons.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "912da35f9728a71e7da07f53c504580359e324c3"
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
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/buttons")]
    public partial class Buttons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\">\r\n\r\n        \r\n        <h1 class=\"h3 mb-4 text-gray-800\">Buttons</h1>\r\n\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-lg-6\">\r\n\r\n                \r\n                <div class=\"card shadow mb-4\">\r\n                    <div class=\"card-header py-3\">\r\n                        <h6 class=\"m-0 font-weight-bold text-primary\">Circle Buttons</h6>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <p>Use Font Awesome Icons (included with this theme package) along with the circle buttons as shown in the examples below!</p>\r\n                        \r\n                        <div class=\"mb-2\">\r\n                            <code>.btn-circle</code>\r\n                        </div>\r\n                        <a href=\"#\" class=\"btn btn-primary btn-circle\">\r\n                            <i class=\"fab fa-facebook-f\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-success btn-circle\">\r\n                            <i class=\"fas fa-check\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-info btn-circle\">\r\n                            <i class=\"fas fa-info-circle\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-warning btn-circle\">\r\n                            <i class=\"fas fa-exclamation-triangle\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-danger btn-circle\">\r\n                            <i class=\"fas fa-trash\"></i>\r\n                        </a>\r\n                        \r\n                        <div class=\"mt-4 mb-2\">\r\n                            <code>.btn-circle .btn-sm</code>\r\n                        </div>\r\n                        <a href=\"#\" class=\"btn btn-primary btn-circle btn-sm\">\r\n                            <i class=\"fab fa-facebook-f\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-success btn-circle btn-sm\">\r\n                            <i class=\"fas fa-check\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-info btn-circle btn-sm\">\r\n                            <i class=\"fas fa-info-circle\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-warning btn-circle btn-sm\">\r\n                            <i class=\"fas fa-exclamation-triangle\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-danger btn-circle btn-sm\">\r\n                            <i class=\"fas fa-trash\"></i>\r\n                        </a>\r\n                        \r\n                        <div class=\"mt-4 mb-2\">\r\n                            <code>.btn-circle .btn-lg</code>\r\n                        </div>\r\n                        <a href=\"#\" class=\"btn btn-primary btn-circle btn-lg\">\r\n                            <i class=\"fab fa-facebook-f\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-success btn-circle btn-lg\">\r\n                            <i class=\"fas fa-check\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-info btn-circle btn-lg\">\r\n                            <i class=\"fas fa-info-circle\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-warning btn-circle btn-lg\">\r\n                            <i class=\"fas fa-exclamation-triangle\"></i>\r\n                        </a>\r\n                        <a href=\"#\" class=\"btn btn-danger btn-circle btn-lg\">\r\n                            <i class=\"fas fa-trash\"></i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n                \r\n                <div class=\"card shadow mb-4\">\r\n                    <div class=\"card-header py-3\">\r\n                        <h6 class=\"m-0 font-weight-bold text-primary\">Brand Buttons</h6>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <p>Google and Facebook buttons are available featuring each company\'s respective brand color. They are used on the user login and registration pages.</p>\r\n                        <p>You can create more custom buttons by adding a new color variable in the <code>_variables.scss</code> file and then using the Bootstrap button variant mixin to create a new style, as demonstrated in the <code>_buttons.scss</code> file.</p>\r\n                        <a href=\"#\" class=\"btn btn-google btn-block\"><i class=\"fab fa-google fa-fw\"></i> .btn-google</a>\r\n                        <a href=\"#\" class=\"btn btn-facebook btn-block\"><i class=\"fab fa-facebook-f fa-fw\"></i> .btn-facebook</a>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"col-lg-6\">\r\n\r\n                <div class=\"card shadow mb-4\">\r\n                    <div class=\"card-header py-3\">\r\n                        <h6 class=\"m-0 font-weight-bold text-primary\">Split Buttons with Icon</h6>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <p>Works with any button colors, just use the <code>.btn-icon-split</code> class and the markup in the examples below. The examples below also use the <code>.text-white-50</code> helper class on the icons for additional styling, but it is not required.</p>\r\n                        <a href=\"#\" class=\"btn btn-primary btn-icon-split\">\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-flag\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Primary</span>\r\n                        </a>\r\n                        <div class=\"my-2\"></div>\r\n                        <a href=\"#\" class=\"btn btn-success btn-icon-split\">\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-check\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Success</span>\r\n                        </a>\r\n                        <div class=\"my-2\"></div>\r\n                        <a href=\"#\" class=\"btn btn-info btn-icon-split\">\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-info-circle\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Info</span>\r\n                        </a>\r\n                        <div class=\"my-2\"></div>\r\n                        <a href=\"#\" class=\"btn btn-warning btn-icon-split\">\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-exclamation-triangle\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Warning</span>\r\n                        </a>\r\n                        <div class=\"my-2\"></div>\r\n                        <a href=\"#\" class=\"btn btn-danger btn-icon-split\">\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-trash\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Danger</span>\r\n                        </a>\r\n                        <div class=\"my-2\"></div>\r\n                        <a href=\"#\" class=\"btn btn-secondary btn-icon-split\">\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-arrow-right\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Secondary</span>\r\n                        </a>\r\n                        <div class=\"my-2\"></div>\r\n                        <a href=\"#\" class=\"btn btn-light btn-icon-split\">\r\n                            <span class=\"icon text-gray-600\">\r\n                                <i class=\"fas fa-arrow-right\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Primary</span>\r\n                        </a>\r\n                        <div class=\"mb-4\"></div>\r\n                        <p>Also works with small and large button classes!</p>\r\n                        <a href=\"#\" class=\"btn btn-primary btn-icon-split btn-sm\">\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-flag\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Small</span>\r\n                        </a>\r\n                        <div class=\"my-2\"></div>\r\n                        <a href=\"#\" class=\"btn btn-primary btn-icon-split btn-lg\">\r\n                            <span class=\"icon text-white-50\">\r\n                                <i class=\"fas fa-flag\"></i>\r\n                            </span>\r\n                            <span class=\"text\">Split Button Large</span>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizacaoController LocalizacaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosController EstadosC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComprasController ComprasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoComprasController CComprasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FabricoController FBCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoFabricoController CFC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClassificacaoProdutosController CPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UnidadesController UC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BancosController VB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EncomendasController EC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController CC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MoldesController MoldesController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FornecedoresController FC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoProdutoController TPRC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoPecaController TPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModelosController MC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProdutosController PC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoController CabecalhoEncomendasC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoProdutosController CAPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ColaboradoresController colaboradoresController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoModeloController CMC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
