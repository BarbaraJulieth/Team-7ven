using system;
namespace SeguimientoNutricional.App.Dominio
{
    /
    public class HistoricoDatos
    {
        public char IdHistoricoDatos { get; set; }
        public char IdRegistro { get; set; }
        public char IdPaciente { get; set; }
        
        /// Relacion entre HistoricoDatos e SeguimientoNutricional
        public SeguimientoNutricional Seguimiento { get; set; }
        /// Relacion entre HistoricoDatos y RegistroDatos
        public RegistroDatos Registro { get; set; }
        /// Relacion entre HistoricoDatos e HistoricoBasico
        public HistoricoBasico HistoricoB { get; set; }
    }
}