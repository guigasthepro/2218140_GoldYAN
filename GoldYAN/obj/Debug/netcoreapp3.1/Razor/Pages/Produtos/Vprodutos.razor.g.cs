#pragma checksum "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e683a3a4b117f5809f9f13ba811ec55e5a6e7b1"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Produtos
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/vprodutos")]
    public partial class Vprodutos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card shadow mb-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Lista de Produtos</h6>\r\n        </div>\r\n        ");
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
            __builder.AddMarkupContent(43, "<div class=\"col-sm-12 col-md-6\"><div id=\"dataTable_filter\" class=\"dataTables_filter\"><label>Search:<input type=\"search\" class=\"form-control form-control-sm\" placeholder aria-controls=\"dataTable\"></label></div></div>");
            __builder.CloseElement();
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-sm-12");
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "table");
            __builder.AddAttribute(51, "class", "table table-bordered table-hover table-sm dataTable");
            __builder.AddAttribute(52, "id", "dataTable");
            __builder.AddAttribute(53, "width", "100%");
            __builder.AddAttribute(54, "cellspacing", "0");
            __builder.AddAttribute(55, "role", "grid");
            __builder.AddAttribute(56, "aria-describedby", "dataTable_info");
            __builder.AddAttribute(57, "style", "width: 100%;");
            __builder.AddMarkupContent(58, "\r\n                                ");
            __builder.AddMarkupContent(59, @"<thead>
                                    <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"" style=""width: 101px;"">IdProduto</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 170px;"">IDTipoDePeça</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Office: activate to sort column ascending"" style=""width: 71px;"">IDTipoDeProduto</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Age: activate to sort column ascending"" style=""width: 31px;"">Descrição</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Start date: activate to sort column ascending"" style=""width: 68px;"">Apontamentos</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 67px;"">Ações</th></tr>
                                </thead>
                                ");
            __builder.AddMarkupContent(60, @"<tfoot>
                                    <tr><th rowspan=""1"" colspan=""1"">IdProduto</th><th rowspan=""1"" colspan=""1"">IDTipoDePeca</th><th rowspan=""1"" colspan=""1"">IDTipoDeProduto</th><th rowspan=""1"" colspan=""1"">Descrição</th><th rowspan=""1"" colspan=""1"">Apontamentos</th><th rowspan=""1"" colspan=""1"">Ações</th></tr>
                                </tfoot>
                                ");
            __builder.OpenElement(61, "tbody");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 23 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                     foreach (var produtos in listaCabecalhoProdutos)
                                    {
                                        if (!IsVisible(produtos))
                                            continue;

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                                    ");
            __builder.OpenElement(64, "tr");
            __builder.AddAttribute(65, "ondblclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                     () => OpenFichaProduto(produtos.idproduto)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "style", "height: 1em;");
            __builder.AddMarkupContent(67, "\r\n                                        ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "class", "sorting_1");
            __builder.AddAttribute(70, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(71, "title", 
#nullable restore
#line 28 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                                       produtos.idproduto

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(72, 
#nullable restore
#line 28 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                                                            produtos.idproduto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                        ");
            __builder.OpenElement(74, "td");
            __builder.AddAttribute(75, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(76, "title", 
#nullable restore
#line 29 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                     produtos.idtipodepeca

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, 
#nullable restore
#line 29 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                                             produtos.idtipodepeca

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                        ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(81, "title", 
#nullable restore
#line 30 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                     produtos.idtipodeproduto

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(82, 
#nullable restore
#line 30 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                                                produtos.idtipodeproduto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                        ");
            __builder.OpenElement(84, "td");
            __builder.AddAttribute(85, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(86, "title", 
#nullable restore
#line 31 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                     produtos.descricao

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(87, 
#nullable restore
#line 31 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                                          produtos.descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                                        ");
            __builder.OpenElement(89, "td");
            __builder.AddAttribute(90, "style", " overflow: hidden; white-space: nowrap; ");
            __builder.AddAttribute(91, "title", 
#nullable restore
#line 32 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                     produtos.apontamentos

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, 
#nullable restore
#line 32 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                                                                             produtos.apontamentos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                                        ");
            __builder.OpenElement(94, "td");
            __builder.AddAttribute(95, "align", "center");
            __builder.AddMarkupContent(96, "\r\n                                            ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "dropdown no-arrow");
            __builder.AddMarkupContent(99, "\r\n                                                ");
            __builder.AddMarkupContent(100, @"<a class=""btn dropdown-toggle btn-sm"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                    <i class=""fas fa-cog fa-sm fa-fw text-gray-400""></i>
                                                </a>
                                                ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "dropdown-menu dropdown-menu-right shadow animated--fade-in");
            __builder.AddAttribute(103, "aria-labelledby", "dropdownMenuLink");
            __builder.AddMarkupContent(104, "\r\n                                                    ");
            __builder.AddMarkupContent(105, "<div class=\"dropdown-header\">Ações:</div>\r\n                                                    ");
            __builder.OpenElement(106, "li");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                  () => OpenFichaProduto(produtos.idproduto)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "class", "dropdown-item");
            __builder.AddAttribute(109, "style", "list-style:none");
            __builder.AddMarkupContent(110, "<a class=\"btn btn-sm btn-warning\" href=\"#\"><i class=\"fas fa-trash\"></i>Editar</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                                    ");
            __builder.OpenElement(112, "li");
            __builder.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                                                  () => Apagar(produtos.idproduto)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "class", "dropdown-item");
            __builder.AddAttribute(115, "style", "list-style:none");
            __builder.AddMarkupContent(116, "<a class=\"btn btn-sm btn-danger\" href=\"#\"><i class=\"fas fa-trash\"></i> Apagar</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 46 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, @"<div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""dataTable_info"" role=""status"" aria-live=""polite"">Showing 1 to 10 of 57 entries</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""dataTable_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""dataTable_previous""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">Previous</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""dataTable_next""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">Next</a></li></ul></div></div></div>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Produtos\Vprodutos.razor"
           
        Data.CabecalhoProdutos CCP = new CabecalhoProdutos();
        Data.Servicos servicos = new Servicos();
        Data.Produtos produtos = new Produtos();
        Data.CabecalhosModelos cm = new CabecalhosModelos();
        Data.Colaboradores cl = new Colaboradores();
        Data.TipoDePeca dtdp = new TipoDePeca();
        Data.TipoProduto dtp = new TipoProduto();
        Data.Produtos cp = new Produtos();
        Data.Fornecedores fornecedores = new Data.Fornecedores();
        Data.ClassificacaoProdutos ecp = new Data.ClassificacaoProdutos();
        Data.Unidades unidade = new Data.Unidades();


        List<Unidades> listaUnidades = new List<Unidades>();
        List<ClassificacaoProdutos> listaClassificacaoProdutos = new List<ClassificacaoProdutos>();
        List<Fornecedores> listaFornecedores = new List<Fornecedores>();
        List<Servicos> ListaServicos = new List<Servicos>();
        List<TipoDePeca> listaTipoDePecas = new List<TipoDePeca>();
        List<TipoProduto> listaTipoProdutos = new List<TipoProduto>();
        List<CabecalhoProdutos> listaCabecalhoProdutos = new List<CabecalhoProdutos>();
        List<Data.Produtos> listaProdutos = new List<Produtos>();
        List<CabecalhosModelos> listacabecalhoModeloControllers = new List<CabecalhosModelos>();
        List<Colaboradores> colaboradores = new List<Colaboradores>();

        //For input values
        List<Data.Produtos> LCP = new List<Produtos>();

        bool FichaModelo = false;

        bool showModal = false;
        bool Readonly = true;
        bool ReadonlyCabecalho = true;
        int i;
        string formadepesquisa;
        public string Filter { get; set; }


        protected override async Task OnInitializedAsync()
        {
            listaCabecalhoProdutos = CAPC.GetAll();

        }

        public bool IsVisible(CabecalhoProdutos produtos)
        {
            if (string.IsNullOrEmpty(Filter))
                return true;

            if (produtos.idproduto.Equals(Filter) || produtos.descricao.ToString().Contains(Filter) || produtos.apontamentos.ToString().Contains(Filter))
                return true;

            return false;
        }

        public void OpenFichaProduto(int id)
        {
            //cm = CMC.Get(id);
            dtp = TPRC.Get(cm.idtipoproduto.Value);
            dtdp = TPC.Get(cm.idtipodepeca.Value);
            //listaModelos = MC.GetAllQuery(id);
            showModal = true;
        }
        void ModalShow()
        {
            showModal = true;
        }
        void ModalCancel()
        {
            showModal = false;
        }


        public async Task LoadData(int linha)
        {

            //m = listaProdutos[linha - 1];

            //js.InvokeVoidAsync("console.log", $"{m}");


            //if (m.idmolde.HasValue)
            //{
            //    mlds = MoldesController.Get(m.idmolde.Value);

            //}
            //else if (m.idservico.HasValue)
            //{
            //    servicos = SC.Get(m.idservico.Value);
            //}
            //else if (m.idproduto != 0)
            //{
            //    //mlds = .Get(m.idmolde.Value);
            //}
            //cl = colaboradoresController.Get(m.idcolaborador);

        }

        public async Task Apagar(int id)
        {
            //bool confirmation;

            //confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

            //if (confirmation)
            //{
            //    string message = CMC.Delete(id);
            //    message += MC.Delete(id);
            //    OnInitializedAsync();
            //    Task.Delay(1000);
            //    {
            //        await js.InvokeVoidAsync("alert", @message);
            //    }
            //}
        }

        public async Task Update()
        {

            //CMC.Put(cm.idmodelo, cm);
            //foreach (var modelos in listaModelos)
            //{
            //}
            //showModal = false;
        }

        private async Task<IEnumerable<TipoDePeca>> ProcurarPecas(string searchText)
        {
            return await Task.FromResult(listaTipoDePecas.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower()) || h.idpeca.ToString().Contains(searchText.ToLower())).ToList());
        }

        private async Task<IEnumerable<Servicos>> ProcurarServicos(string searchText)
        {
            return await Task.FromResult(ListaServicos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
        }

        private async Task<IEnumerable<TipoProduto>> ProcurarProdutos(string searchText)
        {
            return await Task.FromResult(listaTipoProdutos.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
        }

        private async Task<IEnumerable<Colaboradores>> ProcurarColaboradores(string searchText)
        {
            return await Task.FromResult(colaboradores.Where(h => h.codigo.ToLower().Contains(searchText.ToLower()) || h.descricao.ToLower().Contains(searchText.ToLower())).ToList());
        }

    

#line default
#line hidden
#nullable disable
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
