#pragma checksum "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a26c21bac6cb7a89b22a7abbf949280da0ec35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Edit_ProfessorEdit), @"mvc.1.0.view", @"/Views/Edit/ProfessorEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Edit/ProfessorEdit.cshtml", typeof(AspNetCore.Views_Edit_ProfessorEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a26c21bac6cb7a89b22a7abbf949280da0ec35", @"/Views/Edit/ProfessorEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9005a25d01fd89251b0f37654d85a182accd7b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Edit_ProfessorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auxiliary.Partial.ViewProfessor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Professor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
  
    ViewData["Title"] = "Editar - Professor";
    Layout = "_RegisterAndEdit";

#line default
#line hidden
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(140, 226, true);
            WriteLiteral("<div>\r\n    <section>\r\n        <p id=\"Titulo\">\r\n            <i id=\"IconeTitulo\" class=\"fas fa-edit\"></i>\r\n            Editar Professor\r\n        </p>\r\n    </section>\r\n\r\n    <section id=\"DadosPessoais\" class=\"col-sm-8\">\r\n        ");
            EndContext();
            BeginContext(366, 10629, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a26c21bac6cb7a89b22a7abbf949280da0ec355411", async() => {
                BeginContext(505, 522, true);
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
                                    <img id=""ImagemPreview"" class=""img-fluid mx-auto d-block""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1027, "\"", 1065, 1);
