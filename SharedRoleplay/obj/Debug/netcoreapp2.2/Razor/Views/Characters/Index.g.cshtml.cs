#pragma checksum "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c61fa367277f649f04cced73ad6df199387950c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters_Index), @"mvc.1.0.view", @"/Views/Characters/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Characters/Index.cshtml", typeof(AspNetCore.Views_Characters_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c61fa367277f649f04cced73ad6df199387950c3", @"/Views/Characters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8c60fae9b976c7a324a4e90664cd8c02908a102", @"/Views/_ViewImports.cshtml")]
    public class Views_Characters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SharedRoleplay.Models.Character>>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 34, true);
            WriteLiteral("\r\n<h1>Characters</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(130, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c61fa367277f649f04cced73ad6df199387950c33908", async() => {
                BeginContext(153, 20, true);
                WriteLiteral("Create New Character");
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
            BeginContext(177, 124, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(302, 40, false);
#line 16 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(342, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(422, 38, false);
#line 19 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(460, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(540, 42, false);
#line 22 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(582, 148, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <tr>\r\n");
            EndContext();
#line 29 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(803, 390, true);
            WriteLiteral(@"                        <td>
                            <div class=""card"" style=""width: 18rem;"">
                                <a href=""https://placeholder.com""><img src=""https://via.placeholder.com/150.png?text=Place+holder+photo"" class=""card-img-top"" alt=""...""></a>
                                <div class=""card-body"">
                                    <h5 class=""card-title"">");
            EndContext();
            BeginContext(1194, 39, false);
#line 35 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 64, true);
            WriteLiteral("</h5>\r\n                                    <p class=\"card-text\">");
            EndContext();
            BeginContext(1298, 44, false);
#line 36 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.BackStory));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 68, true);
            WriteLiteral("</p>\r\n                                    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1410, "\"", 1445, 2);
            WriteAttributeValue("", 1417, "/characters/details/", 1417, 20, true);
#line 37 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
WriteAttributeValue("", 1437, item.ID, 1437, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1446, 87, true);
            WriteLiteral(" role=\"button\">Details</a>\r\n                                    <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1533, "\"", 1565, 2);
            WriteAttributeValue("", 1540, "/characters/edit/", 1540, 17, true);
#line 38 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
WriteAttributeValue("", 1557, item.ID, 1557, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1566, 86, true);
            WriteLiteral(" role=\"button\">Edit</a>\r\n                                    <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1652, "\"", 1686, 2);
            WriteAttributeValue("", 1659, "/characters/delete/", 1659, 19, true);
#line 39 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
WriteAttributeValue("", 1678, item.ID, 1678, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1687, 170, true);
            WriteLiteral(" role=\"button\">Delete</a>\r\n                                </div>\r\n                            </div>\r\n                            <br />\r\n                        </td>\r\n");
            EndContext();
#line 44 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1880, 68, true);
            WriteLiteral("                </tr>\r\n\r\n            </tbody>\r\n        </table>*\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SharedRoleplay.Models.Character>> Html { get; private set; }
    }
}
#pragma warning restore 1591
