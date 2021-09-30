using System;
namespace SeguiNutri.App.Dominio
{    

    public class SeguimientoNutris
    {
        public string IdSeguimiento { get; set; }
        public string IdNutricionista { get; set; }
        public string IdCoach { get; set; }
        public string IdPaciente { get; set; }
        public string SugerenciasCuid { get; set; }
        
        /// Relacion entre SeguimientoNutricional e HistoricoBasico
        public HistoricoBasico HistoricoBasicoPaciente { get; set; }
        
        
        
    }
}
