#pragma checksum "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38ce8a408c73ee453d3b7fafd34c8a8e3dd42718"
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
#line 2 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
using GoldYAN.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
using GoldYAN.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
using System.Runtime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vmoldes")]
    public partial class Vmoldes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
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
            __builder.AddMarkupContent(17, "<h4 class=\"modal-title\">Lançar Estado</h4>\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                  FecharModal

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
            __builder.AddMarkupContent(27, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(28);
            __builder.AddAttribute(29, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                      Emolde

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "form-group");
            __builder.AddAttribute(31, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 25 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                                Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n\r\n                        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.AddMarkupContent(37, "<label for=\"codigo\">Código</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "autocomplete", "false");
                __builder2.AddAttribute(40, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(41, "placeholder", "Código Molde");
                __builder2.AddAttribute(42, "class", "w-25 form-control");
                __builder2.AddAttribute(43, "id", "codigo");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                                                                                                                                          Emolde.codigo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Emolde.codigo = __value, Emolde.codigo))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Emolde.codigo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __Blazor.GoldYAN.Pages.Moldes.Vmoldes.TypeInference.CreateValidationMessage_0(__builder2, 48, 49, 
#nullable restore
#line 30 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                      () => Emolde.codigo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __builder2.AddMarkupContent(55, "<label for=\"descricao\">Descrição</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "autocomplete", "false");
                __builder2.AddAttribute(58, "oninput", "this.value = this.value.toUpperCase()");
                __builder2.AddAttribute(59, "class", "w-25 form-control");
                __builder2.AddAttribute(60, "placeholder", "Descrição do Molde");
                __builder2.AddAttribute(61, "id", "descricao");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                                                                                                                                                   Emolde.descricao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Emolde.descricao = __value, Emolde.descricao))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Emolde.descricao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __Blazor.GoldYAN.Pages.Moldes.Vmoldes.TypeInference.CreateValidationMessage_1(__builder2, 66, 67, 
#nullable restore
#line 36 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                      () => Emolde.descricao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(72, "\r\n                            ");
                __builder2.AddMarkupContent(73, "<label for=\"gaveta\">Gaveta</label>\r\n                            ");
                __Blazor.GoldYAN.Pages.Moldes.Vmoldes.TypeInference.CreateInputNumber_2(__builder2, 74, 75, "false", 76, "-moz-appearance: textfield;", 77, "w-25 form-control", 78, "gaveta", 79, "Gaveta molde", 80, 
#nullable restore
#line 40 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                                                                                                                                Emolde.gaveta

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Emolde.gaveta = __value, Emolde.gaveta)), 82, () => Emolde.gaveta);
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n\r\n\r\n                        ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-group m-2 p-1");
                __builder2.AddMarkupContent(87, "\r\n                            ");
                __builder2.AddMarkupContent(88, "<label for=\"peso\">Peso</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(89);
                __builder2.AddAttribute(90, "class", "w-25 form-control");
                __builder2.AddAttribute(91, "id", "peso");
                __builder2.AddAttribute(92, "placeholder", "Peso do molde");
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                                                                    Emolde.peso

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Emolde.peso = __value, Emolde.peso))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Emolde.peso));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "modal-footer");
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.AddMarkupContent(103, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancelar</button>\r\n                    ");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "type", "submit");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                    Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "class", "btn btn-primary");
            __builder.AddContent(108, "Lancar");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 63 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"



}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(114, "\r\n");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "container-fluid");
            __builder.AddMarkupContent(117, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "card shadow mb-4");
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.AddMarkupContent(121, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Listagem de Moldes</h6>\r\n        </div>\r\n        ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "card-body");
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "table-responsive-sm");
            __builder.AddMarkupContent(127, "\r\n                ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "id", "dataTable_wrapper");
            __builder.AddAttribute(130, "class", "dataTables_wrapper dt-bootstrap4");
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "row");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "dataTables_length");
            __builder.AddAttribute(138, "id", "dataTable_length");
            __builder.OpenElement(139, "label");
            __builder.AddContent(140, "Show ");
            __builder.OpenElement(141, "select");
            __builder.AddAttribute(142, "name", "dataTable_length");
            __builder.AddAttribute(143, "aria-controls", "dataTable");
            __builder.AddAttribute(144, "class", "custom-select custom-select-sm form-control form-control-sm");
            __builder.OpenElement(145, "option");
            __builder.AddAttribute(146, "value", "10");
            __builder.AddContent(147, "10");
            __builder.CloseElement();
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value", "25");
            __builder.AddContent(150, "25");
            __builder.CloseElement();
            __builder.OpenElement(151, "option");
            __builder.AddAttribute(152, "value", "50");
            __builder.AddContent(153, "50");
            __builder.CloseElement();
            __builder.OpenElement(154, "option");
            __builder.AddAttribute(155, "value", "100");
            __builder.AddContent(156, "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(157, " entries");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "id", "dataTable_filter");
            __builder.AddAttribute(162, "class", "dataTables_filter");
            __builder.OpenElement(163, "label");
            __builder.AddContent(164, "Search:");
            __builder.OpenElement(165, "input");
            __builder.AddAttribute(166, "type", "search");
            __builder.AddAttribute(167, "class", "form-control form-control-sm");
            __builder.AddAttribute(168, "placeholder", "");
            __builder.AddAttribute(169, "aria-controls", "dataTable");
            __builder.AddAttribute(170, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(171, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filter = __value, Filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "row");
            __builder.AddMarkupContent(174, "\r\n                        ");
            __builder.OpenElement(175, "div");
            __builder.AddAttribute(176, "class", "col-sm-12");
            __builder.AddMarkupContent(177, "\r\n                            ");
            __builder.OpenElement(178, "table");
            __builder.AddAttribute(179, "class", "table table-sm table-bordered dataTable");
            __builder.AddAttribute(180, "id", "dataTable");
            __builder.AddAttribute(181, "width", "100%");
            __builder.AddAttribute(182, "cellspacing", "0");
            __builder.AddAttribute(183, "role", "grid");
            __builder.AddAttribute(184, "aria-describedby", "dataTable_info");
            __builder.AddAttribute(185, "style", "width: 100%;");
            __builder.AddMarkupContent(186, "\r\n                                ");
            __builder.AddMarkupContent(187, @"<thead>
                                    <tr role=""row""><th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Name: activate to sort column descending"" style=""width: 101px;"">IdMolde</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Position: activate to sort column ascending"" style=""width: 170px;"">Descrição</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Office: activate to sort column ascending"" style=""width: 71px;"">Gaveta</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 67px;"">Ações</th></tr>
                                </thead>
                                ");
            __builder.AddMarkupContent(188, @"<tfoot>
                                    <tr><th rowspan=""1"" colspan=""1"">IDMoldes</th><th rowspan=""1"" colspan=""1"">Descrição</th><th rowspan=""1"" colspan=""1"">Gaveta</th><th rowspan=""1"" colspan=""1"">Ações</th></tr>
                                </tfoot>
                                ");
            __builder.OpenElement(189, "tbody");
            __builder.AddMarkupContent(190, "\r\n");
#nullable restore
#line 88 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                     foreach (var molde in @VMS)
                                    {
                                        if (!IsVisible(molde))
                                            continue;

#line default
#line hidden
#nullable disable
            __builder.AddContent(191, "                                        ");
            __builder.OpenElement(192, "tr");
            __builder.AddAttribute(193, "role", "row");
            __builder.AddAttribute(194, "class", "odd");
            __builder.AddAttribute(195, "id", 
#nullable restore
#line 92 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                        molde.idmolde

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(196, "\r\n                                            ");
            __builder.OpenElement(197, "td");
            __builder.AddContent(198, 
#nullable restore
#line 93 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                 molde.codigo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n                                            ");
            __builder.OpenElement(200, "td");
            __builder.AddContent(201, 
#nullable restore
#line 94 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                 molde.descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n                                            ");
            __builder.OpenElement(203, "td");
            __builder.AddContent(204, 
#nullable restore
#line 95 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                 molde.gaveta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n                                            ");
            __builder.OpenElement(206, "td");
            __builder.OpenElement(207, "button");
            __builder.AddAttribute(208, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                                                  () => LoadModal(molde.idmolde)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(209, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(210, "style", "margin-left:1rem");
            __builder.AddMarkupContent(211, "<i class=\"fas fa-pen\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "<button class=\"btn btn-sm btn-danger\" style=\"margin-left:0.3rem\"><i class=\"fas fa-trash\"></i></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(213, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(214, "\r\n");
#nullable restore
#line 98 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(215, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(223, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\gsimao\Source\Repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Moldes\Vmoldes.razor"
       

    string DescricaoProduto;
    string Filter;
    bool showModal = false;
    Data.Moldes Emolde = new Moldes();
    List<Moldes> VMS = new List<Moldes>();

    protected override async Task OnInitializedAsync()
    {
        GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
        GC.Collect();
        VMS = VM.Get();

    }

    public bool IsVisible(Moldes moldes)
    {
        if (string.IsNullOrEmpty(Filter))
            return true;

        if (moldes.idmolde.ToString().ToLower().Contains(Filter) || moldes.descricao.ToLower().Contains(Filter) || moldes.tipodepeça.ToString().ToLower().Contains(Filter))
            return true;

        return false;
    }

    public async Task LoadModal(int id)
    {
        Emolde = VM.Get(id);
        showModal = true;
    }

    public async Task FecharModal()
    {
        showModal = false;
    }

    public async Task Update()
    {
        VM.Put(Emolde.idmolde, Emolde);
        OnInitializedAsync();
        showModal = false;

    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MoldesController VM { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
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
namespace __Blazor.GoldYAN.Pages.Moldes.Vmoldes
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
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "autocomplete", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "id", __arg3);
        __builder.AddAttribute(__seq4, "placeholder", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
