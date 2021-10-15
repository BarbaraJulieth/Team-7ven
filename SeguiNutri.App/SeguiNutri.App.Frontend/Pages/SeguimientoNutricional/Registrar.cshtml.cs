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

        public  IEnumerable<Paciente> Paciente{get; set;}

        public SeguimientoNutris SeguimientoNutris{get;set;}

        public RegistrarModel (IRepositorioPaciente _repoPaciente,IRepositorioSeguimientoNutricional _repoSeguimientoNutricional)
        {
            this._repoPaciente=_repoPaciente;
            this._repoSeguimientoNutricional=_repoSeguimientoNutricional;
        }

        public void OnGet()
        {
            SeguimientoNutris = new SeguimientoNutris();
            Paciente= _repoPaciente.GetAllPacientes();
        }    

        
        
    }
}
