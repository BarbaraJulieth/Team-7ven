using System;


namespace SeguiNutri.App.Dominio
{
    
    public class RegistroDatos
    {
        public int Id_Paciente { get; set; }
        public int Id { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public double  CaloriasConsumi { get; set; }
        public double  ProteinaConsumi { get; set; }
        public double  CarbohidratosConsumi { get; set; }
        public double  GrasaConsumi { get; set; }
        public double  Peso { get; set; }
        public double  MedidasAntropometricas { get; set; }
    }
}