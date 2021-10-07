using System;
using System.ComponentModel.DataAnnotations;


/// <summary> Clase de la que se Heredan Paciente , Coach , Nutricionista </summary>
namespace SeguiNutri.App.Dominio
{
    
    public class Persona
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Cedula { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; }
        [Required, StringLength(50)]
        public string Apellido { get; set; }
        
        public DateTime FechaNacimiento { get; set; }
        [Required, StringLength(50)]
        public string Correo { get; set; }
        [Required, StringLength(50)]
        public string Telefono { get; set; }
        
    }
}