#pragma checksum "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2007b4752ec1b818bcfb3d112ec39e287d7b1ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2007b4752ec1b818bcfb3d112ec39e287d7b1ba", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b4ad4efaa63930a06421e37942e07053b042d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WORLD_OF_DUEL_MASTERS.Models.DMCard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(130, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(159, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2007b4752ec1b818bcfb3d112ec39e287d7b1ba4774", async() => {
                BeginContext(182, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(196, 110, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(307, 40, false);
#line 17 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(347, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(403, 48, false);
#line 20 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Civilization));

#line default
#line hidden
            EndContext();
            BeginContext(451, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(507, 40, false);
#line 23 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(547, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(603, 40, false);
#line 26 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(643, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(701, 40, false);
#line 30 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(741, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(797, 41, false);
#line 33 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(838, 65, true);
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(935, 66, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1002, 39, false);
#line 42 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 45 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                 if (item.Civilization != "" && item.Civilization != null)
                {
                    

#line default
#line hidden
            BeginContext(1196, 47, false);
#line 47 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilization));

#line default
#line hidden
            EndContext();
#line 47 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                                                                    
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1326, 49, false);
#line 51 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilizations0));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 40, true);
            WriteLiteral("                    <a>&#47;<br /></a>\r\n");
            EndContext();
            BeginContext(1438, 49, false);
#line 53 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilizations1));

#line default
#line hidden
            EndContext();
#line 53 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                                                                      
                }

#line default
#line hidden
            BeginContext(1508, 57, true);
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1566, 39, false);
#line 59 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1661, 39, false);
#line 62 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 41, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n");
            EndContext();
#line 66 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                 if (item.Race != "" && item.Race != null)
                {
                    

#line default
#line hidden
            BeginContext(1841, 39, false);
#line 68 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Race));

#line default
#line hidden
            EndContext();
#line 68 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                                                            
                }
                else
                {
                    if (item.Races0 != "" && item.Races1 != null)
                    {
                        

#line default
#line hidden
            BeginContext(2057, 41, false);
#line 74 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Races0));

#line default
#line hidden
            EndContext();
            BeginContext(2100, 44, true);
            WriteLiteral("                        <a>&#47;<br /></a>\r\n");
            EndContext();
            BeginContext(2169, 41, false);
#line 76 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Races1));

#line default
#line hidden
            EndContext();
#line 76 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                                                                  
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2284, 34, true);
            WriteLiteral("                        <a>-</a>\r\n");
            EndContext();
#line 81 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(2362, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2416, 40, false);
#line 86 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(2456, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2511, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2007b4752ec1b818bcfb3d112ec39e287d7b1ba14863", async() => {
                BeginContext(2560, 4, true);
                WriteLiteral("Edit");
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
#line 89 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                                       WriteLiteral(item.CardID);

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
            BeginContext(2568, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2588, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2007b4752ec1b818bcfb3d112ec39e287d7b1ba17214", async() => {
                BeginContext(2640, 7, true);
                WriteLiteral("Details");
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
#line 90 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                                          WriteLiteral(item.CardID);

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
            BeginContext(2651, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2671, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2007b4752ec1b818bcfb3d112ec39e287d7b1ba19571", async() => {
                BeginContext(2722, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
                                         WriteLiteral(item.CardID);

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
            BeginContext(2732, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 94 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\Admin\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2771, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WORLD_OF_DUEL_MASTERS.Models.DMCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591