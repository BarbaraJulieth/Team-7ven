using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiNutri.App.Persistencia;
using SeguiNutri.App.Dominio;

namespace SeguiNutri.App.Frontend.Pages
{
    public class IntroModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;

        public  IEnumerable<Paciente> Paciente{get; set;}

        public IntroModel (IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente=_repoPaciente;
        }

        public void OnGet()
        {
            Paciente= _repoPaciente.GetAllPacientes();
        }
    }
}
