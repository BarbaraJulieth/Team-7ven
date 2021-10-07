using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeguiNutri.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiNutri.App.Dominio;
 
namespace SeguiNutri.App.Frontend.Pages.Pacientes
{
    public class RegistrarModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
 
        public Paciente Paciente {get;set;}
 
        public RegistrarModel(IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente=_repoPaciente;
        }
 
        public void OnGet()
        {
            Paciente = new Paciente();
        }
 
        public IActionResult OnPost(Paciente paciente)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _repoPaciente.AddPaciente(paciente);
            return RedirectToPage("Intro");
        }
 
    }
}

