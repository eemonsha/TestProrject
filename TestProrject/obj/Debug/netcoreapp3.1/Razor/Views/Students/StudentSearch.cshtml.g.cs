#pragma checksum "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "460d340ce42ac61dfe31c2a3e6d5c11ff6ec7d1e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460d340ce42ac61dfe31c2a3e6d5c11ff6ec7d1e", @"/Views/Students/StudentSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484ac90e170260e6c9fb3137bc7aa31176800544", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_StudentSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
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
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460d340ce42ac61dfe31c2a3e6d5c11ff6ec7d1e4883", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460d340ce42ac61dfe31c2a3e6d5c11ff6ec7d1e5911", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <h3 class=\"text-danger\">");
#nullable restore
#line 17 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                       Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"card-body\">\r\n");
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460d340ce42ac61dfe31c2a3e6d5c11ff6ec7d1e6839", async() => {
                    WriteLiteral(@"
                                <div class=""row align-items-center"">
                                    <div class=""col-md-6"">
                                        <label>Minimum score : </label>
                                        <input type=""number"" name=""min"" class=""form-control"" />
                                        <span style=""padding:10px;""></span>
                                    </div>
                                    <div class=""col-md-6"">
                                        <label>Maximum score : </label>
                                        <input type=""number"" name=""max"" class=""form-control"" />
                                        <span style=""padding:10px;""></span>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-12 d-flex justify-content-center"">
                                        <button type=""submit"" class=");
                    WriteLiteral("\"btn btn-success btn-sm\">Search</button>\r\n                                    </div>\r\n                                </div>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 overflow-auto\">\r\n");
#nullable restore
#line 45 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                             if (Model != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <table class=\"table table-striped \">\r\n                                    <thead>\r\n                                        <tr>\r\n");
#nullable restore
#line 50 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                             foreach (DataColumn c in Model.Columns)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <th>");
#nullable restore
#line 52 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                               Write(c.ColumnName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 53 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                         foreach (DataRow r in Model.Rows)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n");
#nullable restore
#line 61 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                                 foreach (DataColumn c in Model.Columns)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <td>");
#nullable restore
#line 63 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                                   Write(r[c]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 64 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </tbody>\r\n                                </table>\r\n");
#nullable restore
#line 70 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n\r\n                    </div>\r\n\r\n");
                WriteLiteral("\r\n                    <div class=\"row d-flex flex-row-reverse\">\r\n\r\n                        <div class=\"col-md-6\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460d340ce42ac61dfe31c2a3e6d5c11ff6ec7d1e13643", async() => {
                    WriteLiteral(@"
                                <div class=""row align-items-center"">
                                    <div class=""col-md-6"">
                                        <label>Minimum score : </label>
                                        <input type=""number"" name=""min"" class=""form-control"" />
                                        <span style=""padding:10px;""></span>
                                    </div>
                                    <div class=""col-md-6"">
                                        <label>Maximum score : </label>
                                        <input type=""number"" name=""max"" class=""form-control"" />
                                        <span style=""padding:10px;""></span>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-12 d-flex justify-content-center"">
                                        <button type=""submit"" class=");
                    WriteLiteral("\"btn btn-danger btn-sm\">Search</button>\r\n                                    </div>\r\n                                </div>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 overflow-auto\">\r\n");
#nullable restore
#line 108 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                             if (Model != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <table class=\"table table-striped \">\r\n                                    <thead>\r\n                                        <tr>\r\n");
#nullable restore
#line 113 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                             foreach (DataColumn c in Model.Columns)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <th>");
#nullable restore
#line 115 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                               Write(c.ColumnName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n");
#nullable restore
#line 116 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 121 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                         foreach (DataRow r in Model.Rows)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n");
#nullable restore
#line 124 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                                 foreach (DataColumn c in Model.Columns)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <td>");
#nullable restore
#line 126 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                                   Write(r[c]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 127 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </tr>\r\n");
#nullable restore
#line 130 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </tbody>\r\n                                </table>\r\n");
#nullable restore
#line 133 "C:\Users\emons\source\repos\TestProrject\TestProrject\Views\Students\StudentSearch.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n");
                WriteLiteral("\r\n\r\n\r\n                </div>");
                WriteLiteral("            </div>");
                WriteLiteral("        </div>\r\n\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n\r\n        <script src=\"https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/js/select2.min.js\"></script>\r\n        <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js\"></script>\r\n");
                    WriteLiteral("\r\n\r\n\r\n    ");
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
