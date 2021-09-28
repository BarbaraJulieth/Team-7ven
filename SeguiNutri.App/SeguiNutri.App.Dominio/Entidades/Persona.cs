using system;

/// <summary> Clase de la que se Heredan Paciente , Coach , Nutricionista </summary>
namespace SeguimientoNutricional.App.Dominio
{
    
    public class Persona
    {
        public int Id { get; set; }
        public char Cedula { get; set; }
        public char Nombre { get; set; }
        public char Apellido { get; set; }
        public Date FechaNacimiento { get; set; }
        public char Correo { get; set; }
        public char Telefono { get; set; }
        
    }
}