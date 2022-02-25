#pragma checksum "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3238ea5c1901f98863c85ac1375ace462d2279c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_ShowBooks), @"mvc.1.0.view", @"/Views/Book/ShowBooks.cshtml")]
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
#line 1 "D:\tutorials\OBS\NS.OBS.WEB\Views\_ViewImports.cshtml"
using NS.OBS.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tutorials\OBS\NS.OBS.WEB\Views\_ViewImports.cshtml"
using NS.OBS.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
using NS.OBS.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3238ea5c1901f98863c85ac1375ace462d2279c5", @"/Views/Book/ShowBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726831bb5ad86439ba765156cc30403fc3dd125f", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_ShowBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NS.OBS.Model.BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h2>Book Details</h2>
<hr />
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">BookID</th>
            <th scope=""col"">BookName</th>
            <th scope=""col"">Category</th>
            <th scope=""col"">Author</th>
            <th scope=""col"">Publisher</th>
            <th scope=""col"">Description</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
           Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
           Write(item.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
           Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
           Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
           Write(item.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
           Write(Html.ActionLink("EditBook", "EditBook", new { Id = @item.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"
           Write(Html.ActionLink("DeleteBook", "DeleteBook", new { id = @item.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            \r\n        </tr>\r\n");
#nullable restore
#line 33 "D:\tutorials\OBS\NS.OBS.WEB\Views\Book\ShowBooks.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NS.OBS.Model.BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
