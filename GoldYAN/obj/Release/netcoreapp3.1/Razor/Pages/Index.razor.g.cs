#pragma checksum "C:\Users\GuilhermeSimao\source\repos\guigasthepro\2218140_GoldYAN\GoldYAN\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17beb58eaddf6e845b5f6d27454cad611ca2f804"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\">\r\n\r\n\r\n    <div class=\"row\">\r\n\r\n        \r\n        <div class=\"col-xl-3 col-md-6 mb-4\">\r\n            <div class=\"card border-left-primary shadow h-100 py-2\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"row no-gutters align-items-center\">\r\n                        <div class=\"col mr-2\">\r\n                            <div class=\"text-xs font-weight-bold text-primary text-uppercase mb-1\">Earnings (Monthly)</div>\r\n                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">$40,000</div>\r\n                        </div>\r\n                        <div class=\"col-auto\">\r\n                            <i class=\"fas fa-calendar fa-2x text-gray-300\"></i>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        \r\n        <div class=\"col-xl-3 col-md-6 mb-4\">\r\n            <div class=\"card border-left-success shadow h-100 py-2\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"row no-gutters align-items-center\">\r\n                        <div class=\"col mr-2\">\r\n                            <div class=\"text-xs font-weight-bold text-success text-uppercase mb-1\">Earnings (Annual)</div>\r\n                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">$215,000</div>\r\n                        </div>\r\n                        <div class=\"col-auto\">\r\n                            <i class=\"fas fa-dollar-sign fa-2x text-gray-300\"></i>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"col-xl-3 col-md-6 mb-4\">\r\n            <div class=\"card border-left-info shadow h-100 py-2\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"row no-gutters align-items-center\">\r\n                        <div class=\"col mr-2\">\r\n                            <div class=\"text-xs font-weight-bold text-info text-uppercase mb-1\">Tasks</div>\r\n                            <div class=\"row no-gutters align-items-center\">\r\n                                <div class=\"col-auto\">\r\n                                    <div class=\"h5 mb-0 mr-3 font-weight-bold text-gray-800\">50%</div>\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    <div class=\"progress progress-sm mr-2\">\r\n                                        <div class=\"progress-bar bg-info\" role=\"progressbar\" style=\"width: 50%\" aria-valuenow=\"50\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-auto\">\r\n                            <i class=\"fas fa-clipboard-list fa-2x text-gray-300\"></i>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"col-xl-3 col-md-6 mb-4\">\r\n            <div class=\"card border-left-warning shadow h-100 py-2\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"row no-gutters align-items-center\">\r\n                        <div class=\"col mr-2\">\r\n                            <div class=\"text-xs font-weight-bold text-warning text-uppercase mb-1\">Pending Requests</div>\r\n                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">18</div>\r\n                        </div>\r\n                        <div class=\"col-auto\">\r\n                            <i class=\"fas fa-comments fa-2x text-gray-300\"></i>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    \r\n\r\n    <div class=\"row\">\r\n\r\n        \r\n        <div class=\"col-xl-8 col-lg-7\">\r\n            <div class=\"card shadow mb-4\">\r\n                \r\n                <div class=\"card-header py-3 d-flex flex-row align-items-center justify-content-between\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Earnings Overview</h6>\r\n                    <div class=\"dropdown no-arrow\">\r\n                        <a class=\"dropdown-toggle\" href=\"#\" role=\"button\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                            <i class=\"fas fa-ellipsis-v fa-sm fa-fw text-gray-400\"></i>\r\n                        </a>\r\n                        <div class=\"dropdown-menu dropdown-menu-right shadow animated--fade-in\" aria-labelledby=\"dropdownMenuLink\">\r\n                            <div class=\"dropdown-header\">Dropdown Header:</div>\r\n                            <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                            <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                            <div class=\"dropdown-divider\"></div>\r\n                            <a class=\"dropdown-item\" href=\"#\">Something else here</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                \r\n                <div class=\"card-body\">\r\n                    <div class=\"chart-area\">\r\n                        <div class=\"chartjs-size-monitor\"><div class=\"chartjs-size-monitor-expand\"><div class></div></div><div class=\"chartjs-size-monitor-shrink\"><div class></div></div></div>\r\n                        <canvas id=\"myAreaChart\" width=\"620\" height=\"320\" class=\"chartjs-render-monitor\" style=\"display: block; width: 620px; height: 320px;\"></canvas>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"col-xl-4 col-lg-5\">\r\n            <div class=\"card shadow mb-4\">\r\n                \r\n                <div class=\"card-header py-3 d-flex flex-row align-items-center justify-content-between\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Revenue Sources</h6>\r\n                    <div class=\"dropdown no-arrow\">\r\n                        <a class=\"dropdown-toggle\" href=\"#\" role=\"button\" id=\"dropdownMenuLink\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                            <i class=\"fas fa-ellipsis-v fa-sm fa-fw text-gray-400\"></i>\r\n                        </a>\r\n                        <div class=\"dropdown-menu dropdown-menu-right shadow animated--fade-in\" aria-labelledby=\"dropdownMenuLink\">\r\n                            <div class=\"dropdown-header\">Dropdown Header:</div>\r\n                            <a class=\"dropdown-item\" href=\"#\">Action</a>\r\n                            <a class=\"dropdown-item\" href=\"#\">Another action</a>\r\n                            <div class=\"dropdown-divider\"></div>\r\n                            <a class=\"dropdown-item\" href=\"#\">Something else here</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                \r\n                <div class=\"card-body\">\r\n                    <div class=\"chart-pie pt-4 pb-2\">\r\n                        <div class=\"chartjs-size-monitor\"><div class=\"chartjs-size-monitor-expand\"><div class></div></div><div class=\"chartjs-size-monitor-shrink\"><div class></div></div></div>\r\n                        <canvas id=\"myPieChart\" width=\"620\" height=\"245\" class=\"chartjs-render-monitor\" style=\"display: block; width: 620px; height: 245px;\"></canvas>\r\n                    </div>\r\n                    <div class=\"mt-4 text-center small\">\r\n                        <span class=\"mr-2\">\r\n                            <i class=\"fas fa-circle text-primary\"></i> Direct\r\n                        </span>\r\n                        <span class=\"mr-2\">\r\n                            <i class=\"fas fa-circle text-success\"></i> Social\r\n                        </span>\r\n                        <span class=\"mr-2\">\r\n                            <i class=\"fas fa-circle text-info\"></i> Referral\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    \r\n    <div class=\"row\">\r\n\r\n        \r\n        <div class=\"col-lg-6 mb-4\">\r\n\r\n            \r\n            <div class=\"card shadow mb-4\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Projects</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"small font-weight-bold\">Server Migration <span class=\"float-right\">20%</span></h4>\r\n                    <div class=\"progress mb-4\">\r\n                        <div class=\"progress-bar bg-danger\" role=\"progressbar\" style=\"width: 20%\" aria-valuenow=\"20\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                    <h4 class=\"small font-weight-bold\">Sales Tracking <span class=\"float-right\">40%</span></h4>\r\n                    <div class=\"progress mb-4\">\r\n                        <div class=\"progress-bar bg-warning\" role=\"progressbar\" style=\"width: 40%\" aria-valuenow=\"40\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                    <h4 class=\"small font-weight-bold\">Customer Database <span class=\"float-right\">60%</span></h4>\r\n                    <div class=\"progress mb-4\">\r\n                        <div class=\"progress-bar\" role=\"progressbar\" style=\"width: 60%\" aria-valuenow=\"60\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                    <h4 class=\"small font-weight-bold\">Payout Details <span class=\"float-right\">80%</span></h4>\r\n                    <div class=\"progress mb-4\">\r\n                        <div class=\"progress-bar bg-info\" role=\"progressbar\" style=\"width: 80%\" aria-valuenow=\"80\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                    <h4 class=\"small font-weight-bold\">Account Setup <span class=\"float-right\">Complete!</span></h4>\r\n                    <div class=\"progress\">\r\n                        <div class=\"progress-bar bg-success\" role=\"progressbar\" style=\"width: 100%\" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            \r\n            <div class=\"row\">\r\n                <div class=\"col-lg-6 mb-4\">\r\n                    <div class=\"card bg-primary text-white shadow\">\r\n                        <div class=\"card-body\">\r\n                            Primary\r\n                            <div class=\"text-white-50 small\">#4e73df</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 mb-4\">\r\n                    <div class=\"card bg-success text-white shadow\">\r\n                        <div class=\"card-body\">\r\n                            Success\r\n                            <div class=\"text-white-50 small\">#1cc88a</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 mb-4\">\r\n                    <div class=\"card bg-info text-white shadow\">\r\n                        <div class=\"card-body\">\r\n                            Info\r\n                            <div class=\"text-white-50 small\">#36b9cc</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 mb-4\">\r\n                    <div class=\"card bg-warning text-white shadow\">\r\n                        <div class=\"card-body\">\r\n                            Warning\r\n                            <div class=\"text-white-50 small\">#f6c23e</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 mb-4\">\r\n                    <div class=\"card bg-danger text-white shadow\">\r\n                        <div class=\"card-body\">\r\n                            Danger\r\n                            <div class=\"text-white-50 small\">#e74a3b</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 mb-4\">\r\n                    <div class=\"card bg-secondary text-white shadow\">\r\n                        <div class=\"card-body\">\r\n                            Secondary\r\n                            <div class=\"text-white-50 small\">#858796</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-lg-6 mb-4\">\r\n\r\n            \r\n            <div class=\"card shadow mb-4\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Illustrations</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <div class=\"text-center\">\r\n                        <img class=\"img-fluid px-3 px-sm-4 mt-3 mb-4\" style=\"width: 25rem;\" src=\"img/undraw_posting_photo.svg\" alt>\r\n                    </div>\r\n                    <p>Add some quality, svg illustrations to your project courtesy of <a target=\"_blank\" rel=\"nofollow\" href=\"https://undraw.co/\">unDraw</a>, a constantly updated collection of beautiful svg images that you can use completely free and without attribution!</p>\r\n                    <a target=\"_blank\" rel=\"nofollow\" href=\"https://undraw.co/\">Browse Illustrations on unDraw →</a>\r\n                </div>\r\n            </div>\r\n\r\n            \r\n            <div class=\"card shadow mb-4\">\r\n                <div class=\"card-header py-3\">\r\n                    <h6 class=\"m-0 font-weight-bold text-primary\">Development Approach</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p>SB Admin 2 makes extensive use of Bootstrap 4 utility classes in order to reduce CSS bloat and poor page performance. Custom CSS classes are used to create custom components and custom utility classes.</p>\r\n                    <p class=\"mb-0\">Before working with this theme, you should become familiar with the Bootstrap framework, especially the utility classes.</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
