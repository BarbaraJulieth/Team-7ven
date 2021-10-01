using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;

namespace SeguiNutri.App.Persistencia
{

    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;
        public RepositorioPaciente(AppContext _appContext)
        {
            this._appContext=_appContext;
        }

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
           var pacienteAdicionado =  _appContext.Pacientes.Add(paciente);
           _appContext.SaveChanges();
           return pacienteAdicionado.Entity;
        }

        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
        
            return _appContext.Pacientes;

        }

       
        Paciente IRepositorioPaciente.GetPaciente(int IdPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == IdPaciente);
            return pacienteEncontrado;
        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
           var pacienteEncontrado=_appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado!=null)
            {
                pacienteEncontrado.IdPaciente=paciente.IdPaciente;
                pacienteEncontrado.Contraseña=paciente.Contraseña;
                pacienteEncontrado.Cedula=paciente.Cedula;
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellido=paciente.Apellido;
                pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
                pacienteEncontrado.Correo=paciente.Correo;
                pacienteEncontrado.Telefono=paciente.Telefono;
              
                pacienteEncontrado.Coach=paciente.Coach;
                pacienteEncontrado.Nutricionista=paciente.Nutricionista;
                pacienteEncontrado.SeguimientoNutris=paciente.SeguimientoNutris;
                pacienteEncontrado.Historia=paciente.Historia;

                _appContext.SaveChanges();
                
            }
            return pacienteEncontrado;
        }
    }
}