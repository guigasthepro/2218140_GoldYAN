#pragma checksum "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa157b04a1cbb506f2d5d9c794bdd2bc02c1baea"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Stock
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hstock")]
    public partial class Hstock : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(6, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Movimento de Stock</h6>\r\n        </div>\r\n        ");
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
            __builder.AddContent(49, "Pesquisar Movimento:");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "search");
            __builder.AddAttribute(52, "class", "form-control form-control-sm");
            __builder.AddAttribute(53, "placeholder", "");
            __builder.AddAttribute(54, "aria-controls", "dataTable");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
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
            __builder.AddMarkupContent(72, "<thead>\r\n                                <tr role=\"row\"><th class=\"sorting_asc\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-sort=\"ascending\" aria-label=\"Name: activate to sort column descending\" style=\"width: 101px;\">Tipo de Componente</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Position: activate to sort column ascending\" style=\"width: 170px;\">IDComponente</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Office: activate to sort column ascending\" style=\"width: 71px;\">IDProdutoAlterado</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Age: activate to sort column ascending\" style=\"width: 31px;\">Tipo</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Start date: activate to sort column ascending\" style=\"width: 68px;\">Stock Inicial</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Position: activate to sort column ascending\" style=\"width: 170px;\">Quantidade adicionada</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 67px;\">Stock Final</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Position: activate to sort column ascending\" style=\"width: 170px;\">Data da Compra</th></tr>\r\n                                </thead>\r\n                                ");
            __builder.AddMarkupContent(73, @"<tfoot>
                                <tr><th rowspan=""1"" colspan=""1"">Tipo de Componente</th><th rowspan=""1"" colspan=""1"">IDComponente</th><th rowspan=""1"" colspan=""1"">Produto Alterado</th><th rowspan=""1"" colspan=""1"">Tipo</th><th rowspan=""1"" colspan=""1"">Stock Inicial</th><th rowspan=""1"" colspan=""1"">Quantidade adicionada</th><th rowspan=""1"" colspan=""1"">Stock Final</th><th rowspan=""1"" colspan=""1"">Data da Compra</th></tr>
                                </tfoot>
                                ");
            __builder.OpenElement(74, "tbody");
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 26 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                 foreach (var stock in vhStock)
                                {
                                    if (!IsVisible(stock))
                                    continue;

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                                    ");
            __builder.OpenElement(77, "tr");
            __builder.AddAttribute(78, "style", "height: 1em;");
            __builder.AddMarkupContent(79, "\r\n                                        ");
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(82, "title", 
#nullable restore
#line 31 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                     stock.tipocomponente

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(83, 
#nullable restore
#line 31 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                            stock.tipocomponente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                        ");
            __builder.OpenElement(85, "td");
            __builder.AddAttribute(86, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(87, "title", 
#nullable restore
#line 32 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                     stock.idcomponente

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(88, 
#nullable restore
#line 32 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                          stock.idcomponente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                        ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(92, "title", 
#nullable restore
#line 33 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                     stock.idprodutoalterado

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(93, 
#nullable restore
#line 33 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                               stock.idprodutoalterado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                                        ");
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(97, "title", 
#nullable restore
#line 34 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                     stock.tipo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(98, 
#nullable restore
#line 34 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                  stock.tipo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                        ");
            __builder.OpenElement(100, "td");
            __builder.AddAttribute(101, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(102, "title", 
#nullable restore
#line 35 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                     stock.stockinicial

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(103, 
#nullable restore
#line 35 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                          stock.stockinicial

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                        ");
            __builder.OpenElement(105, "td");
            __builder.AddAttribute(106, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(107, "title", 
#nullable restore
#line 36 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                     stock.stockadicionado

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(108, 
#nullable restore
#line 36 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                             stock.stockadicionado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                                        ");
            __builder.OpenElement(110, "td");
            __builder.AddAttribute(111, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(112, "title", 
#nullable restore
#line 37 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                     stock.stockfinal

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(113, 
#nullable restore
#line 37 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                        Math.Round(stock.stockfinal.Value, 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                                        ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(117, "title", 
#nullable restore
#line 38 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                     stock.stockinicial

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(118, 
#nullable restore
#line 38 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                          stock.datacriacao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 41 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"

                                    CheckStock();

                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(121, "                                \r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                            ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "float-right");
            __builder.AddMarkupContent(126, "\r\n                                ");
            __builder.AddMarkupContent(127, "<label class>Entrada</label>\r\n                                ");
            __builder.OpenElement(128, "input");
            __builder.AddAttribute(129, "class", true);
            __builder.AddAttribute(130, "value", 
#nullable restore
#line 50 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                        Entrada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n\r\n                                ");
            __builder.AddMarkupContent(132, "<label class>Saida</label>\r\n                                ");
            __builder.OpenElement(133, "input");
            __builder.AddAttribute(134, "class", true);
            __builder.AddAttribute(135, "value", 
#nullable restore
#line 53 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                        Saida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n\r\n                                ");
            __builder.AddMarkupContent(137, "<label class>Stock</label>\r\n                                ");
            __builder.OpenElement(138, "input");
            __builder.AddAttribute(139, "class", true);
            __builder.AddAttribute(140, "value", 
#nullable restore
#line 56 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                        Stock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
       

    List<HistoricoStock> vhStock = new List<HistoricoStock>();
    public string Filter { get; set; }
    public double Entrada { get; set; }
    public double Saida { get; set; }
    public double Stock { get; set; }



    protected override async Task OnInitializedAsync()
    {
        vhStock = hStockC.GetAll();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Stock = Entrada - Saida;
        }
    }

    public async Task CheckStock()
    {
        Stock = Entrada - Saida;
    }

    public async Task AdicionarStock(double stock, string tipo)
    {
        if (tipo == "Entrada")
        {
            Entrada += stock ;
        }
        else
        {
            Saida += stock;
        }
    }

    public bool IsVisible(HistoricoStock hstock)
    {

        if (string.IsNullOrEmpty(Filter))
        {
            Entrada = new double();
            Saida = new double();
            Stock = new double();
            return false;
        }

        if (hstock.id.Equals(Filter) || hstock.idprodutoalterado.ToString().Contains(Filter) || hstock.tipo.ToString().Contains(Filter))
        {
            AdicionarStock(hstock.stockadicionado, hstock.tipo);
            return true;
        }
        else
        {

        }

        return false;

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
