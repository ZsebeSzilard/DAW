#pragma checksum "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afc542c411ea304abbf5e13c529037c5360840c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditDeckUser), @"mvc.1.0.view", @"/Views/User/EditDeckUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/EditDeckUser.cshtml", typeof(AspNetCore.Views_User_EditDeckUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc542c411ea304abbf5e13c529037c5360840c0", @"/Views/User/EditDeckUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b4ad4efaa63930a06421e37942e07053b042d9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_EditDeckUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WORLD_OF_DUEL_MASTERS.Models.Card>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CardDetailsUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
  
    ViewData["Title"] = "EditDeckUser";
    Layout = "_UserLayout";

#line default
#line hidden
            BeginContext(134, 171, true);
            WriteLiteral("    <br />\r\n<h1 class=\"text-center\">Edit Your Deck</h1>\r\n<br />\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(306, 40, false);
#line 16 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(346, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(402, 48, false);
#line 19 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Civilization));

#line default
#line hidden
            EndContext();
            BeginContext(450, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(506, 40, false);
#line 22 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(546, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(602, 40, false);
#line 25 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(642, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(700, 40, false);
#line 29 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(740, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(796, 41, false);
#line 32 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(837, 59, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                    ");
            EndContext();
            BeginContext(896, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc542c411ea304abbf5e13c529037c5360840c07244", async() => {
                BeginContext(920, 8, true);
                WriteLiteral("Add Card");
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
            BeginContext(932, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1044, 66, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-left\">\r\n                ");
            EndContext();
            BeginContext(1111, 39, false);
#line 44 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 47 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                 if (item.Civilization != "" && item.Civilization != null)
                {
                    

#line default
#line hidden
            BeginContext(1305, 47, false);
#line 49 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilization));

#line default
#line hidden
            EndContext();
#line 49 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                                                                    
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1435, 49, false);
#line 53 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilizations0));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 40, true);
            WriteLiteral("                    <a>&#47;<br /></a>\r\n");
            EndContext();
            BeginContext(1547, 49, false);
#line 55 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Civilizations1));

#line default
#line hidden
            EndContext();
#line 55 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                                                                      
                }

#line default
#line hidden
            BeginContext(1617, 57, true);
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1675, 39, false);
#line 61 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1770, 39, false);
#line 64 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 41, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n");
            EndContext();
#line 68 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                 if (item.Race != "" && item.Race != null)
                {
                    

#line default
#line hidden
            BeginContext(1950, 39, false);
#line 70 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
               Write(Html.DisplayFor(modelItem => item.Race));

#line default
#line hidden
            EndContext();
#line 70 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                                                            
                }
                else
                {
                    if (item.Races0 != "" && item.Races1 != null)
                    {
                        

#line default
#line hidden
            BeginContext(2166, 41, false);
#line 76 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Races0));

#line default
#line hidden
            EndContext();
            BeginContext(2209, 44, true);
            WriteLiteral("                        <a>&#47;<br /></a>\r\n");
            EndContext();
            BeginContext(2278, 41, false);
#line 78 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Races1));

#line default
#line hidden
            EndContext();
#line 78 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                                                                  
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2393, 34, true);
            WriteLiteral("                        <a>-</a>\r\n");
            EndContext();
#line 83 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(2471, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2525, 40, false);
#line 88 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
            EndContext();
            BeginContext(2565, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2620, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc542c411ea304abbf5e13c529037c5360840c014877", async() => {
                BeginContext(2680, 12, true);
                WriteLiteral("More details");
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
#line 91 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
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
            BeginContext(2696, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2716, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afc542c411ea304abbf5e13c529037c5360840c017254", async() => {
                BeginContext(2767, 6, true);
                WriteLiteral("Delete");
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
#line 92 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
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
            BeginContext(2777, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 95 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\EditDeckUser.cshtml"
        }

#line default
#line hidden
            BeginContext(2824, 24, true);
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
