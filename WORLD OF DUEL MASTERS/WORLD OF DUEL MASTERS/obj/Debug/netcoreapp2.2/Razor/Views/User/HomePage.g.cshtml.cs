#pragma checksum "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b7468e9b87b9dad0516b2a2d2cb4ce5a20509b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_HomePage), @"mvc.1.0.view", @"/Views/User/HomePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/HomePage.cshtml", typeof(AspNetCore.Views_User_HomePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b7468e9b87b9dad0516b2a2d2cb4ce5a20509b", @"/Views/User/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b4ad4efaa63930a06421e37942e07053b042d9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\HomePage.cshtml"
  
    ViewData["Title"] = "UserDashBoard";
    Layout = "_UserLayout";

#line default
#line hidden
            BeginContext(80, 36, true);
            WriteLiteral("\r\n\r\n<h1 class=\"text-center\">Welcome ");
            EndContext();
            BeginContext(117, 15, false);
#line 8 "D:\PROIECTE\WORLD OF DUEL MASTERS\WORLD OF DUEL MASTERS\Views\User\HomePage.cshtml"
                           Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(132, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
