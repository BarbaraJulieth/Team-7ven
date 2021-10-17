using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SeguiNutri.App.Dominio;
using SeguiNutri.App.Persistencia;

namespace SeguiNutri.App.Frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;

        public Paciente Paciente {get;set;}
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente=_repoPaciente;
            _logger = logger;
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
            return RedirectToPage("Pacientes/");
        }

        public IActionResult OnGetLogin(string email, string password)
        {
            Paciente = _repoPaciente.GetLogin(email,password );
            if(Paciente == null)
            {
                Console.WriteLine("No entro");
                return RedirectToPage("./Index");
                
            }
            else
            return Page();
        }

    }
}
