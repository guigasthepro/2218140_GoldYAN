#pragma checksum "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Shared\SidebarNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eebab8eba1fea91e76b182f14763d0ee7b85e902"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    public partial class SidebarNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "navbar-nav bg-gradient-primary sidebar sidebar-dark accordion ");
            __builder.AddAttribute(2, "id", "accordionSidebar");
            __builder.AddMarkupContent(3, "\r\n    \r\n    ");
            __builder.AddMarkupContent(4, @"<a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""/"">
        <div class=""sidebar-brand-icon rotate-n-15"">
        </div>
        <div class=""sidebar-brand-text mr-4 ""><img src=""img/Logo.png"" width=""140""></div>
    </a>

    
    
    
    
    
    <hr class=""sidebar-divider"">

    
    ");
            __builder.AddMarkupContent(5, "<div class=\"sidebar-heading\">\r\n        Interface\r\n    </div>\r\n    \r\n    ");
            __builder.AddMarkupContent(6, @"<li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseClientes"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-fw fa-cog""></i>
            <span>Clientes</span>
        </a>
        <div id=""collapseClientes"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""cfichacliente"">Criar ficha de clientes</a>
                <a class=""collapse-item"" href=""vclientes"">Ver fichas de clientes</a>
            </div>
        </div>
    </li>
    
    ");
            __builder.AddMarkupContent(7, @"<li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseEncomendas"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-fw fa-cog""></i>
            <span>Encomendas</span>
        </a>
        <div id=""collapseEncomendas"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""cencomenda"">Criar encomenda</a>
                <a class=""collapse-item"" href=""vencomendas"">Ver encomendas</a>
            </div>
        </div>
    </li>

    ");
            __builder.AddMarkupContent(8, @"<li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseOficina"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-fw fa-cog""></i>
            <span>Oficina</span>
        </a>
        <div id=""collapseOficina"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""oficina"">Gestão de encomendas</a>
            </div>
        </div>
    </li>

    
    ");
            __builder.AddMarkupContent(9, @"<li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseFornecedores"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-fw fa-cog""></i>
            <span>Fornecedores</span>
        </a>
        <div id=""collapseFornecedores"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""cfornecedores"">Criar Fornecedor</a>
                <a class=""collapse-item"" href=""vfornecedores"">Ver Fornecedores</a>
            </div>
        </div>
    </li>
    
    ");
            __builder.AddMarkupContent(10, @"<li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseCompras"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-fw fa-cog""></i>
            <span>Compras</span>
        </a>
        <div id=""collapseCompras"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""icompra"">Inserir compra</a>
                <a class=""collapse-item"" href=""vcompras"">Ver compras</a>
            </div>
        </div>
    </li>
    
    ");
            __builder.AddMarkupContent(11, @"<li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseProdutos"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-fw fa-cog""></i>
            <span>Produtos</span>
        </a>
        <div id=""collapseProdutos"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""cprodutos"">Criar produto</a>
                <a class=""collapse-item"" href=""vprodutos"">Ver produtos</a>
            </div>
        </div>
    </li>
    
    ");
            __builder.AddMarkupContent(12, @"<li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseModelos"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-fw fa-cog""></i>
            <span>Modelos</span>
        </a>
        <div id=""collapseModelos"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""cmodelo"">Criar modelos</a>
                <a class=""collapse-item"" href=""vmodelo"">Ver modelos</a>
            </div>
        </div>
    </li>
    
    ");
            __builder.AddMarkupContent(13, @"<li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseMoldes"" aria-expanded=""true"" aria-controls=""collapseTwo"">
            <i class=""fas fa-fw fa-cog""></i>
            <span>Moldes</span>
        </a>
        <div id=""collapseMoldes"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""cmoldes"">Criar molde</a>
                <a class=""collapse-item"" href=""vmoldes"">Ver moldes</a>
            </div>
        </div>
    </li>




      
    <hr class=""sidebar-divider"">
      
    ");
            __builder.AddMarkupContent(14, "<div class=\"sidebar-heading\">\r\n        Administração\r\n    </div>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(15);
            __builder.AddAttribute(16, "Roles", "Admin");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n        \r\n        ");
                __builder2.AddMarkupContent(19, @"<li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseAdmin"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Administração</span>
            </a>
            <div id=""collapseAdmin"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <a class=""collapse-item"" href=""utilizadores"">Colaboradores</a>
                    <a class=""collapse-item"" href=""bancos"">Tabela Bancos</a>
                    <a class=""collapse-item"" href=""classificacaoprodutos"">Tabela Class Produtos</a>
                    <a class=""collapse-item"" href=""codigopostal"">Tabela Codigo Postal</a>
                    <a class=""collapse-item"" href=""familiaprodutos"">Tabela Familia Produtos</a>
                    <a class=""collapse-item"" href=""materiais"">Tabela Matérias</a>
                    <a class=""collapse-item"" href=""profissoes"">Tabela Profissões</a>
                    <a class=""collapse-item"" href=""unidades"">Tabela Unidades</a>
                    <a class=""collapse-item"" href=""servicos"">Tabela Serviços</a>
                </div>
            </div>
        </li>
    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
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
