#pragma checksum "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "902c81a6c9a8cf918c66cf19c9f1e2e95002235e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Edit_UnidadeEdit), @"mvc.1.0.view", @"/Views/Edit/UnidadeEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Edit/UnidadeEdit.cshtml", typeof(AspNetCore.Views_Edit_UnidadeEdit))]
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
#line 1 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\_ViewImports.cshtml"
using Smartgym;

#line default
#line hidden
#line 2 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\_ViewImports.cshtml"
using Smartgym.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902c81a6c9a8cf918c66cf19c9f1e2e95002235e", @"/Views/Edit/UnidadeEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9005a25d01fd89251b0f37654d85a182accd7b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Edit_UnidadeEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.DTO.Unidade>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Unidade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
  
    ViewData["Title"] = "Editar - Unidade";
    Layout = "_RegisterAndEdit";

#line default
#line hidden
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(127, 224, true);
            WriteLiteral("<div>\r\n    <section>\r\n        <p id=\"Titulo\">\r\n            <i id=\"IconeTitulo\" class=\"fas fa-edit\"></i>\r\n            Editar Unidade\r\n        </p>\r\n    </section>\r\n\r\n    <section id=\"DadosPessoais\" class=\"col-sm-8\">\r\n        ");
            EndContext();
            BeginContext(351, 3943, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "902c81a6c9a8cf918c66cf19c9f1e2e95002235e5398", async() => {
                BeginContext(476, 516, true);
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <span class=""ls-label-text"">Unidade</span>
                        </div>

                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-sm-4"">
                                    <img id=""ImagemPreview"" class=""img-fluid mx-auto d-block""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 992, "\"", 1018, 1);
#line 29 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
WriteAttributeValue("", 998, Model.ImagemUnidade, 998, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1019, 500, true);
                WriteLiteral(@" alt=""Imagem Perfil."" />
                                    <br>
                                    <input type=""file"" id=""ImagemPerfil"" class=""form-control-file"" name=""imagemPerfil"" accept=""image/*"">
                                </div>

                                <div class=""col-sm-8"">
                                    <span class=""ls-label-text"">Nome Unidade</span>
                                    <input type=""text"" id=""NomeUnidade"" class=""form-control"" name=""nomeUnidade""");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 1519, "\"", 1546, 1);
#line 36 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
WriteAttributeValue("", 1528, Model.NomeUnidade, 1528, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1547, 320, true);
                WriteLiteral(@" required>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">CEP</span>
                                            <input type=""text"" id=""Cep"" class=""form-control"" name=""cep""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1867, "\"", 1909, 1);
#line 41 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
WriteAttributeValue("", 1875, Model.EnderecoUnidade.CepEndereco, 1875, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1910, 302, true);
                WriteLiteral(@" required>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Rua</span>
                                            <input type=""text"" id=""Rua"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2212, "\"", 2254, 1);
#line 46 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
WriteAttributeValue("", 2220, Model.EnderecoUnidade.RuaEndereco, 2220, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2255, 432, true);
                WriteLiteral(@" name=""rua"" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Bairro</span>
                                            <input type=""text"" id=""Bairro"" class=""form-control"" name=""bairro""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2687, "\"", 2732, 1);
#line 53 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
WriteAttributeValue("", 2695, Model.EnderecoUnidade.BairroEndereco, 2695, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2733, 322, true);
                WriteLiteral(@" required>
                                        </div>

                                        <div class=""col-sm-3"">
                                            <span class=""ls-label-text"">Número</span>
                                            <input type=""text"" id=""Numero"" class=""form-control"" name=""numero""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3055, "\"", 3100, 1);
#line 58 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
WriteAttributeValue("", 3063, Model.EnderecoUnidade.NumeroEndereco, 3063, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3101, 371, true);
                WriteLiteral(@" required>
                                        </div>
                                        
                                        <div class=""col-sm-3"">
                                            <span class=""ls-label-text"">Compl</span>
                                            <input type=""text"" id=""Complemento"" class=""form-control"" name=""complemento""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3472, "\"", 3522, 1);
#line 63 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
WriteAttributeValue("", 3480, Model.EnderecoUnidade.ComplementoEndereco, 3480, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3523, 764, true);
                WriteLiteral(@">
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <br>
                                    <button type=""submit"" id=""ConfirmarEdicaoUnidade"" class=""btn btn-primary"">Confirmar</button>

                                    <button type=""reset"" id=""ResetEdicaoUnidade"" class=""btn btn-secondary"">Resetar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\SHU Aeronáutica 01\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\UnidadeEdit.cshtml"
                                                           WriteLiteral(Model.IdUnidade);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4294, 53, true);
            WriteLiteral("\r\n    </section>\r\n</div>\r\n<div class=\"overlay\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.DTO.Unidade> Html { get; private set; }
    }
}
#pragma warning restore 1591
