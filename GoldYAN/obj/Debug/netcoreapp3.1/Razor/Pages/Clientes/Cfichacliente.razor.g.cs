#pragma checksum "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28a31fb8051f14d2e077403cd67c0e9b498fd6d"
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
                __builder2.AddAttribute(16, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.AddMarkupContent(18, "<label class for=\"nome\">Nome:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "w-25 form-control");
                __builder2.AddAttribute(21, "placeholder", "Nome do cliente");
                __builder2.AddAttribute(22, "id", "nome");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                           cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Nome = __value, cFichaCliente.Nome))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, "alert alert-warning", 29, 
#nullable restore
#line 19 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                      () => cFichaCliente.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.AddMarkupContent(35, "<label for=\"telefone\">Telefone:</label>\r\n                ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateInputNumber_1(__builder2, 36, 37, "w-25 form-control", 38, "telefone", 39, 
#nullable restore
#line 23 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                  cFichaCliente.Telefone

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Telefone = __value, cFichaCliente.Telefone)), 41, () => cFichaCliente.Telefone);
                __builder2.AddMarkupContent(42, "\r\n                ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_2(__builder2, 43, 44, "alert alert-warning", 45, 
#nullable restore
#line 24 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                      () => cFichaCliente.Telefone

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.AddMarkupContent(51, "<label for=\"email\">Email:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "class", "w-25 form-control");
                __builder2.AddAttribute(54, "id", "email");
                __builder2.AddAttribute(55, "placeholder", "Boas");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                                cFichaCliente.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Email = __value, cFichaCliente.Email))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n                ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_3(__builder2, 60, 61, "alert alert-warning", 62, 
#nullable restore
#line 29 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                      () => cFichaCliente.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.AddMarkupContent(68, "<label for=\"morada\">Morada:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(69);
                __builder2.AddAttribute(70, "class", "w-25 form-control");
                __builder2.AddAttribute(71, "id", "morada");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                              cFichaCliente.Morada

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Morada = __value, cFichaCliente.Morada))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Morada));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_4(__builder2, 76, 77, "alert alert-warning", 78, 
#nullable restore
#line 34 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                      () => cFichaCliente.Morada

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.AddMarkupContent(84, "<label for=\"moradaopcional\">Morada Opcional:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(85);
                __builder2.AddAttribute(86, "class", "w-25 form-control");
                __builder2.AddAttribute(87, "id", "moradaopcional");
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                      cFichaCliente.Moradaopcional

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Moradaopcional = __value, cFichaCliente.Moradaopcional))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Moradaopcional));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.AddMarkupContent(96, "<label for=\"codigopostal\">Codigo Postal:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(97);
                __builder2.AddAttribute(98, "class", "w-25 form-control");
                __builder2.AddAttribute(99, "id", "codigopostal");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                    cFichaCliente.Codigopostal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Codigopostal = __value, cFichaCliente.Codigopostal))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Codigopostal));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n                ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_5(__builder2, 104, 105, "alert alert-warning", 106, 
#nullable restore
#line 43 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                       () => cFichaCliente.Codigopostal

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(111, "<label for=\"nif\">Nif:</label>\r\n            ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateInputNumber_6(__builder2, 112, 113, "w-25 form-control", 114, "nif", 115, 
#nullable restore
#line 47 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                         cFichaCliente.Nif

#line default
#line hidden
#nullable disable
                , 116, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Nif = __value, cFichaCliente.Nif)), 117, () => cFichaCliente.Nif);
                __builder2.AddMarkupContent(118, "\r\n            ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_7(__builder2, 119, 120, "alert alert-warning", 121, 
#nullable restore
#line 48 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                   () => cFichaCliente.Nif

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n            ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(126, "\r\n                ");
                __builder2.AddMarkupContent(127, "<label for=\"Profissao\">Profissão</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(128);
                __builder2.AddAttribute(129, "class", "w-25 form-control");
                __builder2.AddAttribute(130, "id", "Profissao");
                __builder2.AddAttribute(131, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                                 cFichaCliente.Profissao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(132, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cFichaCliente.Profissao = __value, cFichaCliente.Profissao))));
                __builder2.AddAttribute(133, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cFichaCliente.Profissao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(134, "\r\n                ");
                __Blazor.GoldYAN.Pages.Clientes.Cfichacliente.TypeInference.CreateValidationMessage_8(__builder2, 135, 136, "alert alert-warning", 137, 
#nullable restore
#line 53 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
                                                                      () => cFichaCliente.Profissao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(138, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n            ");
                __builder2.AddMarkupContent(140, @"<div class=""form-group m-3"">
                <button type=""submit"" class=""btn btn-primary float-right"">Criar</button>
                <button type=""reset"" style=""margin-right: 0.5rem"" class=""btn btn-primary float-right"">Cancelar</button>
            </div>
        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(141, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Clientes\Cfichacliente.razor"
       


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
    }
}
namespace __Blazor.GoldYAN.Pages.Clientes.Cfichacliente
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
