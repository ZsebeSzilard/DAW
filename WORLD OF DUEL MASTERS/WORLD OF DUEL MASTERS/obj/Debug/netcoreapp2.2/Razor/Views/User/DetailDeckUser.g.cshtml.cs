#pragma checksum "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73a0330acc47ff75c55626924e7001f1da1a5f8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DetailDeckUser), @"mvc.1.0.view", @"/Views/User/DetailDeckUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/DetailDeckUser.cshtml", typeof(AspNetCore.Views_User_DetailDeckUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73a0330acc47ff75c55626924e7001f1da1a5f8f", @"/Views/User/DetailDeckUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b4ad4efaa63930a06421e37942e07053b042d9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DetailDeckUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WORLD_OF_DUEL_MASTERS.Models.Card>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
  
    ViewData["Title"] = "ShowDeckUser";
    Layout = "_UserLayout";

#line default
#line hidden
            BeginContext(134, 36, true);
            WriteLiteral("\r\n<h1>ShowDeckUser</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(170, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73a0330acc47ff75c55626924e7001f1da1a5f8f4249", async() => {
                BeginContext(193, 10, true);
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
            BeginContext(207, 110, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(318, 40, false);
#line 17 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(358, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(414, 48, false);
#line 20 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Civilization));

#line default
#line hidden
            EndContext();
            BeginContext(462, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(518, 40, false);
#line 23 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(558, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(614, 40, false);
#line 26 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(654, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(712, 40, false);
#line 30 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(752, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(808, 41, false);
#line 33 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(849, 65, true);
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(946, 66, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1013, 39, false);
#line 42 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 45 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                 if (item.Civilization != "" && item.Civilization != null)
                {
                    

#line default
#line hidden
            BeginContext(1207, 47, false);
#line 47 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilization));

#line default
#line hidden
            EndContext();
#line 47 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                                                                    
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1337, 49, false);
#line 51 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilizations0));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 40, true);
            WriteLiteral("                    <a>&#47;<br /></a>\r\n");
            EndContext();
            BeginContext(1449, 49, false);
#line 53 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilizations1));

#line default
#line hidden
            EndContext();
#line 53 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                                                                      
                }

#line default
#line hidden
            BeginContext(1519, 57, true);
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1577, 39, false);
#line 59 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1672, 39, false);
#line 62 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 41, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n");
            EndContext();
#line 66 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                 if (item.Race != "" && item.Race != null)
                {
                    

#line default
#line hidden
            BeginContext(1852, 39, false);
#line 68 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Race));

#line default
#line hidden
            EndContext();
#line 68 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                                                            
                }
                else
                {
                    if (item.Races0 != "" && item.Races1 != null)
                    {
                        

#line default
#line hidden
            BeginContext(2068, 41, false);
#line 74 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Races0));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 44, true);
            WriteLiteral("                        <a>&#47;<br /></a>\r\n");
            EndContext();
            BeginContext(2180, 41, false);
#line 76 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Races1));

#line default
#line hidden
            EndContext();
#line 76 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                                                                  
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2295, 34, true);
            WriteLiteral("                        <a>-</a>\r\n");
            EndContext();
#line 81 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(2373, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2427, 40, false);
#line 86 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(2467, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2524, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73a0330acc47ff75c55626924e7001f1da1a5f8f14534", async() => {
                BeginContext(2576, 7, true);
                WriteLiteral("Details");
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
#line 90 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
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
            BeginContext(2587, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 93 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\DetailDeckUser.cshtml"
}

#line default
#line hidden
            BeginContext(2626, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WORLD_OF_DUEL_MASTERS.Models.Card>> Html { get; private set; }
    }
}
#pragma warning restore 1591
