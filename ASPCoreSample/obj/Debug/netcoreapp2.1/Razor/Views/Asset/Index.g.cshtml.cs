#pragma checksum "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52e8e5c2cdf34561bbcc8fa1f5fbf96c8b5092cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asset_Index), @"mvc.1.0.view", @"/Views/Asset/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asset/Index.cshtml", typeof(AspNetCore.Views_Asset_Index))]
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
#line 1 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\_ViewImports.cshtml"
using ASPCoreSample;

#line default
#line hidden
#line 2 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\_ViewImports.cshtml"
using ASPCoreSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52e8e5c2cdf34561bbcc8fa1f5fbf96c8b5092cc", @"/Views/Asset/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f845085478c17c21ccf585a30cbb75e9ac1be715", @"/Views/_ViewImports.cshtml")]
    public class Views_Asset_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPCoreSample.Models.AssetModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Silmek istediğinizden emin misiniz?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
  
    ViewData["Title"] = "Demirbaş";

#line default
#line hidden
            BeginContext(99, 31, true);
            WriteLiteral("\r\n<h2>Demirbaş Listesi</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
 if (@ViewData["department"] != null && @ViewData["department"].Equals("Admin"))
{

#line default
#line hidden
            BeginContext(215, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(232, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ed9bf0c2950438897ccb3751e2b6303", async() => {
                BeginContext(255, 21, true);
                WriteLiteral("Yeni Demirbaş Oluştur");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(280, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
}

#line default
#line hidden
            BeginContext(295, 558, true);
            WriteLiteral(@"    <table class=""table"">
        <tr>
            <th>
                Demirbaş Adı
            </th>

            <th>
                Sayısı
            </th>
            <th>
                Türü
            </th>

            <th>
                Markası
            </th>

            <th>
                 Sahibi
            </th>

            <th>
                Seri Numarası
            </th>

            <th>
                Oda 
            </th>

            <th>
                Geliş Tarihi
            </th>
");
            EndContext();
#line 47 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
             if (@ViewData["department"] != null && @ViewData["department"].Equals("Admin"))
            {

#line default
#line hidden
            BeginContext(962, 27, true);
            WriteLiteral("                <th></th>\r\n");
            EndContext();
#line 50 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1004, 17, true);
            WriteLiteral("        </tr>\r\n\r\n");
            EndContext();
#line 53 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1070, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1119, 45, false);
#line 57 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.depot_name));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1222, 48, false);
#line 61 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.numberofasset));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1326, 44, false);
#line 64 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.type_name));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1428, 45, false);
#line 68 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.brand_name));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1531, 45, false);
#line 72 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.owner_name));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1634, 44, false);
#line 76 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.serial_no));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1736, 44, false);
#line 80 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.room_name));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1838, 51, false);
#line 84 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.acquisition_date));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 23, true);
            WriteLiteral("\r\n            </td>\r\n\r\n");
            EndContext();
#line 87 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
             if (@ViewData["department"] != null && @ViewData["department"].Equals("Admin"))
            {

#line default
#line hidden
            BeginContext(2021, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2063, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f83058b0ffa44feab7890c51ef8dc7b5", async() => {
                BeginContext(2108, 7, true);
                WriteLiteral("Düzenle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2119, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2143, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "297e5d60c56a4bea8be49aa815e9c798", async() => {
                BeginContext(2255, 3, true);
                WriteLiteral("Sil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2262, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 93 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(2304, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 96 "C:\Users\MTR\Desktop\Final Version\Final_Version\ASPCoreSample\Views\Asset\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2330, 14, true);
            WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPCoreSample.Models.AssetModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591