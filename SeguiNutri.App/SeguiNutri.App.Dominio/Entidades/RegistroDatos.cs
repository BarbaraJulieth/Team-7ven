using System;
using System.ComponentModel.DataAnnotations;



namespace SeguiNutri.App.Dominio
{
    
    public class RegistroDatos
    {
        public int Id_Paciente { get; set; }

        public int Id { get; set; }
        public DateTime Fecha_Registro { get; set; }
        [Range(0,500)]
        public double  CaloriasConsumi { get; set; }
        [Range(0,500)]
        public double  ProteinaConsumi { get; set; }
        [Range(0,500)]
        public double  CarbohidratosConsumi { get; set; }
        [Range(0,500)]
        public double  GrasaConsumi { get; set; }
        [Range(0,500)]
        public double  Peso { get; set; }
        [Range(0,500)]
        public double  MedidasAntropometricas { get; set; }

        
    }
}