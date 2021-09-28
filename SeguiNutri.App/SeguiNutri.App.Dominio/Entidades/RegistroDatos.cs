using system;


namespace SeguimientoNutricional.App.Dominio
{
    
    public class RegistroDatos
    {
        public char Id_Paciente { get; set; }
        public char Id_Registro { get; set; }
        public Date Fecha_Registro { get; set; }
        public int  CaloriasConsumi { get; set; }
        public int  ProteinaConsumi { get; set; }
        public int  CarbohidratosConsumi { get; set; }
        public int  GrasaConsumi { get; set; }
        public int  Peso { get; set; }
        public int  MedidasAntropometricas { get; set; }
    }
}