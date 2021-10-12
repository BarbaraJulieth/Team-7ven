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
    public class RegistroNutricionalModel : PageModel
    {
        private readonly IRepositorioRegistroDatos _repoRegistroDatos;
        public RegistroDatos registroDatos {get; set;}
        private readonly IRepositorioPaciente _repoPaciente;
 
        public Paciente paciente {get;set;}

        public RegistroNutricionalModel (IRepositorioRegistroDatos _repoRegistroDatos,IRepositorioPaciente _repoPaciente)
        {
            this._repoRegistroDatos=_repoRegistroDatos;
            this._repoPaciente=_repoPaciente;
        }
        public void OnGet(int id)
        {
            paciente =_repoPaciente.GetPaciente(id);
            registroDatos = new RegistroDatos();
           
        }

         public IActionResult OnPost(int id ,RegistroDatos RegistroDatos)
        {
            if(RegistroDatos.Id_Paciente == 0)
            {
                RegistroDatos.Id_Paciente = id;
                _repoRegistroDatos.AddRegistroDatos(RegistroDatos);
                return RedirectToPage("/Pacientes/Intro");
            }else
            {
                return NotFound();
            }
            
        }
        
    }
}
