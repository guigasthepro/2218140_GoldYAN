#pragma checksum "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6993587a4b02c394836fec579b6c6a19e9841928"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages.Moldes
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
#nullable restore
#line 2 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cmoldes")]
    public partial class Cmolde : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card shadow mb-4");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<div class=\"card-header py-3\">\n            <h6 class=\"m-0 font-weight-bold text-primary\">Moldes</h6>\n        </div>\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
                          cMolde

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
                                                                     CriarMolde

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\n         \n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.AddMarkupContent(16, "<label for=\"codigo\">Código</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(19, "class", "w-25 form-control");
                __builder2.AddAttribute(20, "id", "codigo");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
                                                                                                                              cMolde.codigo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cMolde.codigo = __value, cMolde.codigo))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cMolde.codigo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n                ");
                __Blazor.GoldYAN.Pages.Moldes.Cmolde.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 17 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
                                          () => cMolde.codigo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(31, "\n                ");
                __builder2.AddMarkupContent(32, "<label for=\"descricao\">Descrição</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(35, "class", "w-25 form-control");
                __builder2.AddAttribute(36, "id", "descricao");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
                                                                                                                                 cMolde.descricao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cMolde.descricao = __value, cMolde.descricao))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cMolde.descricao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n                ");
                __Blazor.GoldYAN.Pages.Moldes.Cmolde.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 23 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
                                          () => cMolde.descricao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(47, "\n                ");
                __builder2.AddMarkupContent(48, "<label for=\"gaveta\">Gaveta</label>\n                ");
                __Blazor.GoldYAN.Pages.Moldes.Cmolde.TypeInference.CreateInputNumber_2(__builder2, 49, 50, "w-25 form-control", 51, "gaveta", 52, "Boas", 53, 
#nullable restore
#line 27 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
                                                                                                   cMolde.gaveta

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cMolde.gaveta = __value, cMolde.gaveta)), 55, () => cMolde.gaveta);
                __builder2.AddMarkupContent(56, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n\n\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(60, "\n                ");
                __builder2.AddMarkupContent(61, "<label for=\"peso\">Peso</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "class", "w-25 form-control");
                __builder2.AddAttribute(64, "id", "peso");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
                                                                            cMolde.peso

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cMolde.peso = __value, cMolde.peso))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cMolde.peso));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\n            ");
                __builder2.AddMarkupContent(70, @"<div class=""m-3"">
                <button class=""btn btn-primary float-right"" style=""margin-left: 5px"" type=""reset"">Cancelar</button>
                <button class=""btn btn-primary float-right"" type=""submit"">Criar Molde</button>
            </div>
        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Guilherme Simao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Cmolde.razor"
       

    private Moldes cMolde = new Moldes();

    List<TipoProduto> TP = new List<TipoProduto>();

    public string idtp  { get; set; }

    protected override async Task OnInitializedAsync()
    {
        TP = TPRC.GetAll();
    }

    public void CriarMolde()
    {
        CM.Post(cMolde);
        Esperar();
        cMolde = new Moldes();
    }

    public async Task Esperar()
    {
        await Task.Delay(2500);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MoldesController CM { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalizacaoController LocalizacaoC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosController EstadosC { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComprasController ComprasC { get; set; }
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
namespace __Blazor.GoldYAN.Pages.Moldes.Cmolde
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
