#pragma checksum "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e425afc6771351b49725723cb9910b2a613cf91d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BankManagementSystem.Web.Views.Credit.Pages_Credit_Index), @"mvc.1.0.razor-page", @"/Pages/Credit/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Credit/Index.cshtml", typeof(BankManagementSystem.Web.Views.Credit.Pages_Credit_Index), null)]
namespace BankManagementSystem.Web.Views.Credit
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Web;

#line default
#line hidden
#line 2 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Models;

#line default
#line hidden
#line 3 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Services;

#line default
#line hidden
#line 4 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Services.DataServices;

#line default
#line hidden
#line 5 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Web.Pages.Deposit;

#line default
#line hidden
#line 6 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Common.Constants;

#line default
#line hidden
#line 7 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Common.BindingModels.Deposit;

#line default
#line hidden
#line 8 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Common.ViewModels.CreditCard;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e425afc6771351b49725723cb9910b2a613cf91d", @"/Pages/Credit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1b8b3f4d2a9e0fb4f0098f64f5c926eaffd070", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Credit_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
  
    ViewData["Title"] = "Credits";

#line default
#line hidden
            BeginContext(109, 35, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>");
            EndContext();
            BeginContext(145, 17, false);
#line 9 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(162, 32, true);
            WriteLiteral("</h1>\r\n    <hr class=\"hr-2\" />\r\n");
            EndContext();
#line 11 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
     if (Model.ViewModels.Count() > 0)
    {

#line default
#line hidden
            BeginContext(241, 370, true);
            WriteLiteral(@"        <table class=""table table-hover table-striped table-bordered"">
            <thead>
                <tr>
                    <th>Financial Resource Amount</th>
                    <th>Payment Period</th>
                    <th>Percent Interest</th>
                    <th>Total Debt</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                 foreach (var credit in Model.ViewModels)
                {

#line default
#line hidden
            BeginContext(689, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(744, 30, false);
#line 26 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                       Write(credit.FinancialResourceAmount);

#line default
#line hidden
            EndContext();
            BeginContext(774, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(810, 20, false);
#line 27 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                       Write(credit.PaymentPeriod);

#line default
#line hidden
            EndContext();
            BeginContext(830, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(866, 22, false);
#line 28 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                       Write(credit.PercentInterest);

#line default
#line hidden
            EndContext();
            BeginContext(888, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(955, 67, false);
#line 30 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                        Write(credit.FinancialResourceAmount * (1 + credit.PercentInterest / 100));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 33 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1102, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 36 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1166, 71, true);
            WriteLiteral("        <h4><i>You do not have any active credits currently.</i></h4>\r\n");
            EndContext();
#line 40 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1244, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankManagementSystem.Web.Pages.Credit.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BankManagementSystem.Web.Pages.Credit.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BankManagementSystem.Web.Pages.Credit.IndexModel>)PageContext?.ViewData;
        public BankManagementSystem.Web.Pages.Credit.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
