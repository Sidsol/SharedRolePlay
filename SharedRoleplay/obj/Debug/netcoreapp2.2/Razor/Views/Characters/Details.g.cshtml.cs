#pragma checksum "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad8b5781dac280297adf85f49539b6bce1ae615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Characters_Details), @"mvc.1.0.view", @"/Views/Characters/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Characters/Details.cshtml", typeof(AspNetCore.Views_Characters_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad8b5781dac280297adf85f49539b6bce1ae615", @"/Views/Characters/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8c60fae9b976c7a324a4e90664cd8c02908a102", @"/Views/_ViewImports.cshtml")]
    public class Views_Characters_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SharedRoleplay.Models.Character>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Character</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(218, 40, false);
#line 14 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(258, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(322, 36, false);
#line 17 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(358, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(421, 47, false);
#line 20 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(468, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(532, 43, false);
#line 23 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(575, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(638, 42, false);
#line 26 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(680, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(744, 38, false);
#line 29 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(782, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(845, 53, false);
#line 32 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SexualOrientation));

#line default
#line hidden
            EndContext();
            BeginContext(898, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(962, 49, false);
#line 35 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.SexualOrientation));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1074, 42, false);
#line 38 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1180, 38, false);
#line 41 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1281, 42, false);
#line 44 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1387, 38, false);
#line 47 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1488, 44, false);
#line 50 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EyeColor));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1596, 40, false);
#line 53 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.EyeColor));

#line default
#line hidden
            EndContext();
            BeginContext(1636, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1699, 45, false);
#line 56 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HeirColor));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1808, 41, false);
#line 59 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.HeirColor));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1912, 40, false);
#line 62 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(1952, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2016, 36, false);
#line 65 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(2052, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2115, 43, false);
#line 68 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Species));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2222, 39, false);
#line 71 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Species));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2324, 45, false);
#line 74 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Languages));

#line default
#line hidden
            EndContext();
            BeginContext(2369, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2433, 41, false);
#line 77 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Languages));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2537, 45, false);
#line 80 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BackStory));

#line default
#line hidden
            EndContext();
            BeginContext(2582, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2646, 41, false);
#line 83 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.BackStory));

#line default
#line hidden
            EndContext();
            BeginContext(2687, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2750, 49, false);
#line 86 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Miscellaneous));

#line default
#line hidden
            EndContext();
            BeginContext(2799, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2863, 45, false);
#line 89 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Miscellaneous));

#line default
#line hidden
            EndContext();
            BeginContext(2908, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2955, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad8b5781dac280297adf85f49539b6bce1ae61515810", async() => {
                BeginContext(3001, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\jonah\OneDrive\lc101\Unit4\SharedRoleplay\SharedRoleplay\Views\Characters\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3009, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3017, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad8b5781dac280297adf85f49539b6bce1ae61518150", async() => {
                BeginContext(3039, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3055, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SharedRoleplay.Models.Character> Html { get; private set; }
    }
}
#pragma warning restore 1591
