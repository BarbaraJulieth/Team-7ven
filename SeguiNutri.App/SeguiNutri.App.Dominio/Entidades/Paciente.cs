using System;

/// <summary> Paciente </summary>

namespace SeguimientoNutricional.App.Dominio
{
    public class Paciente : Persona
    {
        public int IdPaciente { get; set; }
        public varchar Contraseña { get; set;}

        
        /// Relacion Entre Paciente y Coach
        public Coach CoachAsignadoPaciente { get; set;}

        /// Relacion Entre Paciente y Nutricionista
        public Nutricionista NutricionistaAsignadoPaciente { get; set;}

               
        /// Relacion Entre Paciente y SeguimientoNutricional
        public SeguimientoNutricional SeguimientoNutricionalPaciente { get; set;}

        /// Relacion Entre Paciente y Registro de datos
        public RegistroDatos RegistroDatosPaciente { get; set;}  

        
    }


}