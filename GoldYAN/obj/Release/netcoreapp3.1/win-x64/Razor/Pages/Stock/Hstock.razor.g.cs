#pragma checksum "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "430c8104676f645c4d66c4e3c49cbb56133699ba"
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
#line 1 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
           [Authorize(Roles = "Admin, Dev, Contabilidade")]

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
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-sm-12 col-md-6");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "dataTables_length");
            __builder.AddAttribute(25, "id", "dataTable_length");
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.AddMarkupContent(27, "<label>Pesquisar Produto:</label>\r\n\r\n                                ");
            __Blazor.GoldYAN.Pages.Stock.Hstock.TypeInference.CreateBlazoredTypeahead_0(__builder, 28, 29, 
#nullable restore
#line 21 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                 ProcurarProdutos

#line default
#line hidden
#nullable disable
            , 30, 
#nullable restore
#line 21 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
            , 31, 
#nullable restore
#line 21 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                       true

#line default
#line hidden
#nullable disable
            , 32, "this.value = this.value.toUpperCase()", 33, "Pesquisar Produto", 34, 
#nullable restore
#line 21 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                                                                                          produtos

#line default
#line hidden
#nullable disable
            , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produtos = __value, produtos)), 36, () => produtos, 37, (context) => (__builder2) => {
                __builder2.AddMarkupContent(38, "\r\n                                        ");
                __builder2.AddContent(39, 
#nullable restore
#line 23 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                         context.idproduto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(40, " + ");
                __builder2.AddContent(41, 
#nullable restore
#line 23 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                              context.descricao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, "\r\n                                    ");
            }
            , 43, (context) => (__builder2) => {
                __builder2.AddContent(44, 
#nullable restore
#line 25 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                     context.idproduto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(45, " + ");
                __builder2.AddContent(46, 
#nullable restore
#line 25 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                          context.descricao

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.AddMarkupContent(47, "\r\n                                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group mt-2");
            __builder.AddMarkupContent(50, "\r\n                                    ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(53, "style", "display:inline;");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                           LoadStock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "<i class=\"fas fa-search\"></i>Procurar");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-sm-12");
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "table");
            __builder.AddAttribute(68, "class", "table table-bordered table-hover table-sm dataTable");
            __builder.AddAttribute(69, "id", "dataTable");
            __builder.AddAttribute(70, "width", "100%");
            __builder.AddAttribute(71, "cellspacing", "0");
            __builder.AddAttribute(72, "role", "grid");
            __builder.AddAttribute(73, "aria-describedby", "dataTable_info");
            __builder.AddAttribute(74, "style", "width: 100%;");
            __builder.AddMarkupContent(75, "\r\n                                ");
            __builder.AddMarkupContent(76, @"<thead>
                                    <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"" style=""width: 101px;"">Tipo de Movimento</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 170px;"">Data</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Office: activate to sort column ascending"" style=""width: 71px;"">Documento</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Age: activate to sort column ascending"" style=""width: 31px;"">Produto</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Start date: activate to sort column ascending"" style=""width: 68px;"">Quantidade</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 170px;"">Referencia Saida</th></tr>
                                </thead>
                                ");
            __builder.AddMarkupContent(77, @"<tfoot>
                                    <tr><th rowspan=""1"" colspan=""1"">Tipo de Movimento</th><th rowspan=""1"" colspan=""1"">Data</th><th rowspan=""1"" colspan=""1"">Documento</th><th rowspan=""1"" colspan=""1"">Produto</th><th rowspan=""1"" colspan=""1"">Quantidade</th><th rowspan=""1"" colspan=""1"">Referencia Saida</th></tr>
                                </tfoot>
                                ");
            __builder.OpenElement(78, "tbody");
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 43 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                     foreach (var stock in vhStock)
                                    {

                                        var desc = listaCabecalhoProduto.Where(h => h.idproduto.Equals(stock.idprodutoalterado)).ToList();


#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                                        ");
            __builder.OpenElement(81, "tr");
            __builder.AddAttribute(82, "style", "height: 1em;");
            __builder.AddMarkupContent(83, "\r\n                                            ");
            __builder.OpenElement(84, "td");
            __builder.AddAttribute(85, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(86, "title", 
#nullable restore
#line 49 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                         stock.tipo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(87, 
#nullable restore
#line 49 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                      stock.tipo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                                            ");
            __builder.OpenElement(89, "td");
            __builder.AddAttribute(90, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(91, "title", 
#nullable restore
#line 50 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                         stock.datacriacao

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, 
#nullable restore
#line 50 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                             stock.datacriacao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                                            ");
            __builder.OpenElement(94, "td");
            __builder.AddAttribute(95, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(96, "title", (
#nullable restore
#line 51 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                         stock.idcomponente

#line default
#line hidden
#nullable disable
            ) + "-" + (
#nullable restore
#line 51 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                             stock.tipocomponente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(97, 
#nullable restore
#line 51 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                                                    stock.idcomponente

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(98, "-");
            __builder.AddContent(99, 
#nullable restore
#line 51 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                                                                        stock.tipocomponente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                                            ");
            __builder.OpenElement(101, "td");
            __builder.AddAttribute(102, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(103, "title", (
#nullable restore
#line 52 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                         stock.idprodutoalterado

#line default
#line hidden
#nullable disable
            ) + "-" + (
#nullable restore
#line 52 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                                  desc[0].descricao

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(104, 
#nullable restore
#line 52 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                                                      stock.idprodutoalterado

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(105, "-");
            __builder.AddContent(106, 
#nullable restore
#line 52 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                                                                               desc[0].descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                                            ");
            __builder.OpenElement(108, "td");
            __builder.AddAttribute(109, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(110, "title", 
#nullable restore
#line 53 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                         stock.stockadicionado

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(111, 
#nullable restore
#line 53 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                                 Math.Round(stock.stockadicionado,3)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                                            ");
            __builder.OpenElement(113, "td");
            __builder.AddAttribute(114, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(115, "title", 
#nullable restore
#line 54 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                         stock.referenciasaida

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(116, 
#nullable restore
#line 54 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                                                                                 stock.referenciasaida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 57 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"


                                        AdicionarStock(stock.stockadicionado, stock.tipo);
                                        CheckStock();

                                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(119, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                            ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "float-right form-group row mt-3");
            __builder.AddMarkupContent(124, "\r\n                                ");
            __builder.AddMarkupContent(125, "<label class=\"col-form-label\">Entrada:</label>  &nbsp;\r\n                                ");
            __builder.OpenElement(126, "input");
            __builder.AddAttribute(127, "class", "form-control w-25");
            __builder.AddAttribute(128, "value", 
#nullable restore
#line 68 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                         Math.Round(Entrada)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n\r\n                                ");
            __builder.AddMarkupContent(130, "<label class=\"col-form-label\">Saida:</label>  &nbsp;\r\n                                ");
            __builder.OpenElement(131, "input");
            __builder.AddAttribute(132, "class", "form-control w-25");
            __builder.AddAttribute(133, "value", 
#nullable restore
#line 71 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                         Math.Round(Saida,3)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n\r\n                                ");
            __builder.AddMarkupContent(135, "<label class=\"col-form-label\">Stock:</label> &nbsp;\r\n                                ");
            __builder.OpenElement(136, "input");
            __builder.AddAttribute(137, "class", "form-control w-25");
            __builder.AddAttribute(138, "value", 
#nullable restore
#line 74 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
                                                                         Math.Round(Stock,3)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Stock\Hstock.razor"
       

    List<CabecalhoProdutos> listaCabecalhoProduto = new List<CabecalhoProdutos>();
    Data.CabecalhoProdutos produtos = new CabecalhoProdutos();
    Data.CabecalhoProdutos cprodutos = new CabecalhoProdutos();

    List<HistoricoStock> vhStock = new List<HistoricoStock>();
    public string Filter { get; set; }
    public double Entrada { get; set; }
    public double Saida { get; set; }
    public double Stock { get; set; }



    protected override async Task OnInitializedAsync()
    {
        listaCabecalhoProduto = CAPC.GetAll();

    }


    public async Task CheckStock()
    {
        Stock = Entrada - Saida;
    }

    public async Task AdicionarStock(double stock, string tipo)
    {

        if (tipo == "Entrada")
        {
            Entrada += stock;
        }
        else
        {
            Saida += stock;
        }
    }

    public async Task LoadStock()
    {
        if (produtos.idproduto != null)
        {
            Stock = new double();
            Entrada = new double();
            Saida = new double();
            vhStock = hStockC.GetAllProdutoQuery(produtos.idproduto);
        }
        else
        {
            js.InvokeVoidAsync("alert", "Seleciona primeiro um produto");
        }
    }

    private async Task<IEnumerable<CabecalhoProdutos>> ProcurarProdutos(string searchText)
    {
        return await Task.FromResult(listaCabecalhoProduto.Where(h => h.descricao.ToLower().Contains(searchText.ToLower()) || h.idproduto.Equals(searchText.ToLower())).ToList());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipodeCompraController TCC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HistoricoStockController hStockC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizacaoController LocalizacaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AspNetUsersController aspController { get; set; }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProfissoesController ProfissaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MateriasController MateriasC { get; set; }
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
namespace __Blazor.GoldYAN.Pages.Stock.Hstock
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazoredTypeahead_0<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment<TValue> __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg9)
        {
        __builder.OpenComponent<global::Blazored.Typeahead.BlazoredTypeahead<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "DisableClear", __arg1);
        __builder.AddAttribute(__seq2, "EnableDropDown", __arg2);
        __builder.AddAttribute(__seq3, "oninput", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.AddAttribute(__seq8, "SelectedTemplate", __arg8);
        __builder.AddAttribute(__seq9, "ResultTemplate", __arg9);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
