using System;
namespace SeguiNutri.App.Dominio
{    

    public class SeguimientoNutris
    {
        public int Id { get; set; }
        public int IdNutricionista { get; set; }
        public int IdCoach { get; set; }
        public int IdPaciente { get; set; }
        public string SugerenciasCuid { get; set; }
        
        /// Relacion entre SeguimientoNutricional e HistoricoBasico
        public HistoricoBasico HistoricoBasicoPaciente { get; set; }
        
        
        
    }
}
