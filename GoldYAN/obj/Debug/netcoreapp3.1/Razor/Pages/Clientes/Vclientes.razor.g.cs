#pragma checksum "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a0423213a0ff6bf0395e747257a2376ce0dbe80"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Clientes
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
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vclientes")]
    public partial class Vclientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card shadow mb-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Listagem de Clientes</h6>\r\n        </div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "table-responsive-sm");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "dataTable_wrapper");
            __builder.AddAttribute(15, "class", "dataTables_wrapper dt-bootstrap4");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "dataTables_length");
            __builder.AddAttribute(23, "id", "dataTable_length");
            __builder.OpenElement(24, "label");
            __builder.AddContent(25, "Show ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "name", "dataTable_length");
            __builder.AddAttribute(28, "aria-controls", "dataTable");
            __builder.AddAttribute(29, "class", "custom-select custom-select-sm form-control form-control-sm");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "10");
            __builder.AddContent(32, "10");
            __builder.CloseElement();
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "25");
            __builder.AddContent(35, "25");
            __builder.CloseElement();
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "50");
            __builder.AddContent(38, "50");
            __builder.CloseElement();
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "100");
            __builder.AddContent(41, "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(42, " entries");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "id", "dataTable_filter");
            __builder.AddAttribute(47, "class", "dataTables_filter");
            __builder.OpenElement(48, "label");
            __builder.AddContent(49, "Pesquisar Encomenda:");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "search");
            __builder.AddAttribute(52, "class", "form-control form-control-sm");
            __builder.AddAttribute(53, "placeholder", "");
            __builder.AddAttribute(54, "aria-controls", "dataTable");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filter = __value, Filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row");
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-sm-12");
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "table");
            __builder.AddAttribute(64, "class", "table table-bordered table-hover table-sm dataTable");
            __builder.AddAttribute(65, "id", "dataTable");
            __builder.AddAttribute(66, "width", "100%");
            __builder.AddAttribute(67, "cellspacing", "0");
            __builder.AddAttribute(68, "role", "grid");
            __builder.AddAttribute(69, "aria-describedby", "dataTable_info");
            __builder.AddAttribute(70, "style", "width: 100%;");
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.AddMarkupContent(72, @"<thead>
                                    <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" style=""width: 20px;"">Nome do Cliente</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 60px;"">Email</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Office: activate to sort column ascending"" style=""width: 160px;"">Telefone</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Age: activate to sort column ascending"" style=""width: 20px;"">Morada</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Start date: activate to sort column ascending"" style=""width: 45px;"">Nif</th></tr>
                                </thead>
                                ");
            __builder.AddMarkupContent(73, @"<tfoot>
                                    <tr><th rowspan=""1"" colspan=""1"">Nome do Cliente</th><th rowspan=""1"" colspan=""1"">Email</th><th rowspan=""1"" colspan=""1"">Telefone</th><th rowspan=""1"" colspan=""1"">Morada</th><th rowspan=""1"" colspan=""1"">NIF</th></tr>
                                </tfoot>
                                ");
            __builder.OpenElement(74, "tbody");
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 27 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                     foreach (var cliente in VCS)
                                    {
                                        if (!IsVisible(cliente))
                                            continue;

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                                        ");
            __builder.OpenElement(77, "tr");
            __builder.AddAttribute(78, "style", "height: 1em;");
            __builder.AddMarkupContent(79, "\r\n                                            ");
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "class", "sorting_1");
            __builder.AddAttribute(82, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(83, "title", (
#nullable restore
#line 32 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                                           cliente.Nome

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.AddContent(84, 
#nullable restore
#line 32 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                                                           cliente.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                            ");
            __builder.OpenElement(86, "td");
            __builder.AddAttribute(87, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(88, "title", 
#nullable restore
#line 33 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                         cliente.Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(89, 
#nullable restore
#line 33 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                                         cliente.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                            ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(93, "title", 
#nullable restore
#line 34 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                         cliente.Telefone

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, 
#nullable restore
#line 34 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                                            cliente.Telefone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                            ");
            __builder.OpenElement(96, "td");
            __builder.AddAttribute(97, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(98, "title", 
#nullable restore
#line 35 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                         cliente.Morada

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(99, 
#nullable restore
#line 35 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                                          cliente.Morada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                                            ");
            __builder.OpenElement(101, "td");
            __builder.AddAttribute(102, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(103, "title", 
#nullable restore
#line 36 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                         cliente.Nif

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(104, 
#nullable restore
#line 36 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                                                                                                       cliente.Nif

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 38 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, @"<div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""dataTable_info"" role=""status"" aria-live=""polite"">Showing 1 to 10 of 57 entries</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""dataTable_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""dataTable_previous""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">Previous</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""dataTable_next""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">Next</a></li></ul></div></div></div>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Vclientes.razor"
       


    List<Clientes> VCS = new List<Clientes>();
    public string Filter { get; set; }

    public string pesquisa { get; set; }

    protected override async Task OnInitializedAsync()
    {
        VCS = VC.Get();
        StateHasChanged();

    }

    public async Task Pesquisar(string valor)
    {
        VCS = VC.PesquisarClientes(valor);
    }

    public bool IsVisible(Clientes cliente)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (cliente.Nome.Contains(Filter) || cliente.Email.ToString().Contains(Filter) || cliente.Telefone.ToString().Contains(Filter) || cliente.Nif.ToString().Contains(Filter))

            return true;

        return false;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController VC { get; set; }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ColaboradoresController colaboradoresController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoModeloController CMC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
