#pragma checksum "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5a19c327af8313e5592b685b38ca309fb3fd2d6"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Moldes
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
#line 2 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vmoldes")]
    public partial class Vmoldes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"card-header py-3\">\r\n        <h6 class=\"m-0 font-weight-bold text-primary\">Informação do molde</h6>\r\n    </div>\r\n    \r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", true);
            __builder.AddMarkupContent(6, "\r\n        \r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-xl-3 col-md-6 mb-4");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card border-left-primary shadow h-100 py-2");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row no-gutters align-items-center");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col mr-2");
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.AddMarkupContent(22, "<div class=\"text-xs font-weight-bold text-primary text-uppercase mb-1\">Descrição do molde</div>\r\n                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "h5 mb-0 font-weight-bold text-gray-800");
            __builder.AddContent(25, 
#nullable restore
#line 21 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                                 DescricaoProduto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.AddMarkupContent(28, "<div class=\"col-auto\">\r\n                            <i class=\"fas fa-calendar fa-2x text-gray-300\"></i>\r\n                        </div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    \r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n<br>\r\n<br>\r\n\r\n\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "container-fluid");
            __builder.AddMarkupContent(37, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "card shadow mb-4");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<div class=\"card-header py-3\">\r\n                <h6 class=\"m-0 font-weight-bold text-primary\">Listagem de Moldes</h6>\r\n            </div>\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card-body");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "table-responsive");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "id", "dataTable_wrapper");
            __builder.AddAttribute(50, "class", "dataTables_wrapper dt-bootstrap4");
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "row");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "dataTables_length");
            __builder.AddAttribute(58, "id", "dataTable_length");
            __builder.OpenElement(59, "label");
            __builder.AddContent(60, "Show ");
            __builder.OpenElement(61, "select");
            __builder.AddAttribute(62, "name", "dataTable_length");
            __builder.AddAttribute(63, "aria-controls", "dataTable");
            __builder.AddAttribute(64, "class", "custom-select custom-select-sm form-control form-control-sm");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", "10");
            __builder.AddContent(67, "10");
            __builder.CloseElement();
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "25");
            __builder.AddContent(70, "25");
            __builder.CloseElement();
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", "50");
            __builder.AddContent(73, "50");
            __builder.CloseElement();
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "100");
            __builder.AddContent(76, "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(77, " entries");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "<div class=\"col-sm-12 col-md-6\"><div id=\"dataTable_filter\" class=\"dataTables_filter\"><label>Search:<input type=\"search\" class=\"form-control form-control-sm\" placeholder aria-controls=\"dataTable\"></label></div></div>");
            __builder.CloseElement();
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "row");
            __builder.AddMarkupContent(81, "\r\n                            ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col-sm-12");
            __builder.AddMarkupContent(84, "\r\n                                ");
            __builder.OpenElement(85, "table");
            __builder.AddAttribute(86, "class", "table table-bordered dataTable");
            __builder.AddAttribute(87, "id", "dataTable");
            __builder.AddAttribute(88, "width", "100%");
            __builder.AddAttribute(89, "cellspacing", "0");
            __builder.AddAttribute(90, "role", "grid");
            __builder.AddAttribute(91, "aria-describedby", "dataTable_info");
            __builder.AddAttribute(92, "style", "width: 100%;");
            __builder.AddMarkupContent(93, "\r\n                                    ");
            __builder.AddMarkupContent(94, @"<thead>
                                        <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"" style=""width: 101px;"">IdMolde</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 170px;"">Descrição</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Office: activate to sort column ascending"" style=""width: 71px;"">Gaveta</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 67px;"">Ações</th></tr>
                                    </thead>
                                    ");
            __builder.AddMarkupContent(95, @"<tfoot>
                                        <tr><th rowspan=""1"" colspan=""1"">IdMoldes</th><th rowspan=""1"" colspan=""1"">Descrição</th><th rowspan=""1"" colspan=""1"">Gaveta</th><th rowspan=""1"" colspan=""1"">Ações</th></tr>
                                    </tfoot>
                                    ");
            __builder.OpenElement(96, "tbody");
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 60 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                         foreach (var molde in @VMS)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                                            ");
            __builder.OpenElement(99, "tr");
            __builder.AddAttribute(100, "role", "row");
            __builder.AddAttribute(101, "class", "odd");
            __builder.AddAttribute(102, "id", 
#nullable restore
#line 62 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                            molde.idmolde

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                                                     () => DescricaoProduto = molde.descricao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(104, "\r\n                                                ");
            __builder.OpenElement(105, "td");
            __builder.AddContent(106, 
#nullable restore
#line 63 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                     molde.codigo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                                                ");
            __builder.OpenElement(108, "td");
            __builder.AddContent(109, 
#nullable restore
#line 64 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                     molde.descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                                                ");
            __builder.OpenElement(111, "td");
            __builder.AddContent(112, 
#nullable restore
#line 65 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                     molde.gaveta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                                                ");
            __builder.AddMarkupContent(114, "<td><button class=\"btn btn-primary\" style=\"margin-left:1rem\">Editar</button><button class=\"btn btn-danger\" style=\"margin-left:0.3rem\">Apagar</button></td>\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 68 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "<div class=\"row\"><div class=\"col-sm-12 col-md-5\"><div class=\"dataTables_info\" id=\"dataTable_info\" role=\"status\" aria-live=\"polite\">Showing 1 to 10 of 57 entries</div></div><div class=\"col-sm-12 col-md-7\"><div class=\"dataTables_paginate paging_simple_numbers\" id=\"dataTable_paginate\"><ul class=\"pagination\"><li class=\"paginate_button page-item previous disabled\" id=\"dataTable_previous\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a></li><li class=\"paginate_button page-item active\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"1\" tabindex=\"0\" class=\"page-link\">1</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"2\" tabindex=\"0\" class=\"page-link\">2</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"3\" tabindex=\"0\" class=\"page-link\">3</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"4\" tabindex=\"0\" class=\"page-link\">4</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"5\" tabindex=\"0\" class=\"page-link\">5</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"6\" tabindex=\"0\" class=\"page-link\">6</a></li><li class=\"paginate_button page-item next\" id=\"dataTable_next\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"7\" tabindex=\"0\" class=\"page-link\">Next</a></li></ul></div></div></div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
       

    string DescricaoProduto;

    List<Moldes> VMS = new List<Moldes>();

    protected override async Task OnInitializedAsync()
        {
            VMS = VM.Get();

        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MoldesController VM { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
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
