using System;
namespace SeguiNutri.App.Dominio
{
    
    public class HistoricoDatos
    {
        public string IdHistoricoDatos { get; set; }
        
        public string IdRegistro { get; set; }
        public string IdPaciente { get; set; }
        
        /// Relacion entre HistoricoDatos e SeguimientoNutri
        public SeguimientoNutris SeguimientoNutricionalPaciente { get; set; }
        /// Relacion entre HistoricoDatos y RegistroDatos
        public RegistroDatos Registro { get; set; }
        /// Relacion entre HistoricoDatos e HistoricoBasico
        public HistoricoBasico HistoricoBasicoPaciente { get; set; }
    }
}
