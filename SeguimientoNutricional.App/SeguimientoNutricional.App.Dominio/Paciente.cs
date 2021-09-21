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
        public Coach NutricionistaAsignadoPAciente { get; set;}


    }


}