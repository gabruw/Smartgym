#pragma checksum "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d33eb96e39390dd4e9e6f46b9b7565f5f55e9cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_FichaRegister), @"mvc.1.0.view", @"/Views/Register/FichaRegister.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Register/FichaRegister.cshtml", typeof(AspNetCore.Views_Register_FichaRegister))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d33eb96e39390dd4e9e6f46b9b7565f5f55e9cc", @"/Views/Register/FichaRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9005a25d01fd89251b0f37654d85a182accd7b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_FichaRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auxiliary.Partial.PartialCollectionProfessorAluno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Finalizar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ficha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
  
    ViewData["Title"] = "Cadastrar - Ficha";
    Layout = "_RegisterAndEdit";

#line default
#line hidden
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(157, 281, true);
            WriteLiteral(@"<div>
    <section>
        <p id=""Titulo"">
            <i id=""IconeTitulo"" class=""fas fa-plus""></i>
            Cadastrar Ficha
        </p>
    </section>

    <section id=""DadosAparelho"" class=""col-sm-12"">
        <div class=""row"">
            <div class=""col-sm-3"">
");
            EndContext();
            BeginContext(467, 787, true);
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <span class=""ls-label-text"">Ficha</span>
                            </div>

                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""col-sm-12"">
                                            <span class=""ls-label-text"">Professor</span>
                                            <select type=""text"" id=""Professor"" class=""form-control"" name=""professor"" required>
                                                ");
            EndContext();
            BeginContext(1254, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d33eb96e39390dd4e9e6f46b9b7565f5f55e9cc6664", async() => {
                BeginContext(1262, 22, true);
                WriteLiteral("Selecione um professor");
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
            BeginContext(1293, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
                                                 foreach (var professor in Model.Professor)
                                                {

#line default
#line hidden
            BeginContext(1439, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(1491, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d33eb96e39390dd4e9e6f46b9b7565f5f55e9cc8299", async() => {
                BeginContext(1531, 23, false);
#line 36 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
                                                                                      Write(professor.NomeProfessor);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
                                                       WriteLiteral(professor.IdProfessor);

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
            BeginContext(1563, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
                                                }

#line default
#line hidden
            BeginContext(1616, 424, true);
            WriteLiteral(@"                                            </select>
                                        </div>

                                        <div class=""col-sm-12"">
                                            <span class=""ls-label-text"">Aluno</span>
                                            <select type=""text"" id=""Aluno"" class=""form-control"" name=""aluno"" required>
                                                ");
            EndContext();
            BeginContext(2040, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d33eb96e39390dd4e9e6f46b9b7565f5f55e9cc11117", async() => {
                BeginContext(2048, 18, true);
                WriteLiteral("Selecione um aluno");
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
            BeginContext(2075, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
                                                 foreach (var aluno in Model.Aluno)
                                                {

#line default
#line hidden
            BeginContext(2213, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(2265, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d33eb96e39390dd4e9e6f46b9b7565f5f55e9cc12741", async() => {
                BeginContext(2297, 15, false);
#line 47 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
                                                                              Write(aluno.NomeAluno);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
                                                       WriteLiteral(aluno.IdAluno);

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
            BeginContext(2321, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "C:\Users\snyp_\Documents\GitHub\Smartgym\Sistema\Smartgym\Smartgym\Views\Register\FichaRegister.cshtml"
                                                }

#line default
#line hidden
            BeginContext(2374, 475, true);
            WriteLiteral(@"                                            </select>
                                        </div>

                                        <br />

                                        <div class=""row"">
                                            <div class=""col-sm-12"">
                                                <button type=""submit"" id=""ConfirmarCadastroFicha"" class=""btn btn-primary"">Confirmar</button>

                                                ");
            EndContext();
            BeginContext(2849, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d33eb96e39390dd4e9e6f46b9b7565f5f55e9cc15586", async() => {
                BeginContext(2963, 9, true);
                WriteLiteral("Finalizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2981, 334, true);
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <br />

");
            EndContext();
            BeginContext(3344, 2404, true);
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <span class=""ls-label-text"">Série</span>
                            </div>

                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""row"">
                                            <div class=""col-sm-6"">
                                                <span class=""ls-label-text"">Nome da Série</span>
                                                <input type=""text"" id=""NomeSerie"" class=""form-control"" name=""nomeSerie"" required>
                                            </div>

                                            <div class=""col-sm-6"">
                                                <span class=""ls-label-text"">Repetições</sp");
            WriteLiteral(@"an>
                                                <input type=""number"" id=""RepeticoesSerie"" class=""form-control"" name=""repeticoesSerie"" required>
                                            </div>
                                        </div>

                                        <div class=""row"">
                                            <div class=""col-sm-12"">
                                                <span class=""ls-label-text"">Observações</span>
                                                <textarea id=""ObservacoesSerie"" class=""form-control"" name=""observacoesSerie"" required></textarea>
                                            </div>
                                        </div>

                                        <br />

                                        <div class=""row"">
                                            <div class=""col-sm-12"">
                                                <button type=""submit"" id=""ConfirmarCadastroSerie"" class=""btn btn-primary""");
            WriteLiteral(@" disabled>Confirmar</button>
                                            </div>
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
            BeginContext(5777, 3615, true);
            WriteLiteral(@"            <div class=""col-sm-5"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <span class=""ls-label-text"">Exercícios</span>
                            </div>

                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""row"">
                                            <div class=""col-sm-2"">
                                                <span class=""ls-label-text"">Id</span>
                                                <input type=""number"" id=""IdExercicio"" class=""form-control"" name=""idExercicio"" readonly>
                                            </div>

                                            <div class=""col-sm-8"">
                                                <span ");
            WriteLiteral(@"class=""ls-label-text"">Nome</span>
                                                <input type=""text"" id=""NomeExercicio"" class=""form-control"" name=""nomeExercicio"" disabled>
                                            </div>

                                            <div class=""col-sm-2"">
                                                <span class=""ls-label-text"">Repetições</span>
                                                <input type=""number"" id=""RepeticoesExercicio"" class=""form-control"" name=""repeticoesExercicio"" required>
                                            </div>
                                        </div>

                                        <br />

                                        <div class=""row"">
                                            <div class=""col-sm-12"">
                                                <button type=""submit"" id=""ConfirmarCadastroExercicioSerie"" class=""btn btn-primary"" disabled>Confirmar</button>
                                        ");
            WriteLiteral(@"    </div>
                                        </div>
                                    </div>
                                </div>

                                <br />

                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""panel panel-primary"">
                                            <div class=""panel-body"">
                                                <table id=""ExercicioTable"" class=""table table-striped table-bordered table-hover responsive"" width=""100%"">
                                                    <thead class=""thin-border-bottom"">
                                                        <tr>
                                                            <th>Id</th>
                                                            <th>Nome do Exercício</th>
                                                            <th>Nome do Aparelho</th>                           ");
            WriteLiteral(@"                                
                                                        </tr>
                                                    </thead>
                                                </table>
                                            </div>
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
            BeginContext(9417, 2348, true);
            WriteLiteral(@"            <div class=""col-sm-4"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <span class=""ls-label-text"">Série </span>
                            </div>

                            <div class=""card-body"">
                                <br />

                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""panel panel-primary"">
                                            <div class=""panel-body"">
                                                <div class=""card-body table-responsive"">
                                                    <table id=""SeriesTable"" class=""table table-hover table-valign-middle table-bordered"">
                                                        <thead>
                                                  ");
            WriteLiteral(@"          <tr>
                                                                <th>Id</th>
                                                                <th>Nome da Série</th>
                                                                <th>Repetições</th>
                                                            </tr>
                                                        </thead>

                                                        <tbody id=""BodySeriesTable"">
                                                           
                                                        </tbody>
                                                    </table>

                                                    <div id=""ExerciciosTable"">
                                                       
                                                    </div>
                                                </div>
                                            </div>
                                        <");
            WriteLiteral(@"/div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>

<div class=""overlay""></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auxiliary.Partial.PartialCollectionProfessorAluno> Html { get; private set; }
    }
}
#pragma warning restore 1591
