#pragma checksum "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e98de4d68fe14dc08a51b299208b12a24f8ac4"
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
#line 1 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-xl-3 col-md-6 mb-4");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card border-left-primary shadow h-100 py-2");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row no-gutters align-items-center");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col mr-2");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.AddMarkupContent(21, "<div class=\"text-xs font-weight-bold text-primary text-uppercase mb-1\">Fichas de Clientes Criadas (Hoje)</div>\r\n                            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "h5 mb-0 font-weight-bold text-gray-800");
            __builder.AddContent(24, 
#nullable restore
#line 15 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Index.razor"
                                                                                 infoClientesList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.AddMarkupContent(27, "<div class=\"col-auto\">\r\n                            <i class=\"fas fa-calendar fa-2x text-gray-300\"></i>\r\n                        </div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(32, @"<div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">Encomendas Criadas (Hoje)</div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800""></div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        
        ");
            __builder.AddMarkupContent(33, @"<div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Encomendas Completadas (Hoje)</div>
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col-auto"">
                                    <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">50%</div>
                                </div>
                                <div class=""col"">
                                    <div class=""progress progress-sm mr-2"">
                                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        
        ");
            __builder.AddMarkupContent(34, @"<div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Encomendas a espera</div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-comments fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    \r\n\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.AddMarkupContent(38, "\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(39, "<div class=\"col-xl-8 col-lg-7\">\r\n            <div class=\"card shadow mb-4\">\r\n                \r\n                <div class=\"card-header py-3 d-flex flex-row align-items-center justify-content-between\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Encomendas prontas</h6>\r\n                    <div class=\"dropdown no-arrow\">\r\n                        <a class=\"dropdown-toggle\" href=\"#\" role=\"button\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                            <i class=\"fas fa-ellipsis-v fa-sm fa-fw text-gray-400\"></i>\r\n                        </a>\r\n                        <div class=\"dropdown-menu dropdown-menu-right shadow animated--fade-in\" aria-labelledby=\"dropdownMenuLink\">\r\n                            <div class=\"dropdown-header\">Dropdown Header:</div>\r\n                            <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                            <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                            <div class=\"dropdown-divider\"></div>\r\n                            <a class=\"dropdown-item\" href=\"#\">Something else here</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                \r\n                <div class=\"card-body\">\r\n                    <div class=\"chart-area\">\r\n                        <div class=\"chartjs-size-monitor\"><div class=\"chartjs-size-monitor-expand\"><div class></div></div><div class=\"chartjs-size-monitor-shrink\"><div class></div></div></div>\r\n                        <canvas id=\"myAreaChart\" width=\"620\" height=\"320\" class=\"chartjs-render-monitor\" style=\"display: block; width: 620px; height: 320px;\"></canvas>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(40, "<div class=\"col-xl-4 col-lg-5\">\r\n            <div class=\"card shadow mb-4\">\r\n                \r\n                <div class=\"card-header py-3 d-flex flex-row align-items-center justify-content-between\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Revenue Sources</h6>\r\n                    <div class=\"dropdown no-arrow\">\r\n                        <a class=\"dropdown-toggle\" href=\"#\" role=\"button\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                            <i class=\"fas fa-ellipsis-v fa-sm fa-fw text-gray-400\"></i>\r\n                        </a>\r\n                        <div class=\"dropdown-menu dropdown-menu-right shadow animated--fade-in\" aria-labelledby=\"dropdownMenuLink\">\r\n                            <div class=\"dropdown-header\">Dropdown Header:</div>\r\n                            <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                            <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                            <div class=\"dropdown-divider\"></div>\r\n                            <a class=\"dropdown-item\" href=\"#\">Something else here</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                \r\n                <div class=\"card-body\">\r\n                    <div class=\"chart-pie pt-4 pb-2\">\r\n                        <div class=\"chartjs-size-monitor\"><div class=\"chartjs-size-monitor-expand\"><div class></div></div><div class=\"chartjs-size-monitor-shrink\"><div class></div></div></div>\r\n                        <canvas id=\"myPieChart\" width=\"620\" height=\"245\" class=\"chartjs-render-monitor\" style=\"display: block; width: 620px; height: 245px;\"></canvas>\r\n                    </div>\r\n                    <div class=\"mt-4 text-center small\">\r\n                        <span class=\"mr-2\">\r\n                            <i class=\"fas fa-circle text-primary\"></i> Direct\r\n                        </span>\r\n                        <span class=\"mr-2\">\r\n                            <i class=\"fas fa-circle text-success\"></i> Social\r\n                        </span>\r\n                        <span class=\"mr-2\">\r\n                            <i class=\"fas fa-circle text-info\"></i> Referral\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-xl-3 col-md-6 mb-4");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card border-left-primary shadow h-100 py-2");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "card-body");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "row no-gutters align-items-center");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col mr-2");
            __builder.AddMarkupContent(55, "\r\n                            ");
            __builder.AddMarkupContent(56, "<div class=\"text-xs font-weight-bold text-primary text-uppercase mb-1\">Fichas de Clientes Criadas (Hoje)</div>\r\n                            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "h5 mb-0 font-weight-bold text-gray-800");
            __builder.AddContent(59, 
#nullable restore
#line 166 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Index.razor"
                                                                                 infoClientesList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.AddMarkupContent(62, "<div class=\"col-auto\">\r\n                            <i class=\"fas fa-calendar fa-2x text-gray-300\"></i>\r\n                        </div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(67, @"<div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">Encomendas Criadas (Hoje)</div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800""></div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        
        ");
            __builder.AddMarkupContent(68, @"<div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Encomendas Completadas (Hoje)</div>
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col-auto"">
                                    <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">50%</div>
                                </div>
                                <div class=""col"">
                                    <div class=""progress progress-sm mr-2"">
                                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        
        ");
            __builder.AddMarkupContent(69, @"<div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Encomendas a espera</div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-comments fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 242 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Index.razor"
       List<Data.Clientes> infoClientesList = new List<Data.Clientes>();

    protected override async Task OnInitializedAsync()
    {
        infoClientesList = CC.InfoCliente(DateTime.Now.ToShortDateString());
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipodeCompraController TCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HistoricoStockController hStockC { get; set; }
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
