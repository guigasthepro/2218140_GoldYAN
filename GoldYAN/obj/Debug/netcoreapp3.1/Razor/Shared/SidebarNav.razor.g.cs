#pragma checksum "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Shared\SidebarNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bfa58fab11724297e3f678d0f6a8cd19bb0317b"
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
    public partial class SidebarNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "navbar-nav bg-gradient-primary sidebar sidebar-dark accordion ");
            __builder.AddAttribute(2, "id", "accordionSidebar");
            __builder.AddMarkupContent(3, "\r\n        \r\n        ");
            __builder.AddMarkupContent(4, @"<a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""/"">
            <div class=""sidebar-brand-icon rotate-n-15"">
            </div>
            <div class=""sidebar-brand-text mx-3""><img src=""/Logo.png"" width=""140""></div>
        </a>

        
        <hr class=""sidebar-divider my-0"">

        
        ");
            __builder.AddMarkupContent(5, @"<li class=""nav-item active"">
            <a class=""nav-link"" href=""index.html"">
                <i class=""fas fa-fw fa-tachometer-alt""></i>
                <span>Pagina Inicial</span>
            </a>
        </li>

        
        <hr class=""sidebar-divider"">

        
        ");
            __builder.AddMarkupContent(6, "<div class=\"sidebar-heading\">\r\n            Interface\r\n        </div>\r\n        \r\n        ");
            __builder.AddMarkupContent(7, @"<li class=""nav-item"">
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
            __builder.AddMarkupContent(8, @"<li class=""nav-item"">
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
                    <a class=""collapse-item"" href=""vmodelos"">Ver modelos</a>
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
");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(14);
            __builder.AddAttribute(15, "Roles", "Admin");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n    \r\n        ");
                __builder2.AddMarkupContent(18, @"<li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseAdmin"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Administração</span>
            </a>
            <div id=""collapseAdmin"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <a class=""collapse-item"" href=""buttons"">Colaboradores</a>
                    <a class=""collapse-item"" href=""buttons"">Tabela Bancos</a>
                    <a class=""collapse-item"" href=""buttons"">Tabela Class Produtos</a>
                    <a class=""collapse-item"" href=""buttons"">Tabela Codigo Postal</a>
                    <a class=""collapse-item"" href=""buttons"">Tabela Familia Produtos</a>
                    <a class=""collapse-item"" href=""buttons"">Tabela Materiais</a>
                    <a class=""collapse-item"" href=""buttons"">Tabela Profissões</a>
                    <a class=""collapse-item"" href=""buttons"">Tabela Unidades</a>
                    <a class=""collapse-item"" href=""buttons"">Tabela Utilizadores</a>
                </div>
            </div>
        </li>
");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n\r\n\r\n\r\n        \r\n        <hr class=\"sidebar-divider\">\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(20, "<div class=\"sidebar-heading\">\r\n            Tutorial\r\n        </div>\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(21, @"<li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Components</span>
            </a>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Custom Components:</h6>
                    <a class=""collapse-item"" href=""buttons"">Buttons</a>
                    <a class=""collapse-item"" href=""cards"">Cards</a>
                </div>
            </div>
        </li>
        
        ");
            __builder.AddMarkupContent(22, @"<li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities"" aria-expanded=""true"" aria-controls=""collapseUtilities"">
                <i class=""fas fa-fw fa-wrench""></i>
                <span>Utilities</span>
            </a>
            <div id=""collapseUtilities"" class=""collapse"" aria-labelledby=""headingUtilities"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Custom Utilities:</h6>
                    <a class=""collapse-item"" href=""utilities-colour"">Colors</a>
                    <a class=""collapse-item"" href=""utilities-border"">Borders</a>
                    <a class=""collapse-item"" href=""utilities-animation"">Animations</a>
                    <a class=""collapse-item"" href=""utilities-other"">Other</a>
                </div>
            </div>
        </li>

        
        <hr class=""sidebar-divider"">

        
        ");
            __builder.AddMarkupContent(23, "<div class=\"sidebar-heading\">\r\n            Addons\r\n        </div>\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(24, @"<li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""true"" aria-controls=""collapsePages"">
                <i class=""fas fa-fw fa-folder""></i>
                <span>Pages</span>
            </a>
            <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Login Screens:</h6>
                    <a class=""collapse-item"" href=""login.html"">Login</a>
                    <a class=""collapse-item"" href=""register.html"">Register</a>
                    <a class=""collapse-item"" href=""forgot-password.html"">Forgot Password</a>
                    <div class=""collapse-divider""></div>
                    <h6 class=""collapse-header"">Other Pages:</h6>
                    <a class=""collapse-item"" href=""404.html"">404 Page</a>
                    <a class=""collapse-item"" href=""blank.html"">Blank Page</a>
                </div>
            </div>
        </li>

        
        ");
            __builder.AddMarkupContent(25, "<li class=\"nav-item\">\r\n            <a class=\"nav-link\" href=\"charts\">\r\n                <i class=\"fas fa-fw fa-chart-area\"></i>\r\n                <span>Charts</span>\r\n            </a>\r\n        </li>\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(26, "<li class=\"nav-item\">\r\n            <a class=\"nav-link\" href=\"tables\">\r\n                <i class=\"fas fa-fw fa-table\"></i>\r\n                <span>Tables</span>\r\n            </a>\r\n        </li>\r\n\r\n        \r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
