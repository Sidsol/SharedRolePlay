#pragma checksum "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b51b65ccb096441ee2aee7c10978cd7571dd940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stories_Index), @"mvc.1.0.view", @"/Views/Stories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stories/Index.cshtml", typeof(AspNetCore.Views_Stories_Index))]
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
#line 1 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\_ViewImports.cshtml"
using SharedRoleplay;

#line default
#line hidden
#line 2 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\_ViewImports.cshtml"
using SharedRoleplay.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b51b65ccb096441ee2aee7c10978cd7571dd940", @"/Views/Stories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8c60fae9b976c7a324a4e90664cd8c02908a102", @"/Views/_ViewImports.cshtml")]
    public class Views_Stories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SharedRoleplay.Models.Story>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
  
    ViewData["Title"] = "Stories";

#line default
#line hidden
            BeginContext(94, 31, true);
            WriteLiteral("\r\n<h1>Stories</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b51b65ccb096441ee2aee7c10978cd7571dd9403879", async() => {
                BeginContext(148, 16, true);
                WriteLiteral("Create New Story");
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
            BeginContext(168, 114, true);
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"container-fluid\" style=\"overflow-x:scroll\">\r\n    <div class=\"row justify-content-center\" >\r\n");
            EndContext();
#line 15 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(331, 80, true);
            WriteLiteral("                <div class=\"card\" style=\"width: 18rem;\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 411, "\"", 443, 2);
            WriteAttributeValue("", 418, "/stories/details/", 418, 17, true);
#line 18 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
WriteAttributeValue("", 435, item.ID, 435, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(444, 201, true);
            WriteLiteral("><img src=\"https://via.placeholder.com/150.png?text=Place+holder+photo\" class=\"card-img-top\" alt=\"...\"></a>\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(646, 40, false);
#line 20 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(686, 52, true);
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(739, 40, false);
#line 21 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(779, 56, true);
            WriteLiteral("</p>\r\n                        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 835, "\"", 867, 2);
            WriteAttributeValue("", 842, "/stories/details/", 842, 17, true);
#line 22 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
WriteAttributeValue("", 859, item.ID, 859, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(868, 75, true);
            WriteLiteral(" role=\"button\">Details</a>\r\n                        <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 943, "\"", 972, 2);
            WriteAttributeValue("", 950, "/stories/edit/", 950, 14, true);
#line 23 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
WriteAttributeValue("", 964, item.ID, 964, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(973, 74, true);
            WriteLiteral(" role=\"button\">Edit</a>\r\n                        <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1078, 2);
            WriteAttributeValue("", 1054, "/stories/delete/", 1054, 16, true);
#line 24 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
WriteAttributeValue("", 1070, item.ID, 1070, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1079, 79, true);
            WriteLiteral(" role=\"button\">Delete</a>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 27 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Stories\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1169, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SharedRoleplay.Models.Story>> Html { get; private set; }
    }
}
#pragma warning restore 1591
