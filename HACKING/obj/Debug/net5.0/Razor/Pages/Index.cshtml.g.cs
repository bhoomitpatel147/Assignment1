#pragma checksum "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc419f3ab8a282c889bb9bb2ea3c5b0703219df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HACKING.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace HACKING.Pages
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
#line 1 "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/_ViewImports.cshtml"
using HACKING;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc419f3ab8a282c889bb9bb2ea3c5b0703219df", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ffdac20185dbacb689e141ff554624acd1b3e5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>5 Common Hacking Techniques: </p>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/Index.cshtml"
  
    var hackingTech = new [] {
        new {
            name = "Social Engineering & Phishing",
            learningLvl = "Easy",
            popularityRate = 9
        },
        new {
            name = "Malware-Injecting Devices",
            learningLvl = "Intermediate",
            popularityRate = 10
        },
        new {
            name = "Missing Security Patches",
            learningLvl = "Hard",
            popularityRate = 7
        },
        new {
            name = "Cracking Passwords",
            learningLvl  = "Easy",
            popularityRate = 5
        },
        new {
            name = "Distributed Denial-of-Service (DDoS)",
            learningLvl = "Intermediate",
            popularityRate = 9 
        }
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 43 "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/Index.cshtml"
 for (var i = 0; i < hackingTech.Length; i++)
{
    var tech = hackingTech[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral(" Technique name: <b>");
#nullable restore
#line 46 "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/Index.cshtml"
                         Write(tech.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <br/>");
            WriteLiteral("\r\n");
            WriteLiteral(" Learning Level: ");
#nullable restore
#line 47 "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/Index.cshtml"
                      Write(tech.learningLvl);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>");
            WriteLiteral("     \r\n");
            WriteLiteral(" Popularity Rate: ");
#nullable restore
#line 48 "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/Index.cshtml"
                       Write(tech.popularityRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>");
            WriteLiteral("  <!-- Rate is out of 10 -->\r\n");
#nullable restore
#line 49 "/Users/kevinmitnick/Desktop/Assignment1/HACKING/Pages/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
