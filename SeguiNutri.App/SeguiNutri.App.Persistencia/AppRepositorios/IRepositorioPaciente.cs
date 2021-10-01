using System.Collections.Generic;
using SeguiNutri.App.Dominio;
using System.Linq;

namespace SeguiNutri.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(string idPaciente);
        Paciente GetPaciente(string idPaciente);
    }
}