#pragma checksum "C:\Users\PICHAU\Desktop\Projetos\GIT\DataRecruiters\DataRecruiters\Pages\CadastrarTalento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6693d2e03eced4f17b4a0be7b5e29a56fde36ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DataRecruiters.Pages.Pages_CadastrarTalento), @"mvc.1.0.razor-page", @"/Pages/CadastrarTalento.cshtml")]
namespace DataRecruiters.Pages
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
#line 1 "C:\Users\PICHAU\Desktop\Projetos\GIT\DataRecruiters\DataRecruiters\Pages\_ViewImports.cshtml"
using DataRecruiters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PICHAU\Desktop\Projetos\GIT\DataRecruiters\DataRecruiters\Pages\_ViewImports.cshtml"
using ShieldUI.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6693d2e03eced4f17b4a0be7b5e29a56fde36ca", @"/Pages/CadastrarTalento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92538dc0b0e1fb8b9ba807e72b9a602b99ab51ec", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CadastrarTalento : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Form.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6693d2e03eced4f17b4a0be7b5e29a56fde36ca4707", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h3 class=\"display-4\">Fa??a sua voz ser ouvida!</h3>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6693d2e03eced4f17b4a0be7b5e29a56fde36ca6049", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\PICHAU\Desktop\Projetos\GIT\DataRecruiters\DataRecruiters\Pages\CadastrarTalento.cshtml"
      
        string[] estados =  {"AC",
                             "AL",
                             "AP",
                             "AM",
                             "BA",
                             "CE",
                             "DF",
                             "ES",
                             "GO",
                             "MA",
                             "MT",
                             "MS",
                             "MG",
                             "PA",
                             "PB",
                             "PR",
                             "PE",
                             "PI",
                             "RJ",
                             "RN",
                             "RS",
                             "RO",
                             "RR",
                             "SC",
                             "SP",
                             "SE",
                             "TO" };
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <h4>Identifica????o</h4>

    <div class=""col-md-12"">
        <label for=""inputName"" class=""form-label"">Nome Completo</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>
    <div class=""col-12"">
        <label for=""inputAddress"" class=""form-label"">Endere??o</label>
        <input type=""text"" class=""form-control"" id=""inputAddress"">
    </div>

    <div class=""col-md-8"">
        <label for=""inputCity"" class=""form-label"">Cidade</label>
        <input type=""text"" class=""form-control"" id=""inputCity"">
    </div>
    <div class=""col-md-2"">
        <label for=""inputState"" class=""form-label"">UF</label>
        <select id=""inputState"" class=""form-control"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6693d2e03eced4f17b4a0be7b5e29a56fde36ca8278", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\PICHAU\Desktop\Projetos\GIT\DataRecruiters\DataRecruiters\Pages\CadastrarTalento.cshtml"
             foreach (var item in estados)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6693d2e03eced4f17b4a0be7b5e29a56fde36ca9858", async() => {
#nullable restore
#line 66 "C:\Users\PICHAU\Desktop\Projetos\GIT\DataRecruiters\DataRecruiters\Pages\CadastrarTalento.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\PICHAU\Desktop\Projetos\GIT\DataRecruiters\DataRecruiters\Pages\CadastrarTalento.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </select>
    </div>
    <div class=""col-md-2"">
        <label for=""inputCep"" class=""form-label"">CEP</label>
        <input type=""text"" class=""form-control"" id=""inputCep"">
    </div>

    <div class=""col-6"">
        <label for=""inputEmail4"" class=""form-label"">Email</label>
        <input type=""email"" class=""form-control"" id=""inputEmail4"" placeholder=""name@example.com"">
    </div>

    <div class=""col-6"">
        <label for=""inputFone"" class=""form-label"">Telefone</label>
        <input type=""tel"" class=""form-control"" id=""inputFone"" placeholder=""(00) 0000-0000"">
    </div>

    <h4>Experi??ncias Profissionais</h4>

    <!-- VAI PRO MODAL
    <div class=""col-md-12"">
        <label for=""inputName"" class=""form-label"">Local de Trabalho</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>

    <div class=""col-md-6"">
        <label for=""inputName"" class=""form-label"">In??cio</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </d");
                WriteLiteral(@"iv>

    <div class=""col-md-6"">
        <label for=""inputName"" class=""form-label"">Fim</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>
    -->

    <div class=""col-12"">
        <button class=""btn btn-primary"" style=""margin-bottom: 15px;"">
            Adicionar novo
        </button>
    </div>

    <table class=""table"" style=""margin-left: 15px;"">
        <thead class=""table-primary"">
            <tr>
                <td class=""col-5"" scope=""col"">Local</td>
                <td class=""col-2"" scope=""col"">In??cio</td>
                <td class=""col-2"" scope=""col"">Fim</td>
                <td class=""col-3"" scope=""col"">A??oes</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>BBBBB</td>           <!-- COLUMN 2 -->
                <td>CCCCCC</td>          <!-- COLUMN 3 -->
                <td>DDDDDDD</td>         <!-- COLUMN 4 -->
                <td>
                    <!-- COLUMN BUTTONS -->
                   ");
                WriteLiteral(@" <button type=""button"" class=""btn btn-warning"">Alterar</button>
                    <button type=""button"" class=""btn btn-warning"">Remover</button>
                </td>
            </tr>
        </tbody>
    </table>


    <h4>Habilidades e Qualifica????es</h4>

    <!-- VAI PRO MODAL
    <div class=""col-md-12"">
        <label for=""inputName"" class=""form-label"">Local de Trabalho</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>

    <div class=""col-md-6"">
        <label for=""inputName"" class=""form-label"">In??cio</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>

    <div class=""col-md-6"">
        <label for=""inputName"" class=""form-label"">Fim</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>
    -->

    <div class=""col-12"">
        <button class=""btn btn-primary"" style=""margin-bottom: 15px;"">
            Adicionar novo
        </button>
    </div>

    <table class=""table"" style=""ma");
                WriteLiteral(@"rgin-left: 15px;"">
        <thead class=""table-primary"">
            <tr>
                <td class=""col-5"" scope=""col"">Nome</td>
                <td class=""col-4"" scope=""col"">Certificado</td>
                <td class=""col-3"" scope=""col"">A??oes</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>BBBBB</td>           <!-- COLUMN 2 -->
                <td>CCCCCC</td>          <!-- COLUMN 3 -->
                <td>
                    <!-- COLUMN BUTTONS -->
                    <button type=""button"" class=""btn btn-warning"">Alterar</button>
                    <button type=""button"" class=""btn btn-warning"">Remover</button>
                </td>
            </tr>
        </tbody>
    </table>

    <h4>Suas Redes</h4>
    <div class=""col-md-10""></div>

    <div class=""col-md-4"">
        <label for=""inputName"" class=""form-label"">LinkedIn</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>

    <div class=""col-md-4"">
");
                WriteLiteral(@"        <label for=""inputName"" class=""form-label"">Github</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>

    <div class=""col-md-4"">
        <label for=""inputName"" class=""form-label"">Website</label>
        <input type=""text"" class=""form-control"" id=""inputName"">
    </div>


    <div class=""col-12"">
        <button type=""submit"" class=""btn btn-primary"" style="" float: right; margin-top: 15px;"">Cadastrar</button>
    </div>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataRecruiters.Pages.CadastrarTalentoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DataRecruiters.Pages.CadastrarTalentoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DataRecruiters.Pages.CadastrarTalentoModel>)PageContext?.ViewData;
        public DataRecruiters.Pages.CadastrarTalentoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
