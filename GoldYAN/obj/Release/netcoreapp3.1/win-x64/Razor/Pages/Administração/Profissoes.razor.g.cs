#pragma checksum "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52420202fe44027422ca9c897f5bce9eeec9f72"
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
#line 1 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profissoes")]
    public partial class Profissoes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
 if (showModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "myModal");
            __builder.AddAttribute(4, "style", "display:block");
            __builder.AddAttribute(5, "aria-modal", "true");
            __builder.AddAttribute(6, "role", "dialog");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-dialog modal-dialog-centered");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<h4 class=\"modal-title\">Atualizar Informação</h4>\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                                   ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal-body");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(28);
            __builder.AddAttribute(29, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                      updateP

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                               Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group m-3 p-1");
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __builder2.AddMarkupContent(36, "<label for=\"telefone\">Codigo Profissão:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "class", "w-25 form-control");
                __builder2.AddAttribute(39, "id", "telefone");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                                                            updateP.codigo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateP.codigo = __value, updateP.codigo))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateP.codigo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group m-3 p-1");
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.AddMarkupContent(48, "<label for=\"email\">Nome:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "class", "w-25 form-control");
                __builder2.AddAttribute(51, "id", "email");
                __builder2.AddAttribute(52, "placeholder", "Boas");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                                                                            updateP.nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateP.nome = __value, updateP.nome))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateP.nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.AddMarkupContent(58, @"<div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                            <button type=""submit"" class=""btn btn-primary"">Atualizar</button>
                        </div>
                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 39 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(65);
            __builder.AddAttribute(66, "Roles", "Admin");
            __builder.AddAttribute(67, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "container-fluid");
                __builder2.AddMarkupContent(71, "\r\n\r\n\r\n            \r\n            \r\n            ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "card shadow mb-4");
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.AddMarkupContent(75, "<div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Listagem de Clientes</h6>\r\n                </div>\r\n                ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "card-body");
                __builder2.AddMarkupContent(78, "\r\n                    ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "table-responsive");
                __builder2.AddMarkupContent(81, "\r\n                        ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "id", "dataTable_wrapper");
                __builder2.AddAttribute(84, "class", "dataTables_wrapper dt-bootstrap4");
                __builder2.AddMarkupContent(85, "\r\n                            ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "row");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-sm-12 col-md-6");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "dataTables_length");
                __builder2.AddAttribute(92, "id", "dataTable_length");
                __builder2.OpenElement(93, "label");
                __builder2.AddContent(94, "Mostrar X Clientes ");
                __builder2.OpenElement(95, "select");
                __builder2.AddAttribute(96, "name", "dataTable_length");
                __builder2.AddAttribute(97, "aria-controls", "dataTable");
                __builder2.AddAttribute(98, "class", "custom-select custom-select-sm form-control form-control-sm");
                __builder2.OpenElement(99, "option");
                __builder2.AddAttribute(100, "value", "10");
                __builder2.AddContent(101, "10");
                __builder2.CloseElement();
                __builder2.OpenElement(102, "option");
                __builder2.AddAttribute(103, "value", "25");
                __builder2.AddContent(104, "25");
                __builder2.CloseElement();
                __builder2.OpenElement(105, "option");
                __builder2.AddAttribute(106, "value", "50");
                __builder2.AddContent(107, "50");
                __builder2.CloseElement();
                __builder2.OpenElement(108, "option");
                __builder2.AddAttribute(109, "value", "100");
                __builder2.AddContent(110, "100");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "<div class=\"col-sm-12 col-md-6\"><div id=\"dataTable_filter\" class=\"dataTables_filter\"><label>Procurar:<input type=\"search\" class=\"form-control form-control-sm\" placeholder aria-controls=\"dataTable\"></label></div></div>");
                __builder2.CloseElement();
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "row");
                __builder2.AddMarkupContent(114, "\r\n                                ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "col-sm-12");
                __builder2.AddMarkupContent(117, "\r\n                                    ");
                __builder2.OpenElement(118, "table");
                __builder2.AddAttribute(119, "class", "table table-bordered dataTable");
                __builder2.AddAttribute(120, "id", "dataTable");
                __builder2.AddAttribute(121, "width", "100%");
                __builder2.AddAttribute(122, "cellspacing", "0");
                __builder2.AddAttribute(123, "role", "grid");
                __builder2.AddAttribute(124, "aria-describedby", "dataTable_info");
                __builder2.AddAttribute(125, "style", "width: 100%;");
                __builder2.AddMarkupContent(126, "\r\n                                        ");
                __builder2.AddMarkupContent(127, @"<thead>
                                            <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"" style=""width: 101px;"">IDProfissão</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 170px;"">Codigo</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Office: activate to sort column ascending"" style=""width: 71px;"">Nome</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 67px;"">Ações</th></tr>
                                        </thead>
                                        ");
                __builder2.AddMarkupContent(128, @"<tfoot>
                                            <tr><th rowspan=""1"" colspan=""1"">IDProfissão</th><th rowspan=""1"" colspan=""1"">Codigo</th><th rowspan=""1"" colspan=""1"">Nome</th><th rowspan=""1"" colspan=""1"">Ações</th></tr>
                                        </tfoot>
                                        ");
                __builder2.OpenElement(129, "tbody");
                __builder2.AddMarkupContent(130, "\r\n");
#nullable restore
#line 65 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                             foreach (var profissao in @VPS)
                                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(131, "                                                ");
                __builder2.OpenElement(132, "tr");
                __builder2.AddAttribute(133, "role", "row");
                __builder2.AddAttribute(134, "class", "odd");
                __builder2.AddAttribute(135, "id", 
#nullable restore
#line 67 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                                                profissao.idprofissao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(136, "\r\n                                                    ");
                __builder2.OpenElement(137, "td");
                __builder2.AddContent(138, 
#nullable restore
#line 68 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                         profissao.idprofissao

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                                                    ");
                __builder2.OpenElement(140, "td");
                __builder2.AddContent(141, 
#nullable restore
#line 69 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                         profissao.codigo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n                                                    ");
                __builder2.OpenElement(143, "td");
                __builder2.AddContent(144, 
#nullable restore
#line 70 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                         profissao.nome

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n\r\n                                                    ");
                __builder2.OpenElement(146, "td");
                __builder2.OpenElement(147, "button");
                __builder2.AddAttribute(148, "class", "btn btn-primary");
                __builder2.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                                                                   ModalShow

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(150, "style", "margin-left:1rem");
                __builder2.AddContent(151, "Editar");
                __builder2.CloseElement();
                __builder2.OpenElement(152, "button");
                __builder2.AddAttribute(153, "class", "btn btn-danger");
                __builder2.AddAttribute(154, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                                                                                                                                                                               () => Apagar(profissao.idprofissao)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(155, "style", "margin-left:0.3rem");
                __builder2.AddContent(156, "Apagar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\r\n");
#nullable restore
#line 74 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(159, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "<div class=\"row\"><div class=\"col-sm-12 col-md-5\"><div class=\"dataTables_info\" id=\"dataTable_info\" role=\"status\" aria-live=\"polite\">Showing 1 to 10 of 57 entries</div></div><div class=\"col-sm-12 col-md-7\"><div class=\"dataTables_paginate paging_simple_numbers\" id=\"dataTable_paginate\"><ul class=\"pagination\"><li class=\"paginate_button page-item previous disabled\" id=\"dataTable_previous\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a></li><li class=\"paginate_button page-item active\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"1\" tabindex=\"0\" class=\"page-link\">1</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"2\" tabindex=\"0\" class=\"page-link\">2</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"3\" tabindex=\"0\" class=\"page-link\">3</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"4\" tabindex=\"0\" class=\"page-link\">4</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"5\" tabindex=\"0\" class=\"page-link\">5</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"6\" tabindex=\"0\" class=\"page-link\">6</a></li><li class=\"paginate_button page-item next\" id=\"dataTable_next\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"7\" tabindex=\"0\" class=\"page-link\">Next</a></li></ul></div></div></div>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(167, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n    ");
            }
            ));
            __builder.AddAttribute(169, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(170, "\r\n        ");
                __builder2.AddMarkupContent(171, "<h1>Não tem acesso a esta página</h1>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(172, "\r\n\r\n\r\n\r\n}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Profissoes.razor"
       

    List<GoldYAN.Data.Profissoes> VPS = new List<GoldYAN.Data.Profissoes>();

    Data.Profissoes updateP = new Data.Profissoes();

    bool showModal = false;

    protected override async Task OnInitializedAsync()
    {
        VPS = VP.Get();

        foreach (var profissao in @VPS)
        {
           updateP.idprofissao = profissao.idprofissao;
           updateP.codigo = profissao.codigo;
           updateP.nome = profissao.nome;

        }

    }

    public async Task Apagar(int id)
    {

        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            string message = VP.Delete(id);
            OnInitializedAsync();
            Task.Delay(1000);
            {
                await js.InvokeVoidAsync("alert", @message);
            }
        }
    }

    public async Task Update()
    {
        VP.Put(updateP.idprofissao, updateP);
        showModal = false;
    }


    void ModalShow()
    {
        showModal = true;
    }
    void ModalCancel()
    {
        showModal = false;
    }

    void ModalOk()
    {
        Console.WriteLine("Modal ok");
        showModal = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProfissoesController VP { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
