using System;
using SeguiNutri.App.Dominio;
using SeguiNutri.App.Persistencia;

namespace SeguiNutri.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPaciente();
        }

        private static void AddPaciente()
        {
            var  paciente = new Paciente{
                
                Cedula = "12354",
                Nombre="Nico",
                Apellido="Perez",
                FechaNacimiento = new DateTime(2020,01,01),
                Correo = "asdasd@asdasd.com",
                Telefono = "132154",
                IdPaciente = 01,
                Contraseña = "1234"
            };
            _repoPaciente.AddPaciente(paciente);
        }
    }
}
