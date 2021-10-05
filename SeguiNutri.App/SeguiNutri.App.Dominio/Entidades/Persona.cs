using System;

/// <summary> Clase de la que se Heredan Paciente , Coach , Nutricionista </summary>
namespace SeguiNutri.App.Dominio
{
    
    public class Persona
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        
    }
}