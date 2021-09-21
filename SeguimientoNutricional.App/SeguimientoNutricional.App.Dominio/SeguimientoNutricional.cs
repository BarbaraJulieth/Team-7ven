using system;
namespace SeguimientoNutricional.App.Dominio
{    

    public class SeguimientoNutricional
    {
        public char IdSeguimiento { get; set; }
        public char IdNutricionista { get; set; }
        public char IdCoach { get; set; }
        public char IdPaciente { get; set; }
        public string SugerenciasCuid { get; set; }
        
        /// Relacion entre SeguimientoNutricional e HistoricoBasico
        public HistoricoBasico HistoricoB { get; set; }

        
    }
}