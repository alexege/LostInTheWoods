#pragma checksum "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbe63fa818d0992c4e9fa2a38a1aa4d662fd0877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\_ViewImports.cshtml"
using LostInTheWoods;

#line default
#line hidden
#line 2 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\_ViewImports.cshtml"
using LostInTheWoods.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe63fa818d0992c4e9fa2a38a1aa4d662fd0877", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9ba960125634dc0fdf3d0e3fb0f83ed2ab9064", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dictionary<string,object>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(87, 431, true);
            WriteLiteral(@"
<h1>Lost in the woods</h1>
<p>List of local hiking trails</p>

<table class=""table table-hover"">
    <thead class=""thead thead-dark"">
        <tr>
            <th>Trail Name</th>
            <th>Description</th>
            <th>Trail Length</th>
            <th>Elevation Change</th>
            <th>Longitude</th>
            <th>Latitude</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
         foreach(var trail in Model)
        {

#line default
#line hidden
            BeginContext(567, 40, true);
            WriteLiteral("            <tr>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 607, "\'", 631, 2);
            WriteAttributeValue("", 614, "view/", 614, 5, true);
#line 26 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
WriteAttributeValue("", 619, trail["id"], 619, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(632, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(634, 13, false);
#line 26 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
                                           Write(trail["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(647, 31, true);
            WriteLiteral("</a></td>\r\n                <td>");
            EndContext();
            BeginContext(679, 20, false);
#line 27 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
               Write(trail["description"]);

#line default
#line hidden
            EndContext();
            BeginContext(699, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(727, 15, false);
#line 28 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
               Write(trail["length"]);

#line default
#line hidden
            EndContext();
            BeginContext(742, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(770, 18, false);
#line 29 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
               Write(trail["elevation"]);

#line default
#line hidden
            EndContext();
            BeginContext(788, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(816, 18, false);
#line 30 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
               Write(trail["longitude"]);

#line default
#line hidden
            EndContext();
            BeginContext(834, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(862, 17, false);
#line 31 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
               Write(trail["latitude"]);

#line default
#line hidden
            EndContext();
            BeginContext(879, 29, true);
            WriteLiteral("</td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 908, "\'", 934, 2);
            WriteAttributeValue("", 915, "delete/", 915, 7, true);
#line 32 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
WriteAttributeValue("", 922, trail["id"], 922, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(935, 54, true);
            WriteLiteral("><button>Delete</button></a></td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "C:\Users\alexe\Documents\CodingDojo\CSharp\MVC\LostInTheWoods\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1000, 69, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/new\"><button>New Trail</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dictionary<string,object>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
