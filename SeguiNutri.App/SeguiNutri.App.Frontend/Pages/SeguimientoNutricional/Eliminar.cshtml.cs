using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiNutri.App.Dominio;
using SeguiNutri.App.Persistencia;

namespace SeguiNutri.App.Frontend.Pages.SeguimientoNutricional
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioSeguimientoNutricional _repoSeguimientoNutricional;
        public SeguimientoNutris SeguimientoNutris { get; set;}

        public EliminarModel(IRepositorioSeguimientoNutricional _repoSeguimientoNutricional)
        {
            this._repoSeguimientoNutricional=_repoSeguimientoNutricional;
        }
        public IActionResult OnGet(int IdPaciente)
        {
            SeguimientoNutris = _repoSeguimientoNutricional.GetSeguimientoNutris(IdPaciente);
            if(SeguimientoNutris == null)
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
            _repoSeguimientoNutricional.DeleteSeguimientoNutris(Id);
            return RedirectToPage("Detalle");
        }
    }
}
