#pragma checksum "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57a297cc00bf0902585757a87896d916faceda2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SeguiNutri.App.Frontend.Pages.RegistroNutricional.Pages_RegistroNutricional_ListaRegistrosPaciente), @"mvc.1.0.razor-page", @"/Pages/RegistroNutricional/ListaRegistrosPaciente.cshtml")]
namespace SeguiNutri.App.Frontend.Pages.RegistroNutricional
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
#line 1 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\_ViewImports.cshtml"
using SeguiNutri.App.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
using SeguiNutri.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57a297cc00bf0902585757a87896d916faceda2", @"/Pages/RegistroNutricional/ListaRegistrosPaciente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f60b4e8a978e66e14fc9c8fe1186011a3471d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RegistroNutricional_ListaRegistrosPaciente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../RegistroNutricional/Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../RegistroNutricional/Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Pacientes/Intro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<h1>Lista Registros Nutricionales Paciente</h1>
<table class=""table table-striped table-bordered table condensed"" 
    style=""width:100"">
        <thead class=""text-center"">
            <tr>
                <th scope=""col"" >Id Registro Datos</th>
                <th scope=""col"" >Calorias Consumidas</th>
                <th scope=""col"" >Proteinas Consumidas</th>
                <th scope=""col"" >Peso Actual</th>
                <th scope=""col"" >Fecha Registro</th>
                <th scope=""col"" >Carbohidratos Consumidas</th>
                <th scope=""col"" >Grasas Consumidas</th>                
                <th scope=""col"" >Medidas Antropometricas</th>
                <th scope=""col"" >Edición</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
             foreach (var p in Model.registrosDatos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                   Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                   Write(p.CaloriasConsumi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                   Write(p.ProteinaConsumi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                   Write(p.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                   Write(p.Fecha_Registro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                   Write(p.CarbohidratosConsumi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                   Write(p.GrasaConsumi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                   Write(p.MedidasAntropometricas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div class=\"text-center\">\r\n                            <div class=\"btn-group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a57a297cc00bf0902585757a87896d916faceda29305", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                                                                                                      WriteLiteral(p.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a57a297cc00bf0902585757a87896d916faceda211678", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
                                                                                                       WriteLiteral(p.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        <div>     \r\n                    </td>           \r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\RegistroNutricional\ListaRegistrosPaciente.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>    \r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a57a297cc00bf0902585757a87896d916faceda214458", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeguiNutri.App.Frontend.Pages.RegistroNutricional.ListaRegistrosPacienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguiNutri.App.Frontend.Pages.RegistroNutricional.ListaRegistrosPacienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguiNutri.App.Frontend.Pages.RegistroNutricional.ListaRegistrosPacienteModel>)PageContext?.ViewData;
        public SeguiNutri.App.Frontend.Pages.RegistroNutricional.ListaRegistrosPacienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
