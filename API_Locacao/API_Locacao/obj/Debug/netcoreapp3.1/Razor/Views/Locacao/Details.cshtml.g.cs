#pragma checksum "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c7eadf200d8f8f4a35727d7c7f3245e50d0715f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locacao_Details), @"mvc.1.0.view", @"/Views/Locacao/Details.cshtml")]
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
#line 1 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\_ViewImports.cshtml"
using API_Locacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\_ViewImports.cshtml"
using API_Locacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7eadf200d8f8f4a35727d7c7f3245e50d0715f", @"/Views/Locacao/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b0074945c159d2988dd25d96a741f246c5a7c46", @"/Views/_ViewImports.cshtml")]
    public class Views_Locacao_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API_Locacao.Models.Locacao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Locação</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataFinal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataFinal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorDiaria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorDiaria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cliente.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Produto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\felii\Desktop\Senff\API-Notebook\API_Locacao\API_Locacao\Views\Locacao\Details.cshtml"
       Write(Html.DisplayFor(model => model.Produto.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c7eadf200d8f8f4a35727d7c7f3245e50d0715f8540", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API_Locacao.Models.Locacao> Html { get; private set; }
    }
}
#pragma warning restore 1591
