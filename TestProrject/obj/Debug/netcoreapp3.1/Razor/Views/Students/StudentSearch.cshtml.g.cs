#pragma checksum "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7600655852043aef378e09fca2db4111217a2bfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_StudentSearch), @"mvc.1.0.view", @"/Views/Students/StudentSearch.cshtml")]
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
#line 1 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\_ViewImports.cshtml"
using TestProrject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\_ViewImports.cshtml"
using TestProrject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7600655852043aef378e09fca2db4111217a2bfd", @"/Views/Students/StudentSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484ac90e170260e6c9fb3137bc7aa31176800544", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_StudentSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
  
    ViewData["Title"] = "StudentSearch";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"alert alert-info\">StudentSearch</h2>\r\n<br />\r\n<h4 class=\"text-danger\">");
#nullable restore
#line 9 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                   Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<br />\r\n<div class=\"card\">\r\n\r\n\r\n    <div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7600655852043aef378e09fca2db4111217a2bfd5131", async() => {
                WriteLiteral(@"
                    <label>Minimum score : </label>
                    <input type=""number"" name=""min"" class=""form-control"" />
                    <label>Maximum score : </label>
                    <input type=""number"" name=""max"" class=""form-control"" />
                    <span style=""padding:10px;""></span>
                    <button type=""submit"" class=""btn btn-success btn-sm"">Search</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 30 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-striped\">\r\n                <thead>\r\n                    <tr>\r\n");
#nullable restore
#line 35 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                         foreach (DataColumn c in Model.Columns)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th>");
#nullable restore
#line 37 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                           Write(c.ColumnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 38 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                     foreach (DataRow r in Model.Rows)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n");
#nullable restore
#line 46 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                             foreach (DataColumn c in Model.Columns)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 48 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                               Write(r[c]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 55 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
