#pragma checksum "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\ProfessorRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12d99e91aefe6bccb0be8e52c5a6694ec285d6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_ProfessorRegister), @"mvc.1.0.view", @"/Views/Register/ProfessorRegister.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Register/ProfessorRegister.cshtml", typeof(AspNetCore.Views_Register_ProfessorRegister))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12d99e91aefe6bccb0be8e52c5a6694ec285d6a", @"/Views/Register/ProfessorRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9005a25d01fd89251b0f37654d85a182accd7b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_ProfessorRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.DTO.Unidade>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ImagemPreview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Cadastro/Default_Image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Imagem Perfil."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Professor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\ProfessorRegister.cshtml"
  
    ViewData["Title"] = "Cadastrar - Professor";
    Layout = "_RegisterAndEdit";

#line default
#line hidden
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(145, 234, true);
            WriteLiteral("<div>\r\n    <section>\r\n        <p id=\"Titulo\">\r\n            <i id=\"IconeTitulo\" class=\"fas fa-user-plus\"></i>\r\n            Cadastrar Professor\r\n        </p>\r\n    </section>\r\n\r\n    <section id=\"DadosPessoais\" class=\"col-sm-8\">\r\n        ");
            EndContext();
            BeginContext(379, 7556, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c12d99e91aefe6bccb0be8e52c5a6694ec285d6a7185", async() => {
                BeginContext(476, 465, true);
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <span class=""ls-label-text"">Identificação</span>
                        </div>

                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-sm-4"">
                                    ");
                EndContext();
                BeginContext(941, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c12d99e91aefe6bccb0be8e52c5a6694ec285d6a8047", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1061, 4387, true);
                WriteLiteral(@"
                                    <br>
                                    <input type=""file"" id=""ImagemPerfil"" class=""form-control-file"" name=""imagemPerfil"" accept=""image/*"">
                                </div>

                                <div class=""col-sm-8"">
                                    <span class=""ls-label-text"">Nome Completo</span>
                                    <input type=""text"" id=""NomeCompleto"" class=""form-control"" name=""nomeCompleto"" required>

                                    <span class=""ls-label-text ="">Email</span>
                                    <input type=""text"" id=""Email"" class=""form-control"" name=""email"" required>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Rua</span>
                                            <input type=""text"" id=""Rua"" class=""form-control"" name=""rua"" required>
                    ");
                WriteLiteral(@"                    </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Bairro</span>
                                            <input type=""text"" id=""Bairro"" class=""form-control"" name=""bairro"" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <span class=""ls-label-text"">Número</span>
                                            <input type=""text"" id=""Numero"" class=""form-control"" name=""numero"" required>
                                        </div>

                                        <div class=""col-sm-3"">
                                            <span class=""ls-label-text"">Complemento</span>
                                            <input type=""text"" id=""Complemento"" class=""form-con");
                WriteLiteral(@"trol"" name=""complemento"" required>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Data de Nascimento</span>
                                            <input type=""text"" id=""DataNascimento"" class=""form-control"" name=""dataNascimento"" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Telefone</span>
                                            <input type=""text"" id=""Telefone"" class=""form-control"" name=""telefone"" required>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Celular</span>
         ");
                WriteLiteral(@"                                   <input type=""text"" id=""Celular"" class=""form-control"" name=""celular"" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">CREF</span>
                                            <input type=""text"" id=""Cref"" class=""form-control"" name=""cref"" required>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">CPF</span>
                                            <input type=""text"" id=""Cpf"" class=""form-control"" name=""cpf"" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                 ");
                WriteLiteral(@"       <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Unidade</span>
                                            <select type=""text"" id=""Unidade"" class=""form-control"" name=""unidade"" required>
                                                ");
                EndContext();
                BeginContext(5448, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c12d99e91aefe6bccb0be8e52c5a6694ec285d6a14243", async() => {
                    BeginContext(5456, 21, true);
                    WriteLiteral("Selecione uma unidade");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5486, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 99 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\ProfessorRegister.cshtml"
                                                 foreach (var unidade in Model)
                                                {

#line default
#line hidden
                BeginContext(5620, 52, true);
                WriteLiteral("                                                    ");
                EndContext();
                BeginContext(5672, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c12d99e91aefe6bccb0be8e52c5a6694ec285d6a15962", async() => {
                    BeginContext(5708, 19, false);
#line 101 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\ProfessorRegister.cshtml"
                                                                                  Write(unidade.NomeUnidade);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 101 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\ProfessorRegister.cshtml"
                                                       WriteLiteral(unidade.IdUnidade);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5736, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 102 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\ProfessorRegister.cshtml"
                                                }

#line default
#line hidden
                BeginContext(5789, 2139, true);
                WriteLiteral(@"                                            </select>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Sexo</span>
                                            <br>
                                            <div class=""custom-control custom-radio custom-control-inline"">
                                                <label class=""radio-inline control-label"" for=""Masculino"">
                                                    <input class=""form-check-input"" type=""radio"" name=""sexo"" id=""Masculino"" value=""Masculino"">
                                                    Masculino
                                                </label>
                                            </div>

                                            <div class=""custom-control custom-radio custom-control-inline"">
                                                <label class=""radio-inline ");
                WriteLiteral(@"control-label"" for=""Feminino"">
                                                    <input class=""form-check-input"" type=""radio"" name=""sexo"" id=""Feminino"" value=""Feminino"">
                                                    Feminino
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <br>
                                    <button type=""submit"" id=""ConfirmarCadastroProfessor"" class=""btn btn-primary"">Confirmar</button>

                                    <button type=""reset"" id=""ResetCadastroProfessor"" class=""btn btn-secondary"">Resetar</button>
                                </div>
                            </div>
                     ");
                WriteLiteral("   </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7935, 53, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.DTO.Unidade>> Html { get; private set; }
    }
}
#pragma warning restore 1591
