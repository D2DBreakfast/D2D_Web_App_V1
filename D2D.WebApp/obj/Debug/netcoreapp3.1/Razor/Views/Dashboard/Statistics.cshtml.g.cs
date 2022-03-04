#pragma checksum "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Dashboard\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebaf51d98f32fe4f8e78478440566962731e21a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Statistics), @"mvc.1.0.view", @"/Views/Dashboard/Statistics.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebaf51d98f32fe4f8e78478440566962731e21a7", @"/Views/Dashboard/Statistics.cshtml")]
    public class Views_Dashboard_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 4 "D:\Akash D2D code\Akash\D2D\D2D.WebApp\Views\Dashboard\Statistics.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""ms-content-wrapper"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h1 class=""db-header-title"">Welcome, Manager</h1>
        </div>
        <div class=""col-xl-3 col-lg-6 col-md-6"">
            <div class=""ms-card ms-widget has-graph-full-width ms-infographics-widget"">
 <span class=""ms-chart-label bg-black""><i class=""material-icons"">arrow_upward</i> 3.2%</span> 
<div class=""ms-card-body media"">
    <div class=""media-body"">
        <span class=""black-text""><strong>Total Orders</strong></span>
        <h2>50</h2>
    </div>
</div>
 <canvas id=""line-chart""></canvas> 
</div>
</div>
<div class=""col-xl-3 col-lg-6 col-md-6"">
    <div class=""ms-card ms-widget has-graph-full-width ms-infographics-widget"">
 <span class=""ms-chart-label bg-red""><i class=""material-icons"">arrow_downward</i> 4.5%</span> 
