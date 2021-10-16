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
    public class RegistrarModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioSeguimientoNutricional _repoSeguimientoNutricional;
        private readonly IRepositorioNutricionista _repoNutricionista;

        public  IEnumerable<Paciente> Paciente{get; set;}

        public SeguimientoNutris SeguimientoNutris{get;set;}
        public Nutricionista Nutricionista {get;set;}

        public RegistrarModel (IRepositorioPaciente _repoPaciente,IRepositorioSeguimientoNutricional _repoSeguimientoNutricional,IRepositorioNutricionista _repoNutricionista)
        {
            this._repoPaciente=_repoPaciente;
            this._repoSeguimientoNutricional=_repoSeguimientoNutricional;
            this._repoNutricionista=_repoNutricionista;
        }

        public IActionResult OnGet(int id)
        {
            Nutricionista = _repoNutricionista.GetNutricionista(id);
            if(Nutricionista == null)
            {
                return NotFound ();
            }
            else
            {
                Paciente= _repoPaciente.GetAllPacientes();
                SeguimientoNutris = new SeguimientoNutris();

                return Page();
            }

        }    

        
        
    }
}
