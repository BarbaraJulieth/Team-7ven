using System;
namespace SeguiNutri.App.Dominio
{
    
    public class HistoricoDatos
    {
        public int Id { get; set; }

        public int IdRegistro { get; set; }
        public int IdPaciente { get; set; }
        
        /// Relacion entre HistoricoDatos e SeguimientoNutri
        public SeguimientoNutris SeguimientoNutricionalPaciente { get; set; }
        /// Relacion entre HistoricoDatos y RegistroDatos
        public RegistroDatos Registro { get; set; }
        /// Relacion entre HistoricoDatos e HistoricoBasico
        public HistoricoBasico HistoricoBasicoPaciente { get; set; }
    }
}
