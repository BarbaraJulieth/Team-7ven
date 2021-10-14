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
        private readonly IRepositorioRegistroDatos _repoRegistroDatos;

        public  IEnumerable<Paciente> Paciente{get; set;}

        public RegistrarModel (IRepositorioPaciente _repoPaciente,IRepositorioRegistroDatos _repoRegistroDatos)
        {
            this._repoPaciente=_repoPaciente;
            this._repoRegistroDatos=_repoRegistroDatos;
        }

        public void OnGet()
        {
            Paciente= _repoPaciente.GetAllPacientes();
        }    

        
        
    }
}
