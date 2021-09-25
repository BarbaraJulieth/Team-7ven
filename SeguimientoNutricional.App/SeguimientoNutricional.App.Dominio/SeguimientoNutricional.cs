using system;
namespace SeguimientoNutricional.App.Dominio
{    

    public class SeguimientoNutri
    {
        public char IdSeguimiento { get; set; }
        public char IdNutricionista { get; set; }
        public char IdCoach { get; set; }
        public char IdPaciente { get; set; }
        public string SugerenciasCuid { get; set; }
        
        /// Relacion entre SeguimientoNutricional e HistoricoBasico
        public HistoricoBasico HistoricoBasicoPaciente { get; set; }
        
        /// Relacion entre SeguimientoNutricional y Paciente
        public Paciente Paciente { get; set; }
        
    }
}
