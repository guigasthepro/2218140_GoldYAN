#pragma checksum "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "688dbdaf1becb827842a4570193fe643627ec7ee"
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
#line 12 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

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
#line 2 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
using GoldYAN.Data;

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
#line 10 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                          cfornecedor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                       CriarFornecedor

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n\r\n\r\n\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "m-3 form-group");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-inline");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.AddMarkupContent(20, "<label for=\"Descricao\">Codigo Fornecedor:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "id", "Descricao");
                __builder2.AddAttribute(23, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "placeholder", "Ainda não selecionado");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                                                     cfornecedor.codigo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.codigo = __value, cfornecedor.codigo))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.codigo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "m-3 form-group");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-inline");
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.AddMarkupContent(38, "<label for=\"Quantidade\">Nome Fornecedor:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "Quantidade");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "placeholder", "Quantidade");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                           cfornecedor.nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.nome = __value, cfornecedor.nome))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "m-3 form-group");
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-inline");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.AddMarkupContent(55, "<label for=\"peso\">Contacto:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "id", "peso");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "placeholder", "Peso");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                               cfornecedor.contacto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.contacto = __value, cfornecedor.contacto))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.contacto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "m-3 form-group");
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-inline");
                __builder2.AddMarkupContent(71, "\r\n                    ");
                __builder2.AddMarkupContent(72, "<label for=\"preco\">Nif:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(73);
                __builder2.AddAttribute(74, "id", "preco");
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "placeholder", "Preço do serviço");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                            cfornecedor.nif

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.nif = __value, cfornecedor.nif))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.nif));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "m-3 form-group");
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-inline");
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.AddMarkupContent(89, "<label for=\"apontamentos\">Morada:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(90);
                __builder2.AddAttribute(91, "id", "apontamentos");
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "placeholder", "Apontamentos para o serviço");
                __builder2.AddAttribute(94, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                                                                                                             cfornecedor.morada

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.morada = __value, cfornecedor.morada))));
                __builder2.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.morada));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n\r\n            ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "m-3 form-group");
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-inline");
                __builder2.AddMarkupContent(106, "\r\n                    ");
                __builder2.AddMarkupContent(107, "<label for=\"datadeentrega\">Localização:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(108);
                __builder2.AddAttribute(109, "id", "datadeentrega");
                __builder2.AddAttribute(110, "class", "form-control");
                __builder2.AddAttribute(111, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                     cfornecedor.localizaçao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.localizaçao = __value, cfornecedor.localizaçao))));
                __builder2.AddAttribute(113, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.localizaçao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\r\n            ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "m-3 form-group");
                __builder2.AddMarkupContent(119, "\r\n                ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-inline");
                __builder2.AddMarkupContent(122, "\r\n                    ");
                __builder2.AddMarkupContent(123, "<label for=\"datadeentrega\">Código Postal:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(124);
                __builder2.AddAttribute(125, "id", "datadeentrega");
                __builder2.AddAttribute(126, "class", "form-control");
                __builder2.AddAttribute(127, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                     cfornecedor.codigopostal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.codigopostal = __value, cfornecedor.codigopostal))));
                __builder2.AddAttribute(129, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.codigopostal));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n\r\n            ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "m-3 form-group");
                __builder2.AddMarkupContent(135, "\r\n                ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-inline");
                __builder2.AddMarkupContent(138, "\r\n                    ");
                __builder2.AddMarkupContent(139, "<label for=\"datadeentrega\">Telefone:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(140);
                __builder2.AddAttribute(141, "id", "datadeentrega");
                __builder2.AddAttribute(142, "class", "form-control");
                __builder2.AddAttribute(143, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                     cfornecedor.telefone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(144, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.telefone = __value, cfornecedor.telefone))));
                __builder2.AddAttribute(145, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.telefone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(146, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n\r\n            ");
                __builder2.OpenElement(149, "div");
                __builder2.AddAttribute(150, "class", "m-3 form-group");
                __builder2.AddMarkupContent(151, "\r\n                ");
                __builder2.OpenElement(152, "div");
                __builder2.AddAttribute(153, "class", "form-inline");
                __builder2.AddMarkupContent(154, "\r\n                    ");
                __builder2.AddMarkupContent(155, "<label for=\"datadeentrega\">Telemovel:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(156);
                __builder2.AddAttribute(157, "id", "datadeentrega");
                __builder2.AddAttribute(158, "class", "form-control");
                __builder2.AddAttribute(159, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                     cfornecedor.telemovel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(160, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.telemovel = __value, cfornecedor.telemovel))));
                __builder2.AddAttribute(161, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.telemovel));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(162, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n\r\n            ");
                __builder2.OpenElement(165, "div");
                __builder2.AddAttribute(166, "class", "m-3 form-group");
                __builder2.AddMarkupContent(167, "\r\n                ");
                __builder2.OpenElement(168, "div");
                __builder2.AddAttribute(169, "class", "form-inline");
                __builder2.AddMarkupContent(170, "\r\n                    ");
                __builder2.AddMarkupContent(171, "<label for=\"datadeentrega\">Nome Vendedor:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(172);
                __builder2.AddAttribute(173, "id", "datadeentrega");
                __builder2.AddAttribute(174, "class", "form-control");
                __builder2.AddAttribute(175, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                     cfornecedor.nomevendedor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(176, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.nomevendedor = __value, cfornecedor.nomevendedor))));
                __builder2.AddAttribute(177, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.nomevendedor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(178, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\r\n\r\n            ");
                __builder2.OpenElement(181, "div");
                __builder2.AddAttribute(182, "class", "m-3 form-group");
                __builder2.AddMarkupContent(183, "\r\n                ");
                __builder2.OpenElement(184, "div");
                __builder2.AddAttribute(185, "class", "form-inline");
                __builder2.AddMarkupContent(186, "\r\n                    ");
                __builder2.AddMarkupContent(187, "<label for=\"datadeentrega\">Telemovel Vendedor:</label> &nbsp\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(188);
                __builder2.AddAttribute(189, "id", "datadeentrega");
                __builder2.AddAttribute(190, "class", "form-control");
                __builder2.AddAttribute(191, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 94 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
                                                                                     cfornecedor.telemovelvendedor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(192, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cfornecedor.telemovelvendedor = __value, cfornecedor.telemovelvendedor))));
                __builder2.AddAttribute(193, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cfornecedor.telemovelvendedor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(194, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(196, "\r\n\r\n            ");
                __builder2.AddMarkupContent(197, "<div class=\"m-3 form-group\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Adicionar</button>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(198, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\GuilhermeSimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Fornecedores\Cfornecedores.razor"
       

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
