#pragma checksum "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c6589a060b78cc7d2cb2732734ea76bd5d2167f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRelatorioVendas_RelatorioVendasSimples), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRelatorioVendas/RelatorioVendasSimples.cshtml")]
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
#line 1 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using GraficaOnline.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using GraficaOnline.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c6589a060b78cc7d2cb2732734ea76bd5d2167f", @"/Areas/Admin/Views/AdminRelatorioVendas/RelatorioVendasSimples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b950fab60764c833ca44b01ac020f859a6cf7b4b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRelatorioVendas_RelatorioVendasSimples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GraficaOnline.Models.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
  
    ViewData["Title"] = "Pedidos Por Período";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-dark\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c6589a060b78cc7d2cb2732734ea76bd5d2167f5099", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Inicial</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                BeginWriteAttribute("value", " value=", 487, "", 514, 1);
#nullable restore
#line 15 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
WriteAttributeValue("", 494, ViewData["minDate"], 494, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data Final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                BeginWriteAttribute("value", " value=", 720, "", 747, 1);
#nullable restore
#line 19 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
WriteAttributeValue("", 727, ViewData["maxDate"], 727, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-success\">Filtrar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total de Pedidos = ");
#nullable restore
#line 28 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3 class=\"panel-title\">Total de produtos nos Pedidos = ");
#nullable restore
#line 29 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                                                           Write(Model.Sum(obj=> obj.TotalItensPedido).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h3 class=\"panel-title\">Valor Total dos Pedidos = ");
#nullable restore
#line 30 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                                                     Write(Model.Sum(obj => obj.PedidoTotal).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 37 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.PedidoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 43 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 46 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 49 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.PedidoTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 52 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.TotalItensPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 55 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.PedidoEntregueEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PedidoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PedidoTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalItensPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PedidoEntregueEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 85 "C:\Users\leeon\source\repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminRelatorioVendas\RelatorioVendasSimples.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GraficaOnline.Models.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
