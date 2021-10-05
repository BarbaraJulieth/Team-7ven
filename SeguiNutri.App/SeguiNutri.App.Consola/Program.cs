using System;

namespace SeguiNutri.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void AddPaciente()
        {
            Contraseña = "1234",
            Cedula = "12354",
            Nombre="Nico",
            Apellido="Perez",
            
            NumeroTelefono="3118237",
            Genero = Genero.masculino,
            Direccion="cra 117a",
            Longitud =8.50,
            Latitud = 4.50,
            Ciudad = "Bogota",
            FechaNacimiento = "12/01/1998"
        }
    }
}
