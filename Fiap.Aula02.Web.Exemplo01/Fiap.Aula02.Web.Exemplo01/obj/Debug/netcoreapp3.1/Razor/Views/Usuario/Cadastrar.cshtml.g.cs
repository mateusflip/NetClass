#pragma checksum "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18673dc594825b8160b12e60d207949a23500130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18673dc594825b8160b12e60d207949a23500130", @"/Views/Usuario/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba58d6951830afdee37add254cb07f458091a5b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ususario>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Usuario\Cadastrar.cshtml"
  

    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cadastro do usuário</h1>\r\n");
#nullable restore
#line 9 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Usuario\Cadastrar.cshtml"
 if(Model != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
#nullable restore
#line 11 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Usuario\Cadastrar.cshtml"
   Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <ul>\r\n            <li>");
#nullable restore
#line 13 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Usuario\Cadastrar.cshtml"
           Write(ViewData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 14 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Usuario\Cadastrar.cshtml"
           Write(ViewBag.data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 15 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Usuario\Cadastrar.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n");
#nullable restore
#line 18 "D:\Novo Downloads\NetClass\Fiap.Aula02.Web.Exemplo01\Fiap.Aula02.Web.Exemplo01\Views\Usuario\Cadastrar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18673dc594825b8160b12e60d207949a235001305618", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
    <label for=""id-nome"">Nome</label>
    <input type=""text"" name=""nome"" id=""id-nome"" class=""form-control""/>
    </div>
    <div class=""form-group"">
        <label for=""id-data"">Data de Nascimento</label>
        <input type=""date"" name=""dataNascimento"" id=""id-data"" class=""form-control""/>
    </div>
    <div class=""form-group"">
        <label for=""id-email"">Email</label>
        <input type=""email"" name=""email"" id=""email"" class=""form-control""/>
    </div>
    <input type=""submit"" value=""cadastrar"" class=""btn btn-primary""/>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ususario> Html { get; private set; }
    }
}
#pragma warning restore 1591
