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
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);

        // metodo de asignacion de nutricionista
        Nutricionista AsignarNutricionista (int IdPaciente , int IdNutricionista);
        // metodo de asignacion de Coach
        Coach AsignarCoach (int IdPaciente , int IdCoach);
        // Metodo de asignacion de registroDatos con paciente
        RegistroDatos AsignarRegistroDatos (int IdPaciente , int IdRegistroDatos);        
        // metodo de asignacion de SeguimientoNutris con el paciente
        SeguimientoNutris AsignarSeguimiPaciente (int IdPaciente, int IdSeguimientoNutri);
        // Metodo de asignacion del Historico Basico Con El Paciente
        HistoricoBasico AsignarHistoricoBasico      (int IdPaciente , int IdHistoricoBasico);
        // metodo de asignacion de Historico Datos con el Paciente
        HistoricoDatos AsignarHistoricoDatos (int IdPaciente , int IdHistoricoDatos);
    }
}