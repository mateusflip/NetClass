#pragma checksum "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155b6858fccfcbf3dbb923f0a95b82167e73e627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Cadastrar), @"mvc.1.0.view", @"/Views/Produto/Cadastrar.cshtml")]
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
#line 1 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\_ViewImports.cshtml"
using Fiap.Aula02.Web.Exemplo01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\_ViewImports.cshtml"
using Fiap.Aula02.Web.Exemplo01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155b6858fccfcbf3dbb923f0a95b82167e73e627", @"/Views/Produto/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba58d6951830afdee37add254cb07f458091a5b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 4 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cadastrar</h1>\r\n\r\n<div>TempData:\r\n        ");
#nullable restore
#line 11 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
   Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
   Write(TempData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n    </div>\r\n\r\n");
#nullable restore
#line 16 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
 if (ViewBag.prod != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 19 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
Write(ViewData);

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n    ");
#nullable restore
#line 20 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
Write(ViewData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
Write(ViewData["preco"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n    View Bag:\r\n    ");
#nullable restore
#line 24 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
Write(ViewBag.qtd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 25 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
Write(ViewBag.prod);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n\r\n</div>\r\n");
#nullable restore
#line 29 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Produto\Cadastrar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "155b6858fccfcbf3dbb923f0a95b82167e73e6276333", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""id-nome"">Nome</label>
        <input typeof=""text"" class=""form-control"" id=""id-nome"" name=""nome""/>
    </div>
    <div class=""form-group"">
        <label for=""id-preco"">Pre??o</label>
        <input type=""text"" class=""form-control"" id=""id-preco"" name=""preco""/>

    </div>
    <div class=""form-group"">
        <label for=""id-quantidade"">Quantidade</label>
        <input type=""text"" class=""form-control"" id=""id-quantidade"" name=""quantidade""/>
    </div>
    <input type=""submit"" value=""Cadastrar"" class=""btn btn-outline-primary""/>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
