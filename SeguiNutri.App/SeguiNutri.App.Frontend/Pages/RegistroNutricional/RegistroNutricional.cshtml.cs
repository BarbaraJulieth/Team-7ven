using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiNutri.App.Dominio;
using SeguiNutri.App.Persistencia;


namespace SeguiNutri.App.Frontend.Pages.RegistroNutricional
{
    public class RegistroNutricionalModel : PageModel
    {
        private readonly IRepositorioRegistroDatos _repoRegistroDatos;
        public RegistroDatos registroDatos {get; set;}
        public RegistroNutricionalModel (IRepositorioRegistroDatos _repoRegistroDatos)
        {
            this._repoRegistroDatos=_repoRegistroDatos;
        }
        public void OnGet()
        {
            registroDatos = new RegistroDatos();
        }

         public IActionResult OnPost(RegistroDatos RegistroDatos)
        {
            _repoRegistroDatos.AddRegistroDatos(RegistroDatos);
            return RedirectToPage("Intro");
        }
        
    }
}
