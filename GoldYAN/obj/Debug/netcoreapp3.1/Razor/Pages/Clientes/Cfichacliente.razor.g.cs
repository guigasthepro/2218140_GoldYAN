#pragma checksum "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd1d8f94162d941be88657c5f9092b62f07235b"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Clientes
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
#nullable restore
#line 2 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
using Microsoft.AspNetCore.Mvc.ModelBinding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cfichacliente")]
    public partial class Cfichacliente : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(6, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Ficha do Cliente</h6>\r\n        </div>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                             cFichaCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                            ClientCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group form-inline m-2 p-1");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.AddMarkupContent(18, "<label class for=\"nome\">Nome:</label> &nbsp;\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "w-25 form-control");
                __builder2.AddAttribute(21, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(22, "placeholder", "Nome do cliente");
                __builder2.AddAttribute(23, "id", "nome");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                                                                       cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Nome = __value, cFichaCliente.Nome))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, "alert alert-warning", 31, "color:red !important", 32, 
#nullable restore
#line 20 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                           () => cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(33, "\r\n\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group form-inline m-2 p-1");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.AddMarkupContent(37, "<label for=\"telefone\">Telefone:</label> &nbsp;\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "class", "w-25 form-control");
                __builder2.AddAttribute(40, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(41, "id", "telefone");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                                            cFichaCliente.Telefone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Telefone = __value, cFichaCliente.Telefone))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Telefone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, "alert alert-warning", 49, "color:red !important", 50, 
#nullable restore
#line 26 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                           () => cFichaCliente.Telefone

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(51, "\r\n\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group form-inline m-2 p-1");
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.AddMarkupContent(55, "<label for=\"email\">Email:</label> &nbsp;\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "class", "w-25 form-control");
                __builder2.AddAttribute(58, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(59, "id", "email");
                __builder2.AddAttribute(60, "placeholder", "Boas");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                                                            cFichaCliente.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Email = __value, cFichaCliente.Email))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_2(__builder2, 66, 67, "alert alert-warning", 68, "color:red !important", 69, 
#nullable restore
#line 32 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                           () => cFichaCliente.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\r\n\r\n        ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group form-inline m-2 p-1");
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.AddMarkupContent(74, "<label for=\"morada\">Morada:</label> &nbsp;\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "class", "w-25 form-control");
                __builder2.AddAttribute(77, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(78, "id", "morada");
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                                          cFichaCliente.Morada

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Morada = __value, cFichaCliente.Morada))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Morada));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n        ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_3(__builder2, 84, 85, "alert alert-warning", 86, "color:red !important", 87, 
#nullable restore
#line 38 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                           () => cFichaCliente.Morada

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(88, "\r\n\r\n        ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group form-inline m-2 p-1");
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.AddMarkupContent(92, "<label for=\"moradaopcional\">Morada Opcional:</label> &nbsp;\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(93);
                __builder2.AddAttribute(94, "class", "w-25 form-control");
                __builder2.AddAttribute(95, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(96, "id", "moradaopcional");
                __builder2.AddAttribute(97, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                                                  cFichaCliente.Moradaopcional

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Moradaopcional = __value, cFichaCliente.Moradaopcional))));
                __builder2.AddAttribute(99, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Moradaopcional));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group form-inline m-2 p-1");
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.AddMarkupContent(105, "<label for=\"codigopostal\">Codigo Postal:</label> &nbsp;\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(106);
                __builder2.AddAttribute(107, "class", "w-25 form-control");
                __builder2.AddAttribute(108, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(109, "id", "codigopostal");
                __builder2.AddAttribute(110, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                                                cFichaCliente.Codigopostal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Codigopostal = __value, cFichaCliente.Codigopostal))));
                __builder2.AddAttribute(112, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Codigopostal));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n        ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_4(__builder2, 115, 116, "alert alert-warning", 117, "color:red !important", 118, 
#nullable restore
#line 48 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                           () => cFichaCliente.Codigopostal

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(119, "\r\n\r\n        ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group form-inline m-2 p-1");
                __builder2.AddMarkupContent(122, "<label for=\"nif\">Nif:</label> &nbsp;\r\n        ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateInputNumber_5(__builder2, 123, 124, "w-25 form-control", 125, "nif", 126, 
#nullable restore
#line 52 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                     cFichaCliente.Nif

#line default
#line hidden
#nullable disable
                , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Nif = __value, cFichaCliente.Nif)), 128, () => cFichaCliente.Nif);
                __builder2.AddMarkupContent(129, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n    ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_6(__builder2, 131, 132, "alert alert-warning", 133, "color:red !important", 134, 
#nullable restore
#line 54 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                        () => cFichaCliente.Nif

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(135, "\r\n\r\n    ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-group form-inline m-2 p-1");
                __builder2.AddMarkupContent(138, "\r\n        ");
                __builder2.AddMarkupContent(139, "<label for=\"Profissao\">Profissão</label> &nbsp;\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(140);
                __builder2.AddAttribute(141, "class", "w-25  form-control");
                __builder2.AddAttribute(142, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(143, "id", "Profissao");
                __builder2.AddAttribute(144, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                                          cFichaCliente.Profissao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(145, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Profissao = __value, cFichaCliente.Profissao))));
                __builder2.AddAttribute(146, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Profissao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(147, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n    ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_7(__builder2, 149, 150, "alert alert-warning", 151, "color:red !important", 152, 
#nullable restore
#line 60 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                       () => cFichaCliente.Profissao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(153, "\r\n\r\n            ");
                __builder2.AddMarkupContent(154, @"<div class=""form-group m-3"">
                <button type=""submit"" class=""btn btn-primary float-right"">Criar</button>
                <button type=""reset"" style=""margin-right: 0.5rem"" class=""btn btn-primary float-right"">Cancelar</button>
            </div>
        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(155, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
       


    private Clientes cFichaCliente = new Clientes();

    public void ClientCreate()
    {
        CC.Post(cFichaCliente);
        Esperar();
        cFichaCliente = new Clientes();

    }

    public async Task Esperar() => await Task.Delay(2500);



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientesController CC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BancosController VB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EncomendasController EC { get; set; }
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
namespace __Blazor.GoldYAN.Pages.Clientes.Cfichacliente
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
