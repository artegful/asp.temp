#pragma checksum "/Users/artegful/Projects/WEB-953503-Klimovich/WEB-953503-Klimovich/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07e301a2453b6d8abe73ac28c6f5a92cb6105c55"
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
#line 1 "/Users/artegful/Projects/WEB-953503-Klimovich/WEB-953503-Klimovich/Views/_ViewImports.cshtml"
using WEB_953503_Klimovich;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/artegful/Projects/WEB-953503-Klimovich/WEB-953503-Klimovich/Views/_ViewImports.cshtml"
using WEB_953503_Klimovich.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07e301a2453b6d8abe73ac28c6f5a92cb6105c55", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aaa1ca894883f044febcf79f48ae90f622902c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 1 "/Users/artegful/Projects/WEB-953503-Klimovich/WEB-953503-Klimovich/Views/Home/Index.cshtml"
Write(ViewData["Text"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<h2>Список</h2>\n<ol type=\"A\">\n");
#nullable restore
#line 4 "/Users/artegful/Projects/WEB-953503-Klimovich/WEB-953503-Klimovich/Views/Home/Index.cshtml"
     for (int i = 0; i < 5; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>элемент ");
#nullable restore
#line 6 "/Users/artegful/Projects/WEB-953503-Klimovich/WEB-953503-Klimovich/Views/Home/Index.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" списка</li>\n");
#nullable restore
#line 7 "/Users/artegful/Projects/WEB-953503-Klimovich/WEB-953503-Klimovich/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\n\n<hr />\n\n<h2>Форма</h2>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e301a2453b6d8abe73ac28c6f5a92cb6105c554622", async() => {
                WriteLiteral("\n    <div class=\"form-group row justify-content-end\">\n        <div class=\"col-sm-10\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07e301a2453b6d8abe73ac28c6f5a92cb6105c554979", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 16 "/Users/artegful/Projects/WEB-953503-Klimovich/WEB-953503-Klimovich/Views/Home/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Collection"] as SelectList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

            <div class=""form-check"">
                <input class=""form-check-input"" type=""checkbox"" name=""check-1"" value=""on"">
                <label class=""form-check-label"">
                    чек-бокс 1
                </label>
            </div>
            <div class=""form-check"">
                <input class=""form-check-input"" type=""checkbox"" name=""check-2"" value=""on"">
                <label class=""form-check-label"">
                    чек-бокс 2
                </label>
            </div>
        </div>
    </div>
    <div class=""form-group row justify-content-end"">
        <div class=""col-sm-10"">
            <div class=""row"">
                <div class=""form-check col-sm-auto"">
                    <input class=""form-check-input"" type=""radio"" name=""radio"" value=""radio-1"" checked>
                    <label class=""form-check-label"">
                        Радио-1
                    </label>
                </div>
                <div class=""form-check col-sm-auto"">
                    <input clas");
                WriteLiteral(@"s=""form-check-input"" type=""radio"" name=""radio"" value=""radio-2"">
                    <label class=""form-check-label"">
                        Радио-2
                    </label>
                </div>
                <div class=""form-check col-sm-auto"">
                    <input class=""form-check-input"" type=""radio"" name=""radio"" value=""radio-3"">
                    <label class=""form-check-label"">
                        Радио-3
                    </label>
                </div>
            </div>
        </div>
    </div>
    <div class=""form-group row"">
        <label class=""col-sm-2 col-form-label"">Логин</label>
        <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" name=""login"" placeholder=""Введите имя"">
        </div>
    </div>
    <div class=""form-group row"">
        <label class=""col-sm-2 col-form-label"">Пароль</label>
        <div class=""col-sm-10"">
            <input type=""password"" class=""form-control"" name=""password"" placeholder=""Введите пароль"">
        </div>
    <");
                WriteLiteral("/div>\n    <div class=\"form-group row\">\n        <div class=\"col-sm-10\">\n            <button type=\"submit\" class=\"btn btn-primary\">Отправить</button>\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