#line 28 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 1033, Model.Professor.ImagemProfessor, 1033, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1066, 503, true);
                WriteLiteral(@" alt=""Imagem Perfil."" />
                                    <br>
                                    <input type=""file"" id=""ImagemPerfil"" class=""form-control-file"" name=""imagemPerfil"" accept=""image/*"">
                                </div>

                                <div class=""col-sm-8"">
                                    <span class=""ls-label-text"">Nome Completo</span>
                                    <input type=""text"" id=""NomeCompleto"" class=""form-control"" name=""nomeCompleto""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1569, "\"", 1607, 1);
#line 35 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 1577, Model.Professor.NomeProfessor, 1577, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1608, 193, true);
                WriteLiteral(" required>\r\n\r\n                                    <span class=\"ls-label-text =\">Email</span>\r\n                                    <input type=\"text\" id=\"Email\" class=\"form-control\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1801, "\"", 1851, 1);
#line 38 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 1809, Model.Professor.ContaProfessor.EmailConta, 1809, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1852, 332, true);
                WriteLiteral(@" required>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text ="">Senha</span>
                                            <input type=""password"" id=""Senha"" class=""form-control"" name=""senha""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2184, "\"", 2234, 1);
#line 43 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 2192, Model.Professor.ContaProfessor.SenhaConta, 2192, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2235, 315, true);
                WriteLiteral(@" required>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text ="">CEP</span>
                                            <input type=""text"" id=""Cep"" class=""form-control"" name=""cep""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2550, "\"", 2604, 1);
#line 48 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 2558, Model.Professor.EnderecoProfessor.CepEndereco, 2558, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2605, 412, true);
                WriteLiteral(@" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Rua</span>
                                            <input type=""text"" id=""Rua"" class=""form-control"" name=""rua""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3017, "\"", 3071, 1);
#line 55 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 3025, Model.Professor.EnderecoProfessor.RuaEndereco, 3025, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3072, 322, true);
                WriteLiteral(@" required>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Bairro</span>
                                            <input type=""text"" id=""Bairro"" class=""form-control"" name=""bairro""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3394, "\"", 3451, 1);
#line 60 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 3402, Model.Professor.EnderecoProfessor.BairroEndereco, 3402, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3452, 421, true);
                WriteLiteral(@" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <span class=""ls-label-text"">Número</span>
                                            <input type=""text"" id=""Numero"" class=""form-control"" name=""numero""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3873, "\"", 3930, 1);
#line 67 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 3881, Model.Professor.EnderecoProfessor.NumeroEndereco, 3881, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3931, 331, true);
                WriteLiteral(@" required>
                                        </div>

                                        <div class=""col-sm-3"">
                                            <span class=""ls-label-text"">Compl</span>
                                            <input type=""text"" id=""Complemento"" class=""form-control"" name=""complemento""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4262, "\"", 4324, 1);
#line 72 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 4270, Model.Professor.EnderecoProfessor.ComplementoEndereco, 4270, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4325, 341, true);
                WriteLiteral(@">
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Data de Nascimento</span>
                                            <input type=""date"" id=""DataNascimento"" class=""form-control"" name=""dataNascimento""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4666, "\"", 4742, 1);
#line 77 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 4674, Model.Professor.DataNascimentoProfessor.Date.ToString("yyyy-MM-dd"), 4674, 68, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4743, 427, true);
                WriteLiteral(@" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Telefone</span>
                                            <input type=""text"" id=""Telefone"" class=""form-control"" name=""telefone""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5170, "\"", 5212, 1);
#line 84 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 5178, Model.Professor.TelefoneProfessor, 5178, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5213, 325, true);
                WriteLiteral(@" required>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Celular</span>
                                            <input type=""text"" id=""Celular"" class=""form-control"" name=""celular""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5538, "\"", 5579, 1);
#line 89 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 5546, Model.Professor.CelularProfessor, 5546, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5580, 415, true);
                WriteLiteral(@" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">CREF</span>
                                            <input type=""text"" id=""Cref"" class=""form-control"" name=""cref""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5995, "\"", 6033, 1);
#line 96 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 6003, Model.Professor.CrefProfessor, 6003, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6034, 313, true);
                WriteLiteral(@" required>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">CPF</span>
                                            <input type=""text"" id=""Cpf"" class=""form-control"" name=""cpf""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6347, "\"", 6384, 1);
#line 101 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
WriteAttributeValue("", 6355, Model.Professor.CpfProfessor, 6355, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6385, 485, true);
                WriteLiteral(@" required>
                                        </div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Unidade</span>
                                            <select type=""text"" id=""Unidade"" class=""form-control"" name=""unidade"" required>
                                                ");
                EndContext();
                BeginContext(6870, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a26c21bac6cb7a89b22a7abbf949280da0ec3518209", async() => {
                    BeginContext(6878, 21, true);
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
                BeginContext(6908, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 110 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                 foreach (var unidade in Model.Unidade)
                                                {
                                                    if (unidade.NomeUnidade.Equals(Model.Professor.UnidadeProfessor.NomeUnidade))
                                                    {

#line default
#line hidden
                BeginContext(7236, 56, true);
                WriteLiteral("                                                        ");
                EndContext();
                BeginContext(7292, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a26c21bac6cb7a89b22a7abbf949280da0ec3520119", async() => {
                    BeginContext(7337, 19, false);
#line 114 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                                                               Write(unidade.NomeUnidade);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 114 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                           WriteLiteral(unidade.IdUnidade);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7365, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 115 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
                BeginContext(7535, 56, true);
                WriteLiteral("                                                        ");
                EndContext();
                BeginContext(7591, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a26c21bac6cb7a89b22a7abbf949280da0ec3523096", async() => {
                    BeginContext(7627, 19, false);
#line 118 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                                                      Write(unidade.NomeUnidade);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 118 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
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
                BeginContext(7655, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 119 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                    }
                                                }

#line default
#line hidden
                BeginContext(7763, 521, true);
                WriteLiteral(@"                                            </select>
                                        </div>

                                        <div class=""col-sm-6"">
                                            <span class=""ls-label-text"">Sexo</span>
                                            <br>
                                            <div class=""custom-control custom-radio custom-control-inline"">
                                                <label class=""radio-inline control-label"" for=""Masculino"">
");
                EndContext();
#line 129 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                     if (Model.Professor.SexoProfessor == 1)
                                                    {

#line default
#line hidden
                BeginContext(8433, 148, true);
                WriteLiteral("                                                        <input type=\"radio\" class=\"form-check-input\" id=\"Masculino\" name=\"sexo\" value=\"1\" checked>\r\n");
                EndContext();
#line 132 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
                BeginContext(8749, 140, true);
                WriteLiteral("                                                        <input type=\"radio\" class=\"form-check-input\" id=\"Masculino\" name=\"sexo\" value=\"1\">\r\n");
                EndContext();
#line 136 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(8944, 393, true);
                WriteLiteral(@"
                                                    Masculino
                                                </label>
                                            </div>

                                            <div class=""custom-control custom-radio custom-control-inline"">
                                                <label class=""radio-inline control-label"" for=""Feminino"">
");
                EndContext();
#line 144 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                     if (Model.Professor.SexoProfessor == 2)
                                                    {

#line default
#line hidden
                BeginContext(9486, 147, true);
                WriteLiteral("                                                        <input type=\"radio\" class=\"form-check-input\" id=\"Feminino\" name=\"sexo\" value=\"2\" checked>\r\n");
                EndContext();
#line 147 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
                BeginContext(9801, 139, true);
                WriteLiteral("                                                        <input type=\"radio\" class=\"form-check-input\" id=\"Feminino\" name=\"sexo\" value=\"2\">\r\n");
                EndContext();
#line 151 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(9995, 993, true);
                WriteLiteral(@"
                                                    Feminino
                                                </label>
                                            </div>
                                        </div>
                                    </div>

                                    <br>

                                    <div class=""row"">
                                        <div class=""col-sm-12"">
                                            <button type=""submit"" id=""ConfirmarCadastroProfessor"" class=""btn btn-primary"">Confirmar</button>

                                            <button type=""reset"" id=""ResetCadastroProfessor"" class=""btn btn-secondary"">Resetar</button>
                                        </div>
                                    </div>
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
#line 17 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Edit\ProfessorEdit.cshtml"
                                                             WriteLiteral(Model.Professor.IdProfessor);

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
            BeginContext(10995, 53, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auxiliary.Partial.ViewProfessor> Html { get; private set; }
    }
}
#pragma warning restore 1591
