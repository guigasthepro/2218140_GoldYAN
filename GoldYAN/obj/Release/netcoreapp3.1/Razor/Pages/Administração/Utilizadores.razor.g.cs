#pragma checksum "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1700103eddcd78f8d31a07607b0712a039e2708"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Administração
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
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
           [Authorize(Roles = "Admin , Dev")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Utilizadores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n\r\n\r\n    \r\n    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card shadow mb-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, @"<div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"" style=""display:inline;"">Listagem de Utilizadores</h6> <form style=""display:inline;"" action=""/Identity/Account/register""><input style=""display:inline;"" class=""btn btn-success btn-sm float-right"" type=""submit"" value=""Novo User""> </form>
        </div>
        ");
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
            __builder.AddMarkupContent(17, @"<div class=""row""><div class=""col-sm-12 col-md-6""></div><div class=""col-sm-12 col-md-6""><div id=""dataTable_filter"" class=""dataTables_filter""><label>Procurar:<input type=""search"" class=""form-control form-control-sm"" placeholder aria-controls=""dataTable""></label></div></div></div>");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "overflow: auto;");
            __builder.AddAttribute(23, "class", "col-sm-12");
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table table-bordered table-sm dataTable");
            __builder.AddAttribute(27, "id", "dataTable");
            __builder.AddAttribute(28, "width", "100%");
            __builder.AddAttribute(29, "cellspacing", "0");
            __builder.AddAttribute(30, "role", "grid");
            __builder.AddAttribute(31, "aria-describedby", "dataTable_info");
            __builder.AddAttribute(32, "style", "width: 100%;");
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.AddMarkupContent(34, @"<thead>
                                    <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"" style=""width: 101px;"">UserID</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 170px;"">Email</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Office: activate to sort column ascending"" style=""width: 71px;"">Email Normalizado</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Contacto: activate to sort column ascending"" style=""width: 31px;"">User Name</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Start date: activate to sort column ascending"" style=""width: 68px;"">Nome Normalizado</th><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"" style=""width: 101px;"">Numero Telefone</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 140px;"">Ações</th></tr>
                                </thead>
                                ");
            __builder.AddMarkupContent(35, @"<tfoot>
                                    <tr><th rowspan=""1"" colspan=""1"">UserID</th><th rowspan=""1"" colspan=""1"">Email</th><th rowspan=""1"" colspan=""1"">Email Normalizado</th><th rowspan=""1"" colspan=""1"">User Name</th><th rowspan=""1"" colspan=""1"">Nome Normalizado</th><th rowspan=""1"" colspan=""1"">Telemovel</th><th rowspan=""1"" colspan=""1"">Ações</th></tr>
                                </tfoot>
                                ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 30 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                     foreach (var users in listasp)
                                    {

                                        if (!IsVisible(users))
                                            continue;



#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                                        ");
            __builder.OpenElement(39, "tr");
            __builder.AddAttribute(40, "role", "row");
            __builder.AddAttribute(41, "class", "odd");
            __builder.AddAttribute(42, "id", 
#nullable restore
#line 37 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                                                        users.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n                                            ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 38 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                                 users.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                            ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 39 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                                 users.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                            ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 40 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                                 users.NormalizedEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                            ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 41 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                                 users.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                            ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 42 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                                 users.NormalizedUserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                            ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 43 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                                 users.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                            ");
            __builder.OpenElement(62, "td");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                                                                                () => ApagarUser(users.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "style", "margin-left:0.3rem");
            __builder.AddMarkupContent(67, "<i class=\"fas fa-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 46 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor"
       

    List<Data.aspnetusers> listasp = new List<Data.aspnetusers>();
    Data.aspnetusers eusers = new Data.aspnetusers();
    Data.aspnetusers cusers = new Data.aspnetusers();
    bool showModal = false;
    bool showModal2 = false;


    protected override async Task OnInitializedAsync()
    {
        listasp = aspController.GetAll();
    }

    public string Filter { get; set; }

    public bool IsVisible(Data.aspnetusers users)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (users.Id.ToString().Contains(Filter) || users.Email.ToString().Contains(Filter) || users.NormalizedUserName.ToString().Contains(Filter))
            return true;

        return false;
    }

    public async Task ApagarUser(string id)
    {
        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            aspController.Delete(id);
            OnInitializedAsync();
            Task.Delay(1000);

        }
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
#pragma warning restore 1591
