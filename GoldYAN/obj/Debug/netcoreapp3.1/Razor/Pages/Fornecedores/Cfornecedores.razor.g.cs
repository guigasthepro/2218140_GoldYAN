#pragma checksum "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2bf521b66b58f63c4d22b5a3b65d667256e1fe"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Fornecedores
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
#line 2 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cfornecedores")]
    public partial class Cfornecedores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card shadow mb-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Formulario Encomenda</h6>\r\n        </div>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                          cfornecedor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                       CriarFornecedor

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "m-3 form-group");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-inline");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.AddMarkupContent(20, "<label for=\"Descricao\">Codigo Fornecedor:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "autocomplete", "false");
                __builder2.AddAttribute(23, "id", "Descricao");
                __builder2.AddAttribute(24, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "placeholder", "Codigo do fornecedor");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                                                                        cfornecedor.codigo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.codigo = __value, cfornecedor.codigo))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.codigo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "m-3 form-group");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-inline");
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.AddMarkupContent(39, "<label for=\"Quantidade\">Nome Fornecedor:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "autocomplete", "false");
                __builder2.AddAttribute(42, "id", "Quantidade");
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "placeholder", "Nome do fornecedor");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                       cfornecedor.nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.nome = __value, cfornecedor.nome))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n            ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "m-3 form-group");
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-inline");
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.AddMarkupContent(57, "<label for=\"peso\">Contacto:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "autocomplete", "false");
                __builder2.AddAttribute(60, "id", "peso");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "placeholder", "Contacto do fornecedor");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                     cfornecedor.contacto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.contacto = __value, cfornecedor.contacto))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.contacto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "m-3 form-group");
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-inline");
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.AddMarkupContent(75, "<label for=\"preco\">Nif:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "autocomplete", "false");
                __builder2.AddAttribute(78, "id", "preco");
                __builder2.AddAttribute(79, "class", "form-control");
                __builder2.AddAttribute(80, "placeholder", "Nif do Fornecedor");
                __builder2.AddAttribute(81, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                 cfornecedor.nif

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.nif = __value, cfornecedor.nif))));
                __builder2.AddAttribute(83, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.nif));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n            ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "m-3 form-group");
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "form-inline");
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.AddMarkupContent(93, "<label for=\"apontamentos\">Morada:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(94);
                __builder2.AddAttribute(95, "autocomplete", "false");
                __builder2.AddAttribute(96, "id", "apontamentos");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "placeholder", "Morada Fornecedor");
                __builder2.AddAttribute(99, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                                                                        cfornecedor.morada

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.morada = __value, cfornecedor.morada))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.morada));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n            ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "m-3 form-group");
                __builder2.AddMarkupContent(108, "\r\n                ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-inline");
                __builder2.AddMarkupContent(111, "\r\n                    ");
                __builder2.AddMarkupContent(112, "<label for=\"datadeentrega\">Localização:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(113);
                __builder2.AddAttribute(114, "autocomplete", "false");
                __builder2.AddAttribute(115, "id", "datadeentrega");
                __builder2.AddAttribute(116, "placeholder", "Localização Fornecedor");
                __builder2.AddAttribute(117, "class", "form-control");
                __builder2.AddAttribute(118, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                              cfornecedor.localizaçao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.localizaçao = __value, cfornecedor.localizaçao))));
                __builder2.AddAttribute(120, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.localizaçao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n\r\n            ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "m-3 form-group");
                __builder2.AddMarkupContent(126, "\r\n                ");
                __builder2.OpenElement(127, "div");
                __builder2.AddAttribute(128, "class", "form-inline");
                __builder2.AddMarkupContent(129, "\r\n                    ");
                __builder2.AddMarkupContent(130, "<label for=\"datadeentrega\">Código Postal:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(131);
                __builder2.AddAttribute(132, "autocomplete", "false");
                __builder2.AddAttribute(133, "id", "datadeentrega");
                __builder2.AddAttribute(134, "placeholder", "Codigo Postal Fornecedor");
                __builder2.AddAttribute(135, "class", "form-control");
                __builder2.AddAttribute(136, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                                cfornecedor.codigopostal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.codigopostal = __value, cfornecedor.codigopostal))));
                __builder2.AddAttribute(138, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.codigopostal));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(139, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n\r\n            ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "m-3 form-group");
                __builder2.AddMarkupContent(144, "\r\n                ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "form-inline");
                __builder2.AddMarkupContent(147, "\r\n                    ");
                __builder2.AddMarkupContent(148, "<label for=\"datadeentrega\">Telefone:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(149);
                __builder2.AddAttribute(150, "autocomplete", "false");
                __builder2.AddAttribute(151, "id", "datadeentrega");
                __builder2.AddAttribute(152, "placeholder", "Telefone Fornecedor");
                __builder2.AddAttribute(153, "class", "form-control");
                __builder2.AddAttribute(154, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                           cfornecedor.telefone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(155, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.telefone = __value, cfornecedor.telefone))));
                __builder2.AddAttribute(156, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.telefone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(157, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n\r\n            ");
                __builder2.OpenElement(160, "div");
                __builder2.AddAttribute(161, "class", "m-3 form-group");
                __builder2.AddMarkupContent(162, "\r\n                ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "form-inline");
                __builder2.AddMarkupContent(165, "\r\n                    ");
                __builder2.AddMarkupContent(166, "<label for=\"datadeentrega\">Telemovel:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(167);
                __builder2.AddAttribute(168, "autocomplete", "false");
                __builder2.AddAttribute(169, "id", "datadeentrega");
                __builder2.AddAttribute(170, "placeholder", "Telemovel Fornecedor");
                __builder2.AddAttribute(171, "class", "form-control");
                __builder2.AddAttribute(172, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                            cfornecedor.telemovel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(173, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.telemovel = __value, cfornecedor.telemovel))));
                __builder2.AddAttribute(174, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.telemovel));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(175, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(177, "\r\n\r\n            ");
                __builder2.OpenElement(178, "div");
                __builder2.AddAttribute(179, "class", "m-3 form-group");
                __builder2.AddMarkupContent(180, "\r\n                ");
                __builder2.OpenElement(181, "div");
                __builder2.AddAttribute(182, "class", "form-inline");
                __builder2.AddMarkupContent(183, "\r\n                    ");
                __builder2.AddMarkupContent(184, "<label for=\"datadeentrega\">Nome Vendedor:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(185);
                __builder2.AddAttribute(186, "autocomplete", "false");
                __builder2.AddAttribute(187, "id", "datadeentrega");
                __builder2.AddAttribute(188, "class", "form-control");
                __builder2.AddAttribute(189, "placeholder", "Nome do Vendedor");
                __builder2.AddAttribute(190, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                        cfornecedor.nomevendedor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(191, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.nomevendedor = __value, cfornecedor.nomevendedor))));
                __builder2.AddAttribute(192, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.nomevendedor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(193, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(194, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\r\n\r\n            ");
                __builder2.OpenElement(196, "div");
                __builder2.AddAttribute(197, "class", "m-3 form-group");
                __builder2.AddMarkupContent(198, "\r\n                ");
                __builder2.OpenElement(199, "div");
                __builder2.AddAttribute(200, "class", "form-inline");
                __builder2.AddMarkupContent(201, "\r\n                    ");
                __builder2.AddMarkupContent(202, "<label for=\"datadeentrega\">Telemovel Vendedor:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(203);
                __builder2.AddAttribute(204, "autocomplete", "false");
                __builder2.AddAttribute(205, "id", "datadeentrega");
                __builder2.AddAttribute(206, "placeholder", "Telefone do vendedor");
                __builder2.AddAttribute(207, "class", "form-control");
                __builder2.AddAttribute(208, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                            cfornecedor.telemovelvendedor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(209, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.telemovelvendedor = __value, cfornecedor.telemovelvendedor))));
                __builder2.AddAttribute(210, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.telemovelvendedor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(211, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(212, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(213, "\r\n\r\n            ");
                __builder2.AddMarkupContent(214, "<div class=\"m-3 form-group\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Adicionar</button>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(215, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
       

    Fornecedores cfornecedor = new Fornecedores();

    private async Task InsertFichaCliente()
    {
        // await JsRuntime.InvokeVoidAsync("setElementTextById", "resultJson", JsonSerializer.Serialize(cFichaCliente));
    }

    public async Task CriarFornecedor()
    {
        var resultado = FC.Post(cfornecedor);
        if (resultado != null)
        {
            await js.InvokeVoidAsync("alert", "Fornecedor Criado Com Sucesso");
            cfornecedor = new Fornecedores();

        }
        else
        {
            await js.InvokeVoidAsync("alert", "Impossivél adicionar o serviço, por favor verifique os campos!");

        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
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
