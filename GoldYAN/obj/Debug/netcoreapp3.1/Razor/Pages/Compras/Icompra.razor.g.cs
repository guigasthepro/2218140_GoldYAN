#pragma checksum "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00e90a31e27ef6b5991636fb09364cb67fd66148"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Compras
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
#nullable restore
#line 10 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/icompra")]
    public partial class Icompra : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(6, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Cabeçalho Compra</h6>\r\n        </div>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                          cFichaCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                         InsertFichaCliente

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(14, "<label for=\"nome\">Fornecedor</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "nome");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                   cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Nome = __value, cFichaCliente.Nome))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 17 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      () => cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(25, "<label for=\"telefone\">Numero</label>\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateInputNumber_1(__builder2, 26, 27, "telefone", 28, "form-control", 29, 
#nullable restore
#line 21 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                         cFichaCliente.Telefone

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Telefone = __value, cFichaCliente.Telefone)), 31, () => cFichaCliente.Telefone);
                __builder2.AddMarkupContent(32, "\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateValidationMessage_2(__builder2, 33, 34, 
#nullable restore
#line 22 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      () => cFichaCliente.Telefone

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(36, "<label for=\"morada\">Pagamento</label>\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateInputSelect_3(__builder2, 37, 38, 
#nullable restore
#line 26 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      cFichaCliente

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente = __value, cFichaCliente)), 40, () => cFichaCliente, 41, (__builder3) => {
                    __builder3.AddMarkupContent(42, "\r\n                ");
                    __builder3.AddMarkupContent(43, "<option>Pronto Pagamento</option>\r\n                ");
                    __builder3.AddMarkupContent(44, "<option>Pagamento 15 dias</option>\r\n                ");
                    __builder3.AddMarkupContent(45, "<option>Pagamento 30 dias</option>\r\n                ");
                    __builder3.AddMarkupContent(46, "<option>Pagamento 60 dias</option>\r\n                ");
                    __builder3.AddMarkupContent(47, "<option>Pagamento 90 dias</option>\r\n                ");
                    __builder3.AddMarkupContent(48, "<option>Parcial 30+60</option>\r\n            ");
                }
                );
                __builder2.AddMarkupContent(49, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(50, "<label for=\"moradaopcional\">Data</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "id", "moradaopcional");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                             cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Nome = __value, cFichaCliente.Nome))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(58, "<label for=\"codigopostal\">Vencimento</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "id", "codigopostal");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                           cFichaCliente.Codigopostal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Codigopostal = __value, cFichaCliente.Codigopostal))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Codigopostal));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateValidationMessage_4(__builder2, 66, 67, 
#nullable restore
#line 42 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      () => cFichaCliente.Codigopostal

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n\r\n");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "container-fluid");
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "card shadow mb-4");
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.AddMarkupContent(78, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Formulario Compra</h6>\r\n        </div>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(79);
            __builder.AddAttribute(80, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 53 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                          cFichaCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 53 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                         InsertFichaCliente

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(84);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n\r\n            ");
                __builder2.AddMarkupContent(86, "<label for=\"nome\">Código</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(87);
                __builder2.AddAttribute(88, "id", "nome");
                __builder2.AddAttribute(89, "class", "form-control");
                __builder2.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                   cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Nome = __value, cFichaCliente.Nome))));
                __builder2.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateValidationMessage_5(__builder2, 94, 95, 
#nullable restore
#line 58 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      () => cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(96, "\r\n\r\n            ");
                __builder2.AddMarkupContent(97, "<label for=\"telefone\">Descrição</label>\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateInputNumber_6(__builder2, 98, 99, "telefone", 100, "form-control", 101, 
#nullable restore
#line 61 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                         cFichaCliente.Telefone

#line default
#line hidden
#nullable disable
                , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Telefone = __value, cFichaCliente.Telefone)), 103, () => cFichaCliente.Telefone);
                __builder2.AddMarkupContent(104, "\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateValidationMessage_7(__builder2, 105, 106, 
#nullable restore
#line 62 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      () => cFichaCliente.Telefone

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(107, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(108, "<label for=\"email\">Quantidade</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(109);
                __builder2.AddAttribute(110, "id", "email");
                __builder2.AddAttribute(111, "class", "form-control");
                __builder2.AddAttribute(112, "placeholder", "Boas");
                __builder2.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                                       cFichaCliente.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Email = __value, cFichaCliente.Email))));
                __builder2.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateValidationMessage_8(__builder2, 117, 118, 
#nullable restore
#line 67 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      () => cFichaCliente.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(119, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(120, "<label for=\"morada\">Preço Unitário</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(121);
                __builder2.AddAttribute(122, "id", "morada");
                __builder2.AddAttribute(123, "class", "form-control");
                __builder2.AddAttribute(124, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                     cFichaCliente.Morada

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Morada = __value, cFichaCliente.Morada))));
                __builder2.AddAttribute(126, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Morada));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(127, "\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateValidationMessage_9(__builder2, 128, 129, 
#nullable restore
#line 72 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      () => cFichaCliente.Morada

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(130, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(131, "<label for=\"moradaopcional\">Preço Total</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(132);
                __builder2.AddAttribute(133, "id", "moradaopcional");
                __builder2.AddAttribute(134, "class", "form-control");
                __builder2.AddAttribute(135, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                             cFichaCliente.Moradaopcional

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Moradaopcional = __value, cFichaCliente.Moradaopcional))));
                __builder2.AddAttribute(137, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Moradaopcional));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(139, "<label for=\"codigopostal\">Apontamentos</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(140);
                __builder2.AddAttribute(141, "id", "codigopostal");
                __builder2.AddAttribute(142, "class", "form-control");
                __builder2.AddAttribute(143, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                                                           cFichaCliente.Codigopostal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(144, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Codigopostal = __value, cFichaCliente.Codigopostal))));
                __builder2.AddAttribute(145, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Codigopostal));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(146, "\r\n            ");
                __Blazor.GoldYAN.Pages.Compras.Icompra.TypeInference.CreateValidationMessage_10(__builder2, 147, 148, 
#nullable restore
#line 81 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
                                      () => cFichaCliente.Codigopostal

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(149, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(150, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n\r\n");
            __builder.AddMarkupContent(153, "<div class=\"container-fluid\">\r\n\r\n    <div class=\"card shadow mb-4\">\r\n        <div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Stock</h6>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"table-responsive\">\r\n                <div id=\"dataTable_wrapper\" class=\"dataTables_wrapper dt-bootstrap4\">\r\n                    <div class=\"col-sm-12\">\r\n                        <table class=\"table table-bordered dataTable\" id=\"dataTable\" width=\"100%\" cellspacing=\"0\" role=\"grid\" aria-describedby=\"dataTable_info\" style=\"width: 100%;\">\r\n                            <thead>\r\n                                <tr role=\"row\"><th class=\"sorting_asc\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-sort=\"ascending\" aria-label=\"Name: activate to sort column descending\" style=\"width: 101px;\">Codigo</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Position: activate to sort column ascending\" style=\"width: 170px;\">Descrição</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Office: activate to sort column ascending\" style=\"width: 71px;\">Quantidade</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Age: activate to sort column ascending\" style=\"width: 31px;\">Preço Unitário</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Start date: activate to sort column ascending\" style=\"width: 68px;\">Preço total</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 67px;\">Apontamentos</th></tr>\r\n                            </thead>\r\n                            <tfoot>\r\n                                <tr><th rowspan=\"1\" colspan=\"1\">Código</th><th rowspan=\"1\" colspan=\"1\">Descrição</th><th rowspan=\"1\" colspan=\"1\">Quantidade</th><th rowspan=\"1\" colspan=\"1\">Preço Unitário</th><th rowspan=\"1\" colspan=\"1\">Preço total</th><th rowspan=\"1\" colspan=\"1\">Apontamentos</th></tr>\r\n                            </tfoot>\r\n                            <tbody>\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Compras\Icompra.razor"
       

    private Clientes cFichaCliente = new Clientes();

    public void variables()
    {
        string data;
        data = DateTime.Now.ToString();


    }

    private async Task InsertFichaCliente()
    {
    // await JsRuntime.InvokeVoidAsync("setElementTextById", "resultJson", JsonSerializer.Serialize(cFichaCliente));
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoProdutoController TPRC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TipoPecaController TPC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModelosController MC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ColaboradoresController colaboradoresController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CabecalhoModeloController CMC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicosController SC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
namespace __Blazor.GoldYAN.Pages.Compras.Icompra
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
