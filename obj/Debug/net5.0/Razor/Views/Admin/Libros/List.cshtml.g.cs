#pragma checksum "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3092e091f307b9a718c9a7f3dc781e21acfda50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Libros_List), @"mvc.1.0.view", @"/Views/Admin/Libros/List.cshtml")]
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
#line 1 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/_ViewImports.cshtml"
using MVCLibroteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/_ViewImports.cshtml"
using MVCLibroteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3092e091f307b9a718c9a7f3dc781e21acfda50", @"/Views/Admin/Libros/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3165a9b66eac83f5f3ca491331ff2117273a910", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Libros_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Libros>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Libros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
  
    ViewData["Title"] = "Libros";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex justify-content-between align-items-center pt-3 pb-2 mb-3 border-bottom"">
    <h1 class=""h2"">Libros Disponibles</h1>
    <div class=""btn-toolbar mb-2 mb-md-0"">
        <div class=""btn-group mr-2"">
            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Exportar</button>
        </div>
    </div>
</div>
<div class=""container"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3092e091f307b9a718c9a7f3dc781e21acfda505819", async() => {
                WriteLiteral("Nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <hr>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Portada</th>
                <th scope=""col"">Titulo</th>
                <th scope=""col"">Autor</th>
                <th scope=""col"">ISBN</th>
                <th scope=""col"">Precio</th>
                <th scope=""col"">Stock</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
             foreach (var libro in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3092e091f307b9a718c9a7f3dc781e21acfda507951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1084, "~/portadas/", 1084, 11, true);
#nullable restore
#line 33 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
AddHtmlAttributeValue("", 1095, libro.portada, 1095, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 36 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
                   Write(Html.DisplayFor(modelItem => libro.titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 39 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
                   Write(Html.DisplayFor(modelItem => libro.autores.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 40 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
                   Write(Html.DisplayFor(modelItem => libro.autores.aPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 43 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
                   Write(Html.DisplayFor(modelItem => libro.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 46 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
                   Write(Html.DisplayFor(modelItem => libro.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(" MXN\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 49 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
                   Write(Html.DisplayFor(modelItem => libro.stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        <a class=\"btn btn-info\">Actualizar</a>\n                        <a class=\"btn btn-danger\">Eliminar</a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 56 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 59 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
      
        var activos = ViewBag.Activos;
        var inactivos = ViewBag.Inactivos;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"btn btn-success\">\n        Activos <span class=\"badge badge-light\">");
#nullable restore
#line 64 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
                                           Write(activos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        <span class=\"sr-only\">Libros Activos</span>\n    </a>\n    <a class=\"btn btn-secondary\">\n        Inactivos <span class=\"badge badge-secondary\">");
#nullable restore
#line 68 "/Users/mariareina/Desarrollo/FDW_6A_DZ/MVCLibroteca/Views/Admin/Libros/List.cshtml"
                                                 Write(inactivos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        <span class=\"sr-only\">Libros inactivos</span>\n    </a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Libros>> Html { get; private set; }
    }
}
#pragma warning restore 1591
