#pragma checksum "C:\Users\Guilherme Simao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Tables.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4b77485325e48d2bf7486e6aba20a9518703fe"
// <auto-generated/>
#pragma warning disable 1591
namespace GoldYAN.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/tables")]
    public partial class Tables : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(3, "<h1 class=\"h3 mb-2 text-gray-800\">Tables</h1>\r\n    ");
            __builder.AddMarkupContent(4, @"<p class=""mb-4"">DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the <a target=""_blank"" href=""https://datatables.net"">official DataTables documentation</a>.</p>

    
    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card shadow mb-4");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">DataTables Example</h6>\r\n        </div>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "table-responsive");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "id", "dataTable_wrapper");
            __builder.AddAttribute(17, "class", "dataTables_wrapper dt-bootstrap4");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-sm-12 col-md-6");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "dataTables_length");
            __builder.AddAttribute(25, "id", "dataTable_length");
            __builder.OpenElement(26, "label");
            __builder.AddContent(27, "Show ");
            __builder.OpenElement(28, "select");
            __builder.AddAttribute(29, "name", "dataTable_length");
            __builder.AddAttribute(30, "aria-controls", "dataTable");
            __builder.AddAttribute(31, "class", "custom-select custom-select-sm form-control form-control-sm");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "10");
            __builder.AddContent(34, "10");
            __builder.CloseElement();
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "25");
            __builder.AddContent(37, "25");
            __builder.CloseElement();
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "50");
            __builder.AddContent(40, "50");
            __builder.CloseElement();
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "100");
            __builder.AddContent(43, "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(44, " entries");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "<div class=\"col-sm-12 col-md-6\"><div id=\"dataTable_filter\" class=\"dataTables_filter\"><label>Search:<input type=\"search\" class=\"form-control form-control-sm\" placeholder aria-controls=\"dataTable\"></label></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "<div class=\"row\">\r\n                        <div class=\"col-sm-12\">\r\n                            <table class=\"table table-bordered dataTable\" id=\"dataTable\" width=\"100%\" cellspacing=\"0\" role=\"grid\" aria-describedby=\"dataTable_info\" style=\"width: 100%;\">\r\n                                <thead>\r\n                                    <tr role=\"row\"><th class=\"sorting_asc\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-sort=\"ascending\" aria-label=\"Name: activate to sort column descending\" style=\"width: 101px;\">Name</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Position: activate to sort column ascending\" style=\"width: 170px;\">Position</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Office: activate to sort column ascending\" style=\"width: 71px;\">Office</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Age: activate to sort column ascending\" style=\"width: 31px;\">Age</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Start date: activate to sort column ascending\" style=\"width: 68px;\">Start date</th><th class=\"sorting\" tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 67px;\">Salary</th></tr>\r\n                                </thead>\r\n                                <tfoot>\r\n                                    <tr><th rowspan=\"1\" colspan=\"1\">Name</th><th rowspan=\"1\" colspan=\"1\">Position</th><th rowspan=\"1\" colspan=\"1\">Office</th><th rowspan=\"1\" colspan=\"1\">Age</th><th rowspan=\"1\" colspan=\"1\">Start date</th><th rowspan=\"1\" colspan=\"1\">Salary</th></tr>\r\n                                </tfoot>\r\n                                <tbody>\r\n                                    <tr role=\"row\" class=\"odd\">\r\n                                        <td class=\"sorting_1\">Airi Satou</td>\r\n                                        <td>Accountant</td>\r\n                                        <td>Tokyo</td>\r\n                                        <td>33</td>\r\n                                        <td>2008/11/28</td>\r\n                                        <td>$162,700</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"even\">\r\n                                        <td class=\"sorting_1\">Angelica Ramos</td>\r\n                                        <td>Chief Executive Officer (CEO)</td>\r\n                                        <td>London</td>\r\n                                        <td>47</td>\r\n                                        <td>2009/10/09</td>\r\n                                        <td>$1,200,000</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"odd\">\r\n                                        <td class=\"sorting_1\">Ashton Cox</td>\r\n                                        <td>Junior Technical Author</td>\r\n                                        <td>San Francisco</td>\r\n                                        <td>66</td>\r\n                                        <td>2009/01/12</td>\r\n                                        <td>$86,000</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"even\">\r\n                                        <td class=\"sorting_1\">Bradley Greer</td>\r\n                                        <td>Software Engineer</td>\r\n                                        <td>London</td>\r\n                                        <td>41</td>\r\n                                        <td>2012/10/13</td>\r\n                                        <td>$132,000</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"odd\">\r\n                                        <td class=\"sorting_1\">Brenden Wagner</td>\r\n                                        <td>Software Engineer</td>\r\n                                        <td>San Francisco</td>\r\n                                        <td>28</td>\r\n                                        <td>2011/06/07</td>\r\n                                        <td>$206,850</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"even\">\r\n                                        <td class=\"sorting_1\">Brielle Williamson</td>\r\n                                        <td>Integration Specialist</td>\r\n                                        <td>New York</td>\r\n                                        <td>61</td>\r\n                                        <td>2012/12/02</td>\r\n                                        <td>$372,000</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"odd\">\r\n                                        <td class=\"sorting_1\">Bruno Nash</td>\r\n                                        <td>Software Engineer</td>\r\n                                        <td>London</td>\r\n                                        <td>38</td>\r\n                                        <td>2011/05/03</td>\r\n                                        <td>$163,500</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"even\">\r\n                                        <td class=\"sorting_1\">Caesar Vance</td>\r\n                                        <td>Pre-Sales Support</td>\r\n                                        <td>New York</td>\r\n                                        <td>21</td>\r\n                                        <td>2011/12/12</td>\r\n                                        <td>$106,450</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"odd\">\r\n                                        <td class=\"sorting_1\">Cara Stevens</td>\r\n                                        <td>Sales Assistant</td>\r\n                                        <td>New York</td>\r\n                                        <td>46</td>\r\n                                        <td>2011/12/06</td>\r\n                                        <td>$145,600</td>\r\n                                    </tr>\r\n                                    <tr role=\"row\" class=\"even\">\r\n                                        <td class=\"sorting_1\">Cedric Kelly</td>\r\n                                        <td>Senior Javascript Developer</td>\r\n                                        <td>Edinburgh</td>\r\n                                        <td>22</td>\r\n                                        <td>2012/03/29</td>\r\n                                        <td>$433,060</td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>");
            __builder.AddMarkupContent(47, @"<div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""dataTable_info"" role=""status"" aria-live=""polite"">Showing 1 to 10 of 57 entries</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""dataTable_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""dataTable_previous""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">Previous</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""dataTable_next""><a href=""#"" aria-controls=""dataTable"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">Next</a></li></ul></div></div></div>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591