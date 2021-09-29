using System;

/// <summary> Paciente </summary>

namespace SeguiNutri.App.Dominio
{
    public class Paciente : Persona
    {
        public string IdPaciente { get; set; }
        public string Contraseña { get; set;}

        
        /// Relacion Entre Paciente y Coach
        public Coach CoachAsignadoPaciente { get; set;}

        /// Relacion Entre Paciente y Nutricionista
        public Nutricionista NutricionistaAsignadoPaciente { get; set;}

               
        /// Relacion Entre Paciente y SeguimientoNutricional
        public SeguimientoNutris SeguimientoNutricionalPaciente { get; set;}

        /// Relacion Entre Paciente y Registro de datos
        public RegistroDatos RegistroDatosPaciente { get; set;}  

        
    }


}