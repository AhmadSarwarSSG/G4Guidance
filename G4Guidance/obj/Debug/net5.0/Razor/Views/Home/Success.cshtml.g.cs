#pragma checksum "E:\VS_Projects\G4 Guidance\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a273a6377ef4f0b5bb363a53f92557a2341bcb72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#line 1 "E:\VS_Projects\G4 Guidance\Views\_ViewImports.cshtml"
using G4_Guidance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\VS_Projects\G4 Guidance\Views\Home\Success.cshtml"
using G4_Guidance.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a273a6377ef4f0b5bb363a53f92557a2341bcb72", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b2a6c76558490c09229d9bc40553d993d8042ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<G4_Guidance.Models.User_Data>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "E:\VS_Projects\G4 Guidance\Views\Home\Success.cshtml"
  
    ViewData["Title"] = "Success";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:lawngreen\">Login Succeed</h1>\r\n<h2 style=\"color:deepskyblue\">Welcome to G4 Guidance</h2>\r\n<hr style=\"color:blueviolet\"/>\r\n<h3>");
#nullable restore
#line 14 "E:\VS_Projects\G4 Guidance\Views\Home\Success.cshtml"
Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 15 "E:\VS_Projects\G4 Guidance\Views\Home\Success.cshtml"
Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<G4_Guidance.Models.User_Data> Html { get; private set; }
    }
}
#pragma warning restore 1591
