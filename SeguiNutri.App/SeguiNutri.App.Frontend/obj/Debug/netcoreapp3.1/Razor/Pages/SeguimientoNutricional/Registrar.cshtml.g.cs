#pragma checksum "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b3f89fdd88ef242755e908462271e846e8e0403"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SeguiNutri.App.Frontend.Pages.SeguimientoNutricional.Pages_SeguimientoNutricional_Registrar), @"mvc.1.0.razor-page", @"/Pages/SeguimientoNutricional/Registrar.cshtml")]
namespace SeguiNutri.App.Frontend.Pages.SeguimientoNutricional
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
#line 2 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
using SeguiNutri.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3f89fdd88ef242755e908462271e846e8e0403", @"/Pages/SeguimientoNutricional/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f60b4e8a978e66e14fc9c8fe1186011a3471d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SeguimientoNutricional_Registrar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<h1>Lista de Pacientes</h1>

<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""table-responsive"">
                <table id=""tablaPacientes"" class=""table table-striped table-bordered table condensed"" 
                style=""width:100"">
                    <thead class=""text-center"">
                        <tr>
                            <th scope=""col"" >Cedula</th>
                            <th scope=""col"" >Nombre</th>
                            <th scope=""col"" >Apellido</th>
                            <th scope=""col"" >Fecha Nacimiento</th>
                            <th scope=""col"" >Correo</th>
                            <th scope=""col"" >Telefono</th>
                            <th scope=""col"" >IdPaciente</th>
                            <th scope=""col"" >Contraseña</th>
                            <th scope=""col"" >Seguimiento Nutricional</th>
                        </tr>
                    </thead>
                    <tbod");
            WriteLiteral("y>\r\n");
#nullable restore
#line 29 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                         foreach (var p in Model.Paciente)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 32 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                           Write(p.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                           Write(p.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                           Write(p.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                           Write(p.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                           Write(p.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                           Write(p.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                           Write(p.IdPaciente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                           Write(p.Contraseña);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3f89fdd88ef242755e908462271e846e8e04038057", async() => {
                WriteLiteral("Registro Nutricional");
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
#line 40 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
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
            WriteLiteral("</td>\r\n                            \r\n                        </tr> \r\n");
#nullable restore
#line 43 "C:\SeguimientoNutricional\Team-7ven\SeguiNutri.App\SeguiNutri.App.Frontend\Pages\SeguimientoNutricional\Registrar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                    \r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeguiNutri.App.Frontend.Pages.SeguimientoNutricional.RegistrarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguiNutri.App.Frontend.Pages.SeguimientoNutricional.RegistrarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SeguiNutri.App.Frontend.Pages.SeguimientoNutricional.RegistrarModel>)PageContext?.ViewData;
        public SeguiNutri.App.Frontend.Pages.SeguimientoNutricional.RegistrarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
