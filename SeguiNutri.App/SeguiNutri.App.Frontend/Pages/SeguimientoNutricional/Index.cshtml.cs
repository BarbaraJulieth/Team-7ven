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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioNutricionista _repoNutricionista;
        private readonly IRepositorioSeguimientoNutricional _repoSeguimientoNutricional;
        private readonly IRepositorioCoach _repoCoach;


        public Paciente paciente {get; set;}
        public SeguimientoNutris SeguimientoNutris{get;set;}
        public Nutricionista Nutricionista{get; set;}
        public Coach Coach {get; set;}


        public IndexModel(IRepositorioPaciente _repoPaciente,IRepositorioSeguimientoNutricional _repoSeguimientoNutricional,IRepositorioNutricionista _repoNutricionista,IRepositorioCoach _repoCoach)
        {
            this._repoPaciente=_repoPaciente;
            this._repoSeguimientoNutricional =_repoSeguimientoNutricional;
            this._repoNutricionista=_repoNutricionista;
            this._repoCoach=_repoCoach;
        }
        public void OnGet(int id, int idPaciente)
        {           
            Nutricionista = _repoNutricionista.GetNutricionista(id);
            SeguimientoNutris = new SeguimientoNutris();
            paciente = _repoPaciente.GetPaciente(idPaciente);
            Coach = new Coach();
        }
        public IActionResult OnPost( int id , int idPaciente,SeguimientoNutris SeguimientoNutris)
        {

            if(SeguimientoNutris.IdNutricionista == 0 && SeguimientoNutris.IdPaciente == 0)
            {
                SeguimientoNutris.IdNutricionista = id;
                SeguimientoNutris.IdPaciente=idPaciente;
                //_repoSeguimientoNutricional.AddSeguimientoNutris(SeguimientoNutris);
                return RedirectToPage("/Nutricionistas/Index");
            }
            else
            {
                return NotFound();
            }            

        }
    }
}