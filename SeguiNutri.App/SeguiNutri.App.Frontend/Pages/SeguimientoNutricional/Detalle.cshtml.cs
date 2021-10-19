using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiNutri.App.Dominio;
using SeguiNutri.App.Persistencia;


namespace SeguiNutri.App.Frontend.Pages
{
    public class DetalleModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioSeguimientoNutricional _repoSeguimientoNutricional;

        public Paciente paciente {get; set;}
        
        public IEnumerable<SeguimientoNutris> SeguimientoNutris{get; set;}
 

        public DetalleModel(IRepositorioSeguimientoNutricional _repoSeguimientoNutricional,IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente=_repoPaciente;
            this._repoSeguimientoNutricional =_repoSeguimientoNutricional;
     
        }
        public void OnGet(int id)
        {
            /*  if(pacienteId.HasValue)
            {
                paciente=_repoPaciente.GetPaciente(pacienteId.Value);
            }
            if(paciente == null)
            {
                RedirectToPage("./NotFound");
            }
            else */
            {
                SeguimientoNutris = _repoSeguimientoNutricional.GetAllSeguimientoNutris(id);
            }
            
        }
    }       
}

