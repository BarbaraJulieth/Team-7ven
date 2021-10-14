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
    public class ListaRegistrosPacienteModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioRegistroDatos _repoRegistroDatos;

        public Paciente paciente {get; set;}

        public IEnumerable<RegistroDatos> registrosDatos { get; set;}

        public ListaRegistrosPacienteModel (IRepositorioRegistroDatos _repoRegistroDatos,IRepositorioPaciente _repoPaciente)
        {
            this._repoRegistroDatos=_repoRegistroDatos;
            this._repoPaciente=_repoPaciente;
        }

        public void OnGet(int? pacienteId)
        {
            if(pacienteId.HasValue)
            {
                paciente=_repoPaciente.GetPaciente(pacienteId.Value);
            }
            if(paciente == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                registrosDatos = _repoRegistroDatos.GetAllRegistrosDatos(pacienteId.Value);
            }
            
        }
    }       
}
