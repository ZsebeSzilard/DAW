#pragma checksum "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e659a536f1462c0c49ec5910ca09dcdaed2c8900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DMCards_Delete), @"mvc.1.0.view", @"/Views/DMCards/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DMCards/Delete.cshtml", typeof(AspNetCore.Views_DMCards_Delete))]
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
#line 1 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\_ViewImports.cshtml"
using WORLD_OF_DUEL_MASTERS;

#line default
#line hidden
#line 2 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\_ViewImports.cshtml"
using WORLD_OF_DUEL_MASTERS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e659a536f1462c0c49ec5910ca09dcdaed2c8900", @"/Views/DMCards/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b4ad4efaa63930a06421e37942e07053b042d9", @"/Views/_ViewImports.cshtml")]
    public class Views_DMCards_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WORLD_OF_DUEL_MASTERS.Models.DMCard>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 176, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>DMCard</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(265, 40, false);
#line 15 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(305, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(369, 36, false);
#line 18 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(405, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(468, 39, false);
#line 21 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Set));

#line default
#line hidden
            EndContext();
            BeginContext(507, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(571, 35, false);
#line 24 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Set));

#line default
#line hidden
            EndContext();
            BeginContext(606, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(669, 38, false);
#line 27 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(707, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(771, 34, false);
#line 30 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(805, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(868, 48, false);
#line 33 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Civilization));

#line default
#line hidden
            EndContext();
            BeginContext(916, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(980, 44, false);
#line 36 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Civilization));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1087, 42, false);
#line 39 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Rarity));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1193, 38, false);
#line 42 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Rarity));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1294, 40, false);
#line 45 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1398, 36, false);
#line 48 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1497, 40, false);
#line 51 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1601, 36, false);
#line 54 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1700, 40, false);
#line 57 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1804, 36, false);
#line 60 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1903, 42, false);
#line 63 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Flavor));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2009, 38, false);
#line 66 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Flavor));

#line default
#line hidden
            EndContext();
            BeginContext(2047, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2110, 47, false);
#line 69 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Illustrator));

#line default
#line hidden
            EndContext();
            BeginContext(2157, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2221, 43, false);
#line 72 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Illustrator));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2327, 40, false);
#line 75 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(2367, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2431, 36, false);
#line 78 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(2467, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2530, 41, false);
#line 81 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(2571, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2635, 37, false);
#line 84 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2735, 42, false);
#line 87 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Races0));

#line default
#line hidden
            EndContext();
            BeginContext(2777, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2841, 38, false);
#line 90 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Races0));

#line default
#line hidden
            EndContext();
            BeginContext(2879, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2942, 42, false);
#line 93 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Races1));

#line default
#line hidden
            EndContext();
            BeginContext(2984, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3048, 38, false);
#line 96 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Races1));

#line default
#line hidden
            EndContext();
            BeginContext(3086, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3149, 50, false);
#line 99 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Civilizations0));

#line default
#line hidden
            EndContext();
            BeginContext(3199, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3263, 46, false);
#line 102 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Civilizations0));

#line default
#line hidden
            EndContext();
            BeginContext(3309, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3372, 50, false);
#line 105 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Civilizations1));

#line default
#line hidden
            EndContext();
            BeginContext(3422, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3486, 46, false);
#line 108 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Civilizations1));

#line default
#line hidden
            EndContext();
            BeginContext(3532, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3570, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e659a536f1462c0c49ec5910ca09dcdaed2c890018654", async() => {
                BeginContext(3596, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3606, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e659a536f1462c0c49ec5910ca09dcdaed2c890019047", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 113 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\DMCards\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CardID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3646, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3729, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e659a536f1462c0c49ec5910ca09dcdaed2c890020962", async() => {
                    BeginContext(3751, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3767, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3780, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WORLD_OF_DUEL_MASTERS.Models.DMCard> Html { get; private set; }
    }
}
#pragma warning restore 1591
