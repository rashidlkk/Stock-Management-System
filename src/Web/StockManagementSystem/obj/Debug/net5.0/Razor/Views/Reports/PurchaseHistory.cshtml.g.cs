#pragma checksum "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f63cc19441872cd64615d10ea01aac16c0fdc28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_PurchaseHistory), @"mvc.1.0.view", @"/Views/Reports/PurchaseHistory.cshtml")]
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
#line 1 "E:\LEADS IT\StockManagementSystem\Views\_ViewImports.cshtml"
using StockManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\LEADS IT\StockManagementSystem\Views\_ViewImports.cshtml"
using StockManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f63cc19441872cd64615d10ea01aac16c0fdc28", @"/Views/Reports/PurchaseHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0fb294ee70aca11051a3cc05a73456c6f2024a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_PurchaseHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StockManagementSystem.Models.ViewModel.PurchaseHistoryView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("purchaseHistoryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PurchaseHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
  
    ViewData["Title"] = "PurchaseHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <div class=\"card shadow\">\r\n        <div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">Purchase</h6>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f63cc19441872cd64615d10ea01aac16c0fdc285473", async() => {
                WriteLiteral(@"

                <div class=""form-group row"">
                    <div class=""col-sm-2"">
                        <label for=""dateFrom"">Date from</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input required type=""date"" class=""form-control"" id=""dateFrom"" name=""DateFrom"" placeholder=""DateFrom"">

                    </div>
                    <div class=""col-sm-2"">
                        <input type=""submit"" id=""search"" class=""btn btn-success"" name=""Search"" value=""Search"" />

                    </div>
                    <div class=""col-sm-4"">

                    </div>

                </div>

                <div class=""form-group row"">

                    <div class=""col-sm-2"">
                        <label for=""dateTo"">Date To</label>
                    </div>
                    <div class=""col-sm-4"">
                        <input required type=""date"" class=""form-control"" id=""dateTo"" name=""DateTo"" placeholder=""Date To""");
                WriteLiteral(">\r\n\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>

</div>

<div>
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">All Purchase History</h6>

            <div class=""dropdown no-arrow"" style=""float:right"">
                
                    <select required class=""selectpicker form-select form-select mb-3"" Name=""VendorId"" id=""vendorId"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f63cc19441872cd64615d10ea01aac16c0fdc289025", async() => {
                WriteLiteral("Select Vendor");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                         foreach (var item in ViewBag.Vendors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f63cc19441872cd64615d10ea01aac16c0fdc2811115", async() => {
#nullable restore
#line 61 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                               WriteLiteral(item.VendorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 62 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </select>

            </div>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Purchase Date</th>
                            <th>Vendor Name</th>
                            <th>Category Name</th>
                            <th>Item Name</th>
                            <th>No. of Quantity</th>
                            <th>Unit Price</th>
                            <th>Total Amount<sup>BDT</sup></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 83 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                          
                            int totalQuantity = 0;
                            decimal totalamount = 0;
                            foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                                    <td>");
#nullable restore
#line 90 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                   Write(item.PurchaseDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 91 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                   Write(item.VendorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 92 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 93 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                   Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 94 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 95 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                   Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 96 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                    Write(item.Quantity*item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 99 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                                totalQuantity += item.Quantity;
                                totalamount += (item.Quantity * item.UnitPrice);

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr style=""font-weight: bold;"">
                                <td>Total</td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td>");
#nullable restore
#line 108 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                               Write(totalQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td>");
#nullable restore
#line 110 "E:\LEADS IT\StockManagementSystem\Views\Reports\PurchaseHistory.cshtml"
                               Write(totalamount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" BDT</td>\r\n                            </tr>\r\n");
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#dataTable').DataTable({
                language: {
                    search: ""_INPUT_"",
                    searchPlaceholder: ""Search here""
                },
                dom: 'Bfrtip',
                buttons: [
                    {
                        extend: 'collection',
                        text: 'Export',
                        buttons: [
                            'copy',
                            'excel',
                            'csv',
                            'pdf'
                        ]
                    }
                ],
                ""columnDefs"": [{ targets: [4, 5, 6], className: 'dt-body-right' },
                { targets: [0, 1, 2,3], className: 'dt-body-center' }],
            });

            $('#vendorId').on('change', function () {
                //$(this).closest('form').submit();
                var vendorName = $('#vendorId option:selected').text();

 ");
                WriteLiteral("               var data_table = $(\'#dataTable\').DataTable();\r\n                data_table.columns(1).search(vendorName, true, false).draw();\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StockManagementSystem.Models.ViewModel.PurchaseHistoryView>> Html { get; private set; }
    }
}
#pragma warning restore 1591