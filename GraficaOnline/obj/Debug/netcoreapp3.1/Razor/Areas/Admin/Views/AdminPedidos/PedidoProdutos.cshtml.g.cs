#pragma checksum "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "351f04640b25cc7dae5f8f6f4495d0edc0a06c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminPedidos_PedidoProdutos), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminPedidos/PedidoProdutos.cshtml")]
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
#line 1 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using GraficaOnline.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using GraficaOnline.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351f04640b25cc7dae5f8f6f4495d0edc0a06c3f", @"/Areas/Admin/Views/AdminPedidos/PedidoProdutos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b950fab60764c833ca44b01ac020f859a6cf7b4b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminPedidos_PedidoProdutos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GraficaOnline.ViewModels.PedidoProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
  
    ViewData["Title"] = "PedidoProdutos";
    decimal totalPedido = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Produtos do Pedido</h1>\r\n<hr />\r\n<h3>Pedido  :  ");
#nullable restore
#line 9 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
          Write(Html.DisplayFor(model => @Model.Pedido.PedidoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Cliente :  ");
#nullable restore
#line 10 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
          Write(Html.DisplayFor(model => @Model.Pedido.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Data    :  ");
#nullable restore
#line 11 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
          Write(Html.DisplayFor(model => @Model.Pedido.PedidoEnviado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Entrega :  ");
#nullable restore
#line 12 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
          Write(Html.DisplayFor(model => @Model.Pedido.PedidoEntregueEm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 15 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
     foreach (var item in @Model.Pedido.PedidoItens)
    {

        totalPedido += (@item.Produto.ValorVenda * @item.Quantidade);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td align=\"right\">\r\n                <h3>");
#nullable restore
#line 22 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Produto.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </td>\r\n            <td align=\"right\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 821, "\"", 850, 1);
#nullable restore
#line 25 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
WriteAttributeValue("", 827, item.Produto.ImagemUrl, 827, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" height=\"100\" width=\"100\">\r\n            </td>\r\n            <td align=\"right\">\r\n                <h3>");
#nullable restore
#line 28 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
               Write(string.Format("{0:C}", item.Produto.ValorVenda));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </td>\r\n            <td align=\"right\">\r\n                <h3>(");
#nullable restore
#line 31 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
                Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td colspan=\"2\">&nbsp;</td>\r\n        <td align=\"right\">\r\n            <h3>Total do Pedido : ");
#nullable restore
#line 38 "C:\Users\wilia\Source\Repos\GraficaOnline\GraficaOnline\Areas\Admin\Views\AdminPedidos\PedidoProdutos.cshtml"
                             Write(string.Format("{0:C}", @totalPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "351f04640b25cc7dae5f8f6f4495d0edc0a06c3f8519", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GraficaOnline.ViewModels.PedidoProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
