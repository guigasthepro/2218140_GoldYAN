#pragma checksum "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff2092c02258c7f6fbc58e24e8fd471d4f7aa7d"
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
#line 1 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\_Imports.razor"
using GoldYAN.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/materiais")]
    public partial class Materias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
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
#line 15 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
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
#line 20 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                      updateM

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
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
                __builder2.AddMarkupContent(36, "<label for=\"telefone\">Alcunha:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "class", "w-25 form-control");
                __builder2.AddAttribute(39, "id", "telefone");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                                            updateM.alcunha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateM.alcunha = __value, updateM.alcunha))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateM.alcunha));
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
#line 27 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                                                            updateM.nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateM.nome = __value, updateM.nome))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateM.nome));
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
#line 38 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 40 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
 if (showModal2)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "modal fade show");
            __builder.AddAttribute(68, "id", "myModal");
            __builder.AddAttribute(69, "style", "display:block; background-color:rgba(128, 128, 128, 0.5);");
            __builder.AddAttribute(70, "aria-modal", "true");
            __builder.AddAttribute(71, "role", "dialog");
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "modal-dialog modal-dialog-centered");
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-content");
            __builder.AddMarkupContent(78, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "modal-header");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.AddMarkupContent(82, "<h4 class=\"modal-title\">Inserir nova matéria</h4>\r\n                    ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "type", "button");
            __builder.AddAttribute(85, "class", "close");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                   ModalCancel2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(87, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n                \r\n                ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "modal-body");
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(93);
            __builder.AddAttribute(94, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 54 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                      criarM

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 54 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                              Criar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(97, "\r\n                        ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group m-3 p-1");
                __builder2.AddMarkupContent(100, "\r\n                            ");
                __builder2.AddMarkupContent(101, "<label for=\"telefone\">Alcunha:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(102);
                __builder2.AddAttribute(103, "class", "w-25 form-control");
                __builder2.AddAttribute(104, "id", "telefone");
                __builder2.AddAttribute(105, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                                            criarM.alcunha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => criarM.alcunha = __value, criarM.alcunha))));
                __builder2.AddAttribute(107, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => criarM.alcunha));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                        ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "form-group m-3 p-1");
                __builder2.AddMarkupContent(112, "\r\n                            ");
                __builder2.AddMarkupContent(113, "<label for=\"email\">Nome:</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(114);
                __builder2.AddAttribute(115, "class", "w-25 form-control");
                __builder2.AddAttribute(116, "id", "email");
                __builder2.AddAttribute(117, "placeholder", "Boas");
                __builder2.AddAttribute(118, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                                                            criarM.nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => criarM.nome = __value, criarM.nome))));
                __builder2.AddAttribute(120, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => criarM.nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                        ");
                __builder2.AddMarkupContent(123, @"<div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                            <button type=""submit"" class=""btn btn-primary"">Criar Matéria</button>
                        </div>
                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(124, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 72 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(129, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(130);
            __builder.AddAttribute(131, "Roles", "Admin");
            __builder.AddAttribute(132, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "container-fluid");
                __builder2.AddMarkupContent(136, "\r\n            \r\n            \r\n            ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "card shadow mb-4");
                __builder2.AddMarkupContent(139, "\r\n                ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "card-header py-3");
                __builder2.AddMarkupContent(142, "\r\n                    ");
                __builder2.AddMarkupContent(143, "<h6 class=\"m-0 font-weight-bold text-primary\" style=\"display: inline;\">Listagem das Matérias</h6>");
                __builder2.OpenElement(144, "button");
                __builder2.AddAttribute(145, "type", "submit");
                __builder2.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                                                                                                     ModalShow2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(147, "class", "btn btn-success btn-sm float-right");
                __builder2.AddContent(148, "Inserir Materia");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n                ");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "card-body");
                __builder2.AddMarkupContent(153, "\r\n                    ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "table-responsive");
                __builder2.AddMarkupContent(156, "\r\n                        ");
                __builder2.OpenElement(157, "div");
                __builder2.AddAttribute(158, "id", "dataTable_wrapper");
                __builder2.AddAttribute(159, "class", "dataTables_wrapper dt-bootstrap4");
                __builder2.AddMarkupContent(160, "\r\n                            ");
                __builder2.OpenElement(161, "div");
                __builder2.AddAttribute(162, "class", "row");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "col-sm-12 col-md-6");
                __builder2.OpenElement(165, "div");
                __builder2.AddAttribute(166, "class", "dataTables_length");
                __builder2.AddAttribute(167, "id", "dataTable_length");
                __builder2.OpenElement(168, "label");
                __builder2.AddContent(169, "Mostrar X Clientes ");
                __builder2.OpenElement(170, "select");
                __builder2.AddAttribute(171, "name", "dataTable_length");
                __builder2.AddAttribute(172, "aria-controls", "dataTable");
                __builder2.AddAttribute(173, "class", "custom-select custom-select-sm form-control form-control-sm");
                __builder2.OpenElement(174, "option");
                __builder2.AddAttribute(175, "value", "10");
                __builder2.AddContent(176, "10");
                __builder2.CloseElement();
                __builder2.OpenElement(177, "option");
                __builder2.AddAttribute(178, "value", "25");
                __builder2.AddContent(179, "25");
                __builder2.CloseElement();
                __builder2.OpenElement(180, "option");
                __builder2.AddAttribute(181, "value", "50");
                __builder2.AddContent(182, "50");
                __builder2.CloseElement();
                __builder2.OpenElement(183, "option");
                __builder2.AddAttribute(184, "value", "100");
                __builder2.AddContent(185, "100");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "<div class=\"col-sm-12 col-md-6\"><div id=\"dataTable_filter\" class=\"dataTables_filter\"><label>Procurar:<input type=\"search\" class=\"form-control form-control-sm\" placeholder aria-controls=\"dataTable\"></label></div></div>");
                __builder2.CloseElement();
                __builder2.OpenElement(187, "div");
                __builder2.AddAttribute(188, "class", "row");
                __builder2.AddMarkupContent(189, "\r\n                                ");
                __builder2.OpenElement(190, "div");
                __builder2.AddAttribute(191, "class", "col-sm-12");
                __builder2.AddMarkupContent(192, "\r\n                                    ");
                __builder2.OpenElement(193, "table");
                __builder2.AddAttribute(194, "class", "table table-bordered dataTable");
                __builder2.AddAttribute(195, "id", "dataTable");
                __builder2.AddAttribute(196, "width", "100%");
                __builder2.AddAttribute(197, "cellspacing", "0");
                __builder2.AddAttribute(198, "role", "grid");
                __builder2.AddAttribute(199, "aria-describedby", "dataTable_info");
                __builder2.AddAttribute(200, "style", "width: 100%;");
                __builder2.AddMarkupContent(201, "\r\n                                        ");
                __builder2.AddMarkupContent(202, @"<thead>
                                            <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"" style=""width: 101px;"">IDMateria</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 170px;"">Alcunha</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Office: activate to sort column ascending"" style=""width: 71px;"">Nome</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 67px;"">Ações</th></tr>
                                        </thead>
                                        ");
                __builder2.AddMarkupContent(203, @"<tfoot>
                                            <tr><th rowspan=""1"" colspan=""1"">IDMateria</th><th rowspan=""1"" colspan=""1"">Alcunha</th><th rowspan=""1"" colspan=""1"">Nome</th><th rowspan=""1"" colspan=""1"">Ações</th></tr>
                                        </tfoot>
                                        ");
                __builder2.OpenElement(204, "tbody");
                __builder2.AddMarkupContent(205, "\r\n");
#nullable restore
#line 97 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                             foreach (var materia in @VMS)
                                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(206, "                                                ");
                __builder2.OpenElement(207, "tr");
                __builder2.AddAttribute(208, "role", "row");
                __builder2.AddAttribute(209, "class", "odd");
                __builder2.AddAttribute(210, "id", 
#nullable restore
#line 99 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                                materia.idmateria

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(211, "\r\n                                                    ");
                __builder2.OpenElement(212, "td");
                __builder2.AddContent(213, 
#nullable restore
#line 100 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                         materia.idmateria

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(214, "\r\n                                                    ");
                __builder2.OpenElement(215, "td");
                __builder2.AddContent(216, 
#nullable restore
#line 101 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                         materia.alcunha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(217, "\r\n                                                    ");
                __builder2.OpenElement(218, "td");
                __builder2.AddContent(219, 
#nullable restore
#line 102 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                         materia.nome

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(220, "\r\n                                                    ");
                __builder2.OpenElement(221, "td");
                __builder2.OpenElement(222, "button");
                __builder2.AddAttribute(223, "class", "btn btn-primary");
                __builder2.AddAttribute(224, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                                                   ModalShow

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(225, "style", "margin-left:1rem");
                __builder2.AddContent(226, "Editar");
                __builder2.CloseElement();
                __builder2.OpenElement(227, "button");
                __builder2.AddAttribute(228, "class", "btn btn-danger");
                __builder2.AddAttribute(229, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                                                                                                                                                                               () => Apagar(materia.idmateria)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(230, "style", "margin-left:0.3rem");
                __builder2.AddContent(231, "Apagar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(232, "\r\n                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(233, "\r\n");
#nullable restore
#line 105 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(234, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(235, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(236, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(237, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(238, "<div class=\"row\"><div class=\"col-sm-12 col-md-5\"><div class=\"dataTables_info\" id=\"dataTable_info\" role=\"status\" aria-live=\"polite\">Showing 1 to 10 of 57 entries</div></div><div class=\"col-sm-12 col-md-7\"><div class=\"dataTables_paginate paging_simple_numbers\" id=\"dataTable_paginate\"><ul class=\"pagination\"><li class=\"paginate_button page-item previous disabled\" id=\"dataTable_previous\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"0\" tabindex=\"0\" class=\"page-link\">Previous</a></li><li class=\"paginate_button page-item active\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"1\" tabindex=\"0\" class=\"page-link\">1</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"2\" tabindex=\"0\" class=\"page-link\">2</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"3\" tabindex=\"0\" class=\"page-link\">3</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"4\" tabindex=\"0\" class=\"page-link\">4</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"5\" tabindex=\"0\" class=\"page-link\">5</a></li><li class=\"paginate_button page-item \"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"6\" tabindex=\"0\" class=\"page-link\">6</a></li><li class=\"paginate_button page-item next\" id=\"dataTable_next\"><a href=\"#\" aria-controls=\"dataTable\" data-dt-idx=\"7\" tabindex=\"0\" class=\"page-link\">Next</a></li></ul></div></div></div>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(239, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(240, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(241, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(242, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(243, "\r\n    ");
            }
            ));
            __builder.AddAttribute(244, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(245, "\r\n        ");
                __builder2.AddMarkupContent(246, "<h1>Não tem acesso a esta página</h1>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Materias.razor"
       

    List<GoldYAN.Data.Materias> VMS = new List<GoldYAN.Data.Materias>();

    Data.Materias updateM = new Data.Materias();

    Data.Materias criarM = new Data.Materias();

    bool showModal = false;
    bool showModal2 = false;

    protected override async Task OnInitializedAsync()
    {
        VMS = VM.Get();

        foreach (var materia in @VMS)
        {
            updateM.idmateria = materia.idmateria;
            updateM.alcunha = materia.alcunha;
            updateM.nome = materia.nome;
        }

    }

    public async Task Apagar(int id)
    {

        bool confirmation;

        confirmation = await js.InvokeAsync<bool>("confirm", "Quer mesmo apagar?");

        if (confirmation)
        {
            string message = VM.Delete(id);
            OnInitializedAsync();
            Task.Delay(1000);
            {
                await js.InvokeVoidAsync("alert", @message);
            }
        }
    }

    public async Task Update()
    {
        VM.Put(updateM.idmateria, updateM);
        showModal = false;
    }

    public async Task Criar()
    {
        var resultado = VM.Post(criarM);
        StateHasChanged();
        showModal2 = false;
        VMS = VM.Get();

    }


    void ModalShow()
    {
        showModal = true;
    }
    void ModalCancel()
    {
        showModal = false;
    }

    void ModalShow2()
    {
        showModal2 = true;
    }
    void ModalCancel2()
    {
        showModal2 = false;
    }

    void ModalOk()
    {
        Console.WriteLine("Modal ok");
        showModal = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MateriasController VM { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
