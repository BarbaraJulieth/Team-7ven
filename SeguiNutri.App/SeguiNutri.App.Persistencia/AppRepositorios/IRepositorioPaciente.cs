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

        // metodo de asignacion de nutricionista
        Nutricionista AsignarNutricionista (string IdPaciente , string IdNutricionista);
        // metodo de asignacion de Coach
        Coach AsignarCoach (string IdPaciente , string IdCoach);
        // Metodo de asignacion de registroDatos con paciente
        RegistroDatos AsignarRegistroDatos (string IdPaciente , string IdRegistroDatos);        
        // metodo de asignacion de SeguimientoNutris con el paciente
        SeguimientoNutris AsignarSeguimiPaciente (string IdPaciente, string IdSeguimientoNutri);
        // Metodo de asignacion del Historico Basico Con El Paciente
        HistoricoBasico AsignarHistoricoBasico      (string IdPaciente , string IdHistoricoBasico);
        // metodo de asignacion de Historico Datos con el Paciente
        HistoricoDatos AsignarHistoricoDatos (string IdPaciente , string IdHistoricoDatos);
    }
}