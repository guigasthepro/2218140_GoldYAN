#pragma checksum "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Administração\Utilizadores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318cb131644371aedfda585846835453b1ae1913"
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
    public partial class Utilizadores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Utilizadores</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n    \r\n    \r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card shadow mb-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Listagem de Clientes</h6>\r\n        </div>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "table-responsive");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "dataTable_wrapper");
            __builder.AddAttribute(16, "class", "dataTables_wrapper dt-bootstrap4");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "dataTables_length");
            __builder.AddAttribute(24, "id", "dataTable_length");
            __builder.OpenElement(25, "label");
            __builder.AddContent(26, "Mostrar X Clientes ");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "name", "dataTable_length");
            __builder.AddAttribute(29, "aria-controls", "dataTable");
            __builder.AddAttribute(30, "class", "custom-select custom-select-sm form-control form-control-sm");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "10");
            __builder.AddContent(33, "10");
            __builder.CloseElement();
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "25");
            __builder.AddContent(36, "25");
            __builder.CloseElement();
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "50");
            __builder.AddContent(39, "50");
            __builder.CloseElement();
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "100");
            __builder.AddContent(42, "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "<div class=\"col-sm-12 col-md-6\"><div id=\"dataTable_filter\" class=\"dataTables_filter\"><label>Procurar:<input type=\"search\" class=\"form-control form-control-sm\" placeholder aria-controls=\"dataTable\"></label></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "<div class=\"row\">\r\n                        <div class=\"col-sm-12\">\r\n                            <table class=\"table table-bordered dataTable\" id=\"dataTable\" width=\"100%\" cellspacing=\"0\" role=\"grid\" aria-describedby=\"dataTable_info\" style=\"width: 100%;\">\r\n                                <thead>\r\n                                    <tr role=\"row\"><th class=\"sorting_asc\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-sort=\"ascending\" aria-label=\"Name: activate to sort column descending\" style=\"width: 101px;\">Nome</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Position: activate to sort column ascending\" style=\"width: 170px;\">Telefone</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Office: activate to sort column ascending\" style=\"width: 71px;\">Email</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Contacto: activate to sort column ascending\" style=\"width: 31px;\">Localidade</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Start date: activate to sort column ascending\" style=\"width: 68px;\">Codigo Postal</th><th class=\"sorting_asc\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-sort=\"ascending\" aria-label=\"Name: activate to sort column descending\" style=\"width: 101px;\">Nif</th><th class=\"sorting_asc\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-sort=\"ascending\" aria-label=\"Name: activate to sort column descending\" style=\"width: 101px;\">Profissão</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 67px;\">Ações</th></tr>\r\n                                </thead>\r\n                                <tfoot>\r\n                                    <tr><th rowspan=\"1\" colspan=\"1\">Nome</th><th rowspan=\"1\" colspan=\"1\">Telefone</th><th rowspan=\"1\" colspan=\"1\">Email</th><th rowspan=\"1\" colspan=\"1\">Localidade</th><th rowspan=\"1\" colspan=\"1\">Codigo Postal</th><th rowspan=\"1\" colspan=\"1\">Nif</th><th rowspan=\"1\" colspan=\"1\">Profissão</th><th rowspan=\"1\" colspan=\"1\">Ações</th></tr>\r\n                                </tfoot>\r\n                                <tbody>\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>");
            __builder.AddMarkupContent(45, @"<div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""dataTable_info"" role=""status"" aria-live=""polite"">Showing 1 to 10 of 57 entries</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""dataTable_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""dataTable_previous""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">Previous</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""dataTable_next""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">Next</a></li></ul></div></div></div>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
