#pragma checksum "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e785db77771f20da2462ba2e359ed22261c5dcd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Create), @"mvc.1.0.view", @"/Views/Book/Create.cshtml")]
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
#line 1 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\_ViewImports.cshtml"
using NS.OBS.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\_ViewImports.cshtml"
using NS.OBS.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e785db77771f20da2462ba2e359ed22261c5dcd0", @"/Views/Book/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726831bb5ad86439ba765156cc30403fc3dd125f", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NS.OBS.Model.BookModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AddBook.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
  using (Html.BeginForm("Create", "Book", FormMethod.Post, new { id = "formAddBook" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"BookName\" class=\"col-md-3 control-label\">BookName </label>\r\n        <div class=\"col-md-9\">\r\n            ");
#nullable restore
#line 12 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
       Write(Html.TextBoxFor(x => x.BookName, "", new { @class = "form-control", placeholder = "BookName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.BookName, "Please enter Book Name", new { @class = "text-danger", style = "display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("     <div class = \"form-group\">\r\n                <b>\r\n               ");
#nullable restore
#line 19 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
          Write(Html.LabelFor(
                  model => model.Category, htmlAttributes: new{
                     @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</b>\r\n               <div class=\"editor-field\">\r\n     ");
#nullable restore
#line 24 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
Write(Html.DropDownListFor(model=>model.Category, new List<SelectListItem>
                   {
                       new SelectListItem{Text="1.Comic", Value="1", Selected=true},
                       new SelectListItem{Text="2.Novel", Value="2", Selected=true},
                       new SelectListItem{Text="3.Sports", Value="3", Selected=true},
                   },"Select Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   </div>\r\n                   </div>\r\n");
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"Author\" class=\"col-md-3 control-label\">Author </label>\r\n        <div class=\"col-md-9\">\r\n            ");
#nullable restore
#line 38 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Author, "", new { @class = "form-control", placeholder = "Author" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 39 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Author, "Please enter Author Name", new { @class = "text-danger", style = "display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"Publisher\" class=\"col-md-3 control-label\">Publisher </label>\r\n        <div class=\"col-md-9\">\r\n            ");
#nullable restore
#line 46 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Publisher, "", new { @class = "form-control", placeholder = "Author" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 47 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Publisher, "Please enter Publisher Name", new { @class = "text-danger", style = "display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"Description\" class=\"col-md-3 control-label\">Description </label>\r\n        <div class=\"col-md-9\">\r\n            ");
#nullable restore
#line 54 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Description, "", new { @class = "form-control", placeholder = "Description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 55 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Description, "Please write Description", new { @class = "text-danger", style = "display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <br>\r\n    <div class=\"form-group\">\r\n        <span id=\"spnMessage\" class=\"text-danger\">");
#nullable restore
#line 62 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
                                             Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span id=\"spnMessage\" class=\"text-success\">");
#nullable restore
#line 63 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
                                              Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        <br />

          <!-- Button -->
        <div class=""col-md-offset-3 col-md-9"">
            <button id=""btn-addBook"" type=""submit"" class=""btn btn-info""><i class=""icon-hand-right""></i> Submit </button>
            <span style=""margin-left:8px;""></span>
        </div>
    </div>
     <div>
         ");
#nullable restore
#line 73 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
    Write(Html.ActionLink("Previous", "ShowBooks"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </div>\r\n");
#nullable restore
#line 75 "D:\Online_book\Online_Book_store\NS.OBS.WEB\Views\Book\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e785db77771f20da2462ba2e359ed22261c5dcd010169", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NS.OBS.Model.BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
