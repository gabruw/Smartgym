#pragma checksum "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Main\FichaMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b37f95e672d10d56329b4ad3546f46586941b1e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_FichaMain), @"mvc.1.0.view", @"/Views/Main/FichaMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/FichaMain.cshtml", typeof(AspNetCore.Views_Main_FichaMain))]
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
#line 1 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\_ViewImports.cshtml"
using Smartgym;

#line default
#line hidden
#line 2 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\_ViewImports.cshtml"
using Smartgym.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37f95e672d10d56329b4ad3546f46586941b1e8", @"/Views/Main/FichaMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9005a25d01fd89251b0f37654d85a182accd7b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_FichaMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ficha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Main\FichaMain.cshtml"
  
    ViewData["Title"] = "Principal - Ficha";
    Layout = "_Main";

#line default
#line hidden
            BeginContext(76, 557, true);
            WriteLiteral(@"
<div>
    <section>
        <p id=""Titulo"">
            <i id=""IconeTitulo"" class=""fas fa-file-alt""></i>
            Ficha
        </p>
    </section>

    <section class=""col-sm-8"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <span class=""ls-label-text"">Principal</span>
                    </div>

                    <div class=""card-body"">
                        <div class=""row"">
                            ");
            EndContext();
            BeginContext(633, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b37f95e672d10d56329b4ad3546f46586941b1e84991", async() => {
                BeginContext(715, 102, true);
                WriteLiteral("\r\n                                <i class=\"fas fa-paste\"></i> Cadastrar\r\n                            ");
                EndContext();
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
            EndContext();
            BeginContext(821, 2263, true);
            WriteLiteral(@"

                            <a class=""btn btn-secondary float-left isDisabled"" id=""EditarFicha"" href=""#"">
                                <i class=""fas fa-edit""></i> Editar
                            </a>

                            <a class=""btn btn-secondary float-left isDisabled"" id=""ExcluirFicha"" href=""#"">
                                <i class=""fas fa-trash-alt""></i> Excluir
                            </a>
                        </div>

                        <br />

                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""panel panel-primary"">
                                    <div class=""panel-body"">
                                        <table id=""FichaTable"" class=""table table-striped table-bordered table-hover responsive"" width=""100%"">
                                            <thead class=""thin-border-bottom"">
                                                <tr>
                      ");
            WriteLiteral(@"                              <th>Id</th>
                                                    <th>Matrícula</th>
                                                    <th>Nome do Aluno</th>
                                                    <th>CREF</th>
                                                    <th>Nome do Professor</th>
                                                </tr>
                                            </thead>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <br>

                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <button type=""submit"" id=""ConfirmarCadastroUnidade"" class=""btn btn-primary"">Confirmar</button>

                                <button type=""reset"" id=""ResetCadastroUnidade"" class=""btn btn-secondary"">Resetar</b");
            WriteLiteral("utton>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n<div class=\"overlay\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