<div class=""ms-card-body media"">
    <div class=""media-body"">
        <span class=""black-text""><strong>Total Customers</strong></span>
        <h2>150</h2>
    ");
            WriteLiteral(@"</div>
</div>
 <canvas id=""line-chart-2""></canvas> 
</div>
</div>
<div class=""col-xl-3 col-lg-6 col-md-6"">
    <div class=""ms-card ms-widget has-graph-full-width ms-infographics-widget"">
 <span class=""ms-chart-label bg-black""><i class=""material-icons"">arrow_upward</i> 12.5%</span> 
<div class=""ms-card-body media"">
    <div class=""media-body"">
        <span class=""black-text""><strong>Total Amount</strong></span>
        <h2>7,333</h2>
    </div>
</div>
 <canvas id=""line-chart-3""></canvas> 
</div>
</div>
<div class=""col-xl-3 col-lg-6 col-md-6"">
    <div class=""ms-card ms-widget has-graph-full-width ms-infographics-widget"">
 <span class=""ms-chart-label bg-red""><i class=""material-icons"">arrow_upward</i> 9.5%</span> 
<div class=""ms-card-body media"">
    <div class=""media-body"">
        <span class=""black-text""><strong>Order Delivered</strong></span>
        <h2>200</h2>
    </div>
</div>
 <canvas id=""line-chart-4""></canvas> 
</div>
</div>

<div class=""col-xl-12 col-md-12"">
    <div c");
            WriteLiteral(@"lass=""ms-panel ms-widget ms-crypto-widget"">
        <div class=""ms-panel-header"">
            <h6>Weekly charts</h6>
        </div>
        <div class=""ms-panel-body p-0"">
            <ul class=""nav nav-tabs nav-justified has-gap px-4 pt-4"" role=""tablist"">
                <li role=""presentation"" class=""fs-12""><a href=""#btc"" aria-controls=""btc"" class=""active show"" role=""tab"" data-toggle=""tab""> Sun </a></li>
                <li role=""presentation"" class=""fs-12""><a href=""#xrp"" aria-controls=""xrp"" role=""tab"" data-toggle=""tab""> Mon   </a></li>
                <li role=""presentation"" class=""fs-12""><a href=""#ltc"" aria-controls=""ltc"" role=""tab"" data-toggle=""tab""> Tue </a></li>
                <li role=""presentation"" class=""fs-12""><a href=""#eth"" aria-controls=""eth"" role=""tab"" data-toggle=""tab""> Wed  </a></li>
                <li role=""presentation"" class=""fs-12""><a href=""#zec"" aria-controls=""zec"" role=""tab"" data-toggle=""tab"">  Thu</a></li>
            </ul>
            <div class=""tab-content"">
          ");
            WriteLiteral(@"      <div role=""tabpanel"" class=""tab-pane active show fade in"" id=""btc"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover thead-light"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Item Names</th>
                                    <th scope=""col"">Quantity</th>
                                    <th scope=""col"">Total Orders</th>
                                    <th scope=""col"">Income</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Hunger House</td>
                                    <td>8528</td>
                                    <td class=""ms-text-success"">+17.24%</td>
                                    <td>7.65%</td>
                                </tr>
                                <tr>
          ");
            WriteLiteral(@"                          <td>Food Lounge</td>
                                    <td>4867</td>
                                    <td class=""ms-text-danger"">-12.24%</td>
                                    <td>9.12%</td>
                                </tr>
                                <tr>
                                    <td>Delizious</td>
                                    <td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                                <tr>
                                    <td>Netherfood</td>
                                    <td>1614</td>
                                    <td class=""ms-text-danger"">-20.75%</td>
                                    <td>12.25%</td>
                                </tr>
                                <tr>
                                    <td>Rusmiz</td>
                                    ");
            WriteLiteral(@"<td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div role=""tabpanel"" class=""tab-pane fade"" id=""xrp"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover thead-light"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Restaurant Name</th>
                                    <th scope=""col"">Qty</th>
                                    <th scope=""col"">Orders</th>
                                    <th scope=""col"">Profit</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                             ");
            WriteLiteral(@"       <td>Hunger House</td>
                                    <td>8528</td>
                                    <td class=""ms-text-success"">+17.24%</td>
                                    <td>7.65%</td>
                                </tr>
                                <tr>
                                    <td>Food Lounge</td>
                                    <td>4867</td>
                                    <td class=""ms-text-danger"">-12.24%</td>
                                    <td>9.12%</td>
                                </tr>
                                <tr>
                                    <td>Delizious</td>
                                    <td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                                <tr>
                                    <td>Netherfood</td>
                                    <td>1614</td>");
            WriteLiteral(@"
                                    <td class=""ms-text-danger"">-20.75%</td>
                                    <td>12.25%</td>
                                </tr>
                                <tr>
                                    <td>Rusmiz</td>
                                    <td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div role=""tabpanel"" class=""tab-pane fade"" id=""ltc"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover thead-light"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Restaurant Name</th>
                                    <th scope=""col"">Qty</th>
             ");
            WriteLiteral(@"                       <th scope=""col"">Orders</th>
                                    <th scope=""col"">Profit</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Hunger House</td>
                                    <td>8528</td>
                                    <td class=""ms-text-success"">+17.24%</td>
                                    <td>7.65%</td>
                                </tr>
                                <tr>
                                    <td>Food Lounge</td>
                                    <td>4867</td>
                                    <td class=""ms-text-danger"">-12.24%</td>
                                    <td>9.12%</td>
                                </tr>
                                <tr>
                                    <td>Delizious</td>
                                    <td>7538</td>
                ");
            WriteLiteral(@"                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                                <tr>
                                    <td>Netherfood</td>
                                    <td>1614</td>
                                    <td class=""ms-text-danger"">-20.75%</td>
                                    <td>12.25%</td>
                                </tr>
                                <tr>
                                    <td>Rusmiz</td>
                                    <td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div role=""tabpanel"" class=""tab-pane fade"" id=""eth"">
                    <div class=""table-responsive""");
            WriteLiteral(@">
                        <table class=""table table-hover thead-light"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Restaurant Name</th>
                                    <th scope=""col"">Qty</th>
                                    <th scope=""col"">Orders</th>
                                    <th scope=""col"">Profit</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Hunger House</td>
                                    <td>8528</td>
                                    <td class=""ms-text-success"">+17.24%</td>
                                    <td>7.65%</td>
                                </tr>
                                <tr>
                                    <td>Food Lounge</td>
                                    <td>4867</td>
                               ");
            WriteLiteral(@"     <td class=""ms-text-danger"">-12.24%</td>
                                    <td>9.12%</td>
                                </tr>
                                <tr>
                                    <td>Delizious</td>
                                    <td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                                <tr>
                                    <td>Netherfood</td>
                                    <td>1614</td>
                                    <td class=""ms-text-danger"">-20.75%</td>
                                    <td>12.25%</td>
                                </tr>
                                <tr>
                                    <td>Rusmiz</td>
                                    <td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <");
            WriteLiteral(@"td>14.29%</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div role=""tabpanel"" class=""tab-pane fade"" id=""zec"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover thead-light"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Restaurant Name</th>
                                    <th scope=""col"">Qty</th>
                                    <th scope=""col"">Orders</th>
                                    <th scope=""col"">Profit</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Hunger House</td>
                                    <td>8528</td>
                                    <td class=""ms");
            WriteLiteral(@"-text-success"">+17.24%</td>
                                    <td>7.65%</td>
                                </tr>
                                <tr>
                                    <td>Food Lounge</td>
                                    <td>4867</td>
                                    <td class=""ms-text-danger"">-12.24%</td>
                                    <td>9.12%</td>
                                </tr>
                                <tr>
                                    <td>Delizious</td>
                                    <td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                                <tr>
                                    <td>Netherfood</td>
                                    <td>1614</td>
                                    <td class=""ms-text-danger"">-20.75%</td>
                                    <td>12.25%</td>");
            WriteLiteral(@"
                                </tr>
                                <tr>
                                    <td>Rusmiz</td>
                                    <td>7538</td>
                                    <td class=""ms-text-success"">+32.04%</td>
                                    <td>14.29%</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>

<div class=""col-12"">
    <div class=""ms-panel"">
        <div class=""ms-panel-header"">
            <h6>Recently Placed Orders</h6>
        </div>
        <div class=""ms-panel-body"">
            <div class=""table-responsive"">
                <table class=""table table-hover thead-primary"">
                    <thead>
                        <tr>
                            <th scope=""col"">Order ID</th>
                            <th scope=""col"">Order Name</th>
            ");
            WriteLiteral(@"                <th scope=""col"">Customer Name</th>
                            <th scope=""col"">Location</th>
                            <th scope=""col"">Order Status</th>
                            <th scope=""col"">Delivered Time</th>
                            <th scope=""col"">Price</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">1</th>
                            <td>French Fries</td>
                            <td>Jhon Leo</td>
                            <td>New Town</td>
                            <td>
                                <span class=""badge badge-primary"">Pending</span>
                            </td>
                            <td>10:05</td>
                            <td>$10</td>
                        </tr>
                        <tr>
                            <th scope=""row"">2</th>
                            <td>Mango Pie</td>
              ");
            WriteLiteral(@"              <td>Kristien</td>
                            <td>Old Town</td>
                            <td>
                                <span class=""badge badge-dark"">Cancelled</span>
                            </td>
                            <td>14:05</td>
                            <td>$9</td>
                        </tr>
                        <tr>
                            <th scope=""row"">3</th>
                            <td>FrieD Egg Sandwich</td>
                            <td>Jack Suit</td>
                            <td>Oxford Street</td>
                            <td>
                                <span class=""badge badge-success"">Delivered</span>
                            </td>
                            <td>12:05</td>
                            <td>$19</td>
                        </tr>
                        <tr>
                            <th scope=""row"">4</th>
                            <td>Lemon Yogurt Parfait</td>
                            ");
            WriteLiteral(@"<td>Alesdro Guitto</td>
                            <td>Church hill</td>
                            <td>
                                <span class=""badge badge-success"">Delivered</span>
                            </td>
                            <td>12:05</td>
                            <td>$18</td>
                        </tr>
                        <tr>
                            <th scope=""row"">5</th>
                            <td>Spicy Grill Sandwich</td>
                            <td>Jacob Sahwny</td>
                            <td>palace Road</td>
                            <td>
                                <span class=""badge badge-success"">Delivered</span>
                            </td>
                            <td>12:05</td>
                            <td>$21</td>
                        </tr>
                        <tr>
                            <th scope=""row"">6</th>
                            <td>Chicken Sandwich</td>
                            <t");
            WriteLiteral(@"d>Peter Gill</td>
                            <td>Street 21</td>
                            <td>
                                <span class=""badge badge-primary"">Pending</span>
                            </td>
                            <td>12:05</td>
                            <td>$15</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<div class=""col-md-12"">
            <div class=""ms-panel"">

            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
