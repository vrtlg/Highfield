#pragma checksum "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "169314b733134eb0be78a09d73281ead898677f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/_ViewImports.cshtml"
using Highfield;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/_ViewImports.cshtml"
using Highfield.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169314b733134eb0be78a09d73281ead898677f2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d9c9a5b3e2ded264e29cc59aa34a429a0b8723", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Highfield.Models.Response>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Hire Vev</h1>

<hr/>
<h1>UserEntity</h1>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Email</th>
                <th>DOB</th>
                <th>Fav. Colour</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
             foreach(var u in @Model.users){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
           Write(u.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
               Write(u.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
               Write(u.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
               Write(u.dob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
               Write(u.favouriteColour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    
    <hr/>
<h1>AgePlusTwenty</h1>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>User Id</th>
                <th>Age</th>
                <th>Age+20</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
             foreach(var u in @Model.ages){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 47 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
                   Write(u.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
                   Write(u.originalAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
                   Write(u.agePlusTwenty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <hr/>
    <h1>TopColours</h1>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Colour</th>
                <th>Count</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 64 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
             foreach (var u in @Model.topColours)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 67 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
                   Write(u.colour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
                   Write(u.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 70 "/Users/vev/Documents/WEB/Csharp/gradebook/Highfield/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Highfield.Models.Response> Html { get; private set; }
    }
}
#pragma warning restore 1591
