#pragma checksum "/Users/talnoznisky/Desktop/coding-temple/SandwichShop/Views/Shop/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67367505d8c0267bf120a6205b92a1a95ead9649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Index.cshtml", typeof(AspNetCore.Views_Shop_Index))]
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
#line 1 "/Users/talnoznisky/Desktop/coding-temple/SandwichShop/Views/_ViewImports.cshtml"
using SandwichShop;

#line default
#line hidden
#line 2 "/Users/talnoznisky/Desktop/coding-temple/SandwichShop/Views/_ViewImports.cshtml"
using SandwichShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67367505d8c0267bf120a6205b92a1a95ead9649", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9751bbf9a2d806c2b4026efe97159fe4e292bfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SandwichShop.Data.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/talnoznisky/Desktop/coding-temple/SandwichShop/Views/Shop/Index.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
            BeginContext(88, 29, true);
            WriteLiteral("    <div class=\"row-fluid\">\r\n");
            EndContext();
#line 6 "/Users/talnoznisky/Desktop/coding-temple/SandwichShop/Views/Shop/Index.cshtml"
     foreach (var category in this.Model)
    {

#line default
#line hidden
            BeginContext(167, 45, true);
            WriteLiteral("        <div class=\"col-4\">\r\n            <h2>");
            EndContext();
            BeginContext(213, 13, false);
#line 9 "/Users/talnoznisky/Desktop/coding-temple/SandwichShop/Views/Shop/Index.cshtml"
           Write(category.Type);

#line default
#line hidden
            EndContext();
            BeginContext(226, 23, true);
            WriteLiteral("</h2>\r\n            <h3>");
            EndContext();
            BeginContext(250, 20, false);
#line 10 "/Users/talnoznisky/Desktop/coding-temple/SandwichShop/Views/Shop/Index.cshtml"
           Write(category.Description);

#line default
#line hidden
            EndContext();
            BeginContext(270, 23, true);
            WriteLiteral("</h3>\r\n        </div>\r\n");
            EndContext();
#line 12 "/Users/talnoznisky/Desktop/coding-temple/SandwichShop/Views/Shop/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(300, 12, true);
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SandwichShop.Data.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
