#pragma checksum "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d67531423927370e028569e2af1bb31bf5d0d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListPeople), @"mvc.1.0.view", @"/Views/Home/ListPeople.cshtml")]
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
#line 1 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\_ViewImports.cshtml"
using Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\_ViewImports.cshtml"
using Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d67531423927370e028569e2af1bb31bf5d0d8", @"/Views/Home/ListPeople.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6e29cdca57851bf7f56ae3115f4933e1031f6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListPeople : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"bg-info text-white\">All Users</h1>\r\n\r\n<table class=\"table table-sm table-vordered\">\r\n    <tr><th>ID</th><th>Name</th><th>Email</th><th>City</th><th>Country</th></tr>\r\n");
#nullable restore
#line 7 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml"
     foreach (ApplicationUser user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 10 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml"
           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml"
                           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml"
           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml"
           Write(user.CityId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml"
           Write(user.CountryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <!--<td>\r\n                    <a class=\"btn btn-sm btn-primary\" asp-action=\"Update\" asp-route-id=\"user.Id\">Update</a>\r\n                </td>\r\n            -->\r\n        </tr>\r\n");
#nullable restore
#line 20 "F:\Education\Lexicon\Programmering .NET\05 Identity\code\Identity\Views\Home\ListPeople.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
