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
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioRegistroDatos _repoRegistroDatos;
        public RegistroDatos registroDatos { get; set;}

        public EliminarModel(IRepositorioRegistroDatos _repoRegistroDatos)
        {
            this._repoRegistroDatos=_repoRegistroDatos;
        }
        public IActionResult OnGet(int Id)
        {
            registroDatos = _repoRegistroDatos.GetRegistroDatos(Id);
            if(registroDatos == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(int Id)
        {
            _repoRegistroDatos.DeleteRegistroDatos(Id);
            return RedirectToPage("../Pacientes/Intro");
        }
    }
}
