#pragma checksum "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbbbcb1661fa4fbdced38bd665889f7e1e91df15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\_ViewImports.cshtml"
using AngSoz.BirthdayManager.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\_ViewImports.cshtml"
using AngSoz.BirthdayManager.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbbbcb1661fa4fbdced38bd665889f7e1e91df15", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"effb8364e69518036f0e4dc089b69971b806c57e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AngSoz.BirthdayManager.Web.Models.PessoasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/vela.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("vela"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("min-width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>
    <div class=""row"">
        <div class=""col-sm-12 col-lg-12 text-center"">
            <h2><strong>Seja bem-vindo :)</strong></h2>
        </div>
    </div>
    <div id=""page-content"">

        <div class=""row"">
            <div class=""col-sm-6 col-lg-4"">
                <a href=""javascript:void(0)"" class=""widget"">
                    <div class=""widget-content widget-content-mini text-right clearfix"">
                        <div class=""widget-icon pull-left themed-background-success"">
                            <i class=""gi gi-user text-light-op""></i>
                        </div>
                        <h2 class=""widget-heading h3 text-success"">
                            <strong><span data-toggle=""counter"" data-to=""");
#nullable restore
#line 23 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                                    Write(ViewBag.CountPessoa);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></span></strong>
                        </h2>
                        
                        <span class=""text-muted"">PESSOAS CADASTRADAS</span>
                    </div>
                </a>
            </div>
            <div class=""col-sm-6 col-lg-4"">
                <a href=""javascript:void(0)"" class=""widget"">
                    <div class=""widget-content widget-content-mini text-right clearfix"">
                        <div class=""widget-icon pull-left themed-background-warning"">
                            <i class=""fa fa-gift text-light-op""></i>
                        </div>
                        <h2 class=""widget-heading h3 text-warning"">
                            <strong><span data-toggle=""counter"" data-to=""");
#nullable restore
#line 37 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                                    Write(ViewBag.CountPresentes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></span></strong>
                        </h2>
                        <span class=""text-muted"">PRESENTES CADASTRADOS</span>
                    </div>
                </a>
            </div>
            <div class=""col-sm-6 col-lg-4"">
                <a href=""javascript:void(0)"" class=""widget"">
                    <div class=""widget-content widget-content-mini text-right clearfix"">
                        <div class=""widget-icon pull-left themed-background-danger"">
                            <i class=""fa fa-birthday-cake text-light-op""></i>
                        </div>
                        <h2 class=""widget-heading h3 text-danger"">
                            <strong><span data-toggle=""counter"" data-to=""");
#nullable restore
#line 50 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                                    Write(ViewBag.CountAniversarioDia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></span></strong>
                        </h2>
                        
                        <span class=""text-muted"">ANIVERSÁRIO HOJE</span>
                    </div>
                </a>
            </div>
        </div>


        <div class=""row"">
");
            WriteLiteral(@"            <div class=""col-sm-6 col-lg-8"">
                <div class=""widget"">
                    <div class=""widget-content border-bottom"">
                        <span class=""pull-right text-muted""><i class=""fa fa-sort-amount-desc""></i></span> <strong>Aniversários ordenados por data</strong>
                    </div>
                    <div class=""widget-content border-bottom themed-background-muted"">

                        <table class=""table table-hover"" style=""margin-top:5px;"">
                            <thead style=""background-color: #5ccdde"">
                                <tr class=""text-white"">
                                    <th class=""border"">Nome</th>
                                    <th class=""border"">Sobrenome</th>
                                    <th class=""border"">Data de nascimento</th>
                                    <th class=""border"">Idade</th>
                                </tr>
                            </thead>
                            <tb");
            WriteLiteral("ody>\r\n");
#nullable restore
#line 79 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                 foreach (var pessoa in Model.AniversarioOrdem)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 82 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                       Write(pessoa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"bg-light2\">");
#nullable restore
#line 83 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                         Write(pessoa.SobreNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 84 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                        Write(pessoa.DataNascimento.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"bg-light2\"> ");
#nullable restore
#line 85 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                          Write(pessoa.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" anos</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 87 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral("            <div class=\"col-sm-4\">\r\n                <div class=\"widget\">\r\n                \r\n                    <div class=\"widget-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbbbcb1661fa4fbdced38bd665889f7e1e91df1511604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""widget-image-content"">
                            <h2 class=""widget-heading""><span class=""text-light""><strong>Envelhecer é como velejar, você não pode parar o vento, mas, </strong></span></h2>
                            <h3 class=""widget-heading text-light-op h4"">pode direcionar a vela para que o vento lhe seja favorável.</h3>
                        </div>
                       
                    </div>
                    <div class=""widget-content widget-content-full text-dark"">
                        <div class=""row text-center"">
                            <p style=""padding-top:15px""> Viva e saiba viver! </p>
                        </div>
                    </div>

                </div>
            </div>

        </div>

        <div class=""row"">

");
            WriteLiteral(@"            <div class=""col-sm-5 col-lg-5"">
                <div class=""widget"">
                    <div class=""widget-content border-bottom"">
                        <span class=""pull-right text-muted""><i class=""fa fa-calendar-check-o""></i></span> <strong>Aniversariantes do dia</strong>
                    </div>
                    <div class=""widget-content border-bottom themed-background-muted"">

                        <table class=""table table-hover"" style=""margin-top:5px;"">
                            <thead style=""background-color: #5ccdde"">
                                <tr class=""text-white"">
                                    <th class=""border"">Nome</th>
                                    <th class=""border"">Sobrenome</th>
                                    <th class=""border"">Data de nascimento</th>
                                    <th class=""border"">Idade</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 138 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                 foreach (var x in Model.AniversarioDia)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 141 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                       Write(x.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"bg-light2\">");
#nullable restore
#line 142 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                         Write(x.SobreNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 143 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                        Write(x.DataNascimento.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"bg-light2\">");
#nullable restore
#line 144 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                         Write(x.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" anos</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 146 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral(@"            <div class=""col-sm-7 col-lg-7"">
                <div class=""widget"">
                    <div class=""widget-content border-bottom"">
                        <span class=""pull-right text-muted""><i class=""fa fa-gift""></i></span> <strong>Lista de presente</strong>
                    </div>
                    <div class=""widget-content border-bottom themed-background-muted"">

                        <table class=""table table-hover"" style=""margin-top:5px;"">
                            <thead style=""background-color: #5ccdde"">
                                <tr class=""text-white"">
                                    <th class=""border"">Presente</th>
                                    <th class=""border"">Valor</th>
                                    <th class=""border"">Para quem?</th>
                                    <th class=""border"">Idade</th>
                                    <th class=""border"">Data de Nascimento</th>
                                </tr>
                       ");
            WriteLiteral("     </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 173 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                 foreach (var p in Model.OrdemDatePresente)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 176 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                       Write(p.NomePresente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"bg-light2\">R$ ");
#nullable restore
#line 177 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                            Write(p.ValorPresente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 178 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                       Write(p.Pessoas.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"bg-light2\"> ");
#nullable restore
#line 179 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                                          Write(p.Pessoas.Idade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" anos</td>\r\n                                        <td> ");
#nullable restore
#line 180 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                         Write(p.Pessoas.DataNascimento.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 182 "D:\respositorio_vs\source\AngSoz.BirthdayManager\AngSoz.BirthdayManager.Web\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AngSoz.BirthdayManager.Web.Models.PessoasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591