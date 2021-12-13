#pragma checksum "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ec6affd56fbf2b3ad3c5087c455ec30955f7b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#nullable restore
#line 1 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\_ViewImports.cshtml"
using ChannelEngine.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\_ViewImports.cshtml"
using ChannelEngine.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\_ViewImports.cshtml"
using ChannelEngine.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\_ViewImports.cshtml"
using ChannelEngine.Core.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\_ViewImports.cshtml"
using ChannelEngine.Core.Models.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ec6affd56fbf2b3ad3c5087c455ec30955f7b7", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be798be75caf54eb7e050905a30c091881e9e635", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-3"">
    <h2>ORDER LIST</h2>
    <hr />
    <div class=""row"">
        <div class=""col"">
            <table class=""table table-bordered table-striped"">
                <thead>
                    <tr>
                        <th>Channel Id</th>
                        <th>Channel Name</th>
                        <th>Channel Order No</th>
                        <th>Order Date</th>
                        <th>Payment Method</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                     foreach (var item in Model.Orders)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 27 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.ChannelId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 30 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.ChannelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 33 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.ChannelOrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 36 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 39 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 42 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>


<div class=""container mt-3"">
    <h2>TOP 5 PRODUCT LIST</h2>
    <hr />
    <div class=""row"">
        <div class=""col"">
            <table class=""table table-bordered table-striped"">
                <thead>
                    <tr>
                        <th>Merchant Product No</th>
                        <th>Product Name</th>
                        <th>Channel Product No</th>
                        <th>Gtin</th>
                        <th>Total Quantity</th>
                        <th>#</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 67 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 71 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.MerchantProductNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 74 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 77 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.ChannelProductNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 80 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.Gtin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 83 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2897, "\"", 2960, 2);
            WriteAttributeValue("", 2904, "/Order/UpdateProductStockOnOrder/", 2904, 33, true);
#nullable restore
#line 86 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
WriteAttributeValue("", 2937, item.MerchantProductNo, 2937, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   onclick=""return confirm('Are you sure want to update this product stock to 25?')""
                                   class=""btn btn-warning btn-sm"" title=""Update Stock to 25"">
                                    <b> Update Stock to 25</b>
                                </a>
                            </td>
                        </tr>
");
#nullable restore
#line 93 "C:\ChannelEngine\ChannelEngine\ChannelEngine.Web\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
