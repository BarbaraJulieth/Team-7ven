using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;


namespace SeguiNutri.App.Persistencia
{

    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext _appContext)
        {
            this._appContext =_appContext;

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
                
                pacienteEncontrado.CoachAsignadoPaciente=paciente.CoachAsignadoPaciente;
                pacienteEncontrado.NutricionistaAsignadoPaciente=paciente.NutricionistaAsignadoPaciente;
                pacienteEncontrado.RegistroDatosPaciente=paciente.RegistroDatosPaciente;
                pacienteEncontrado.SeguimientoNutrisPaciente=paciente.SeguimientoNutrisPaciente;
                pacienteEncontrado.HistoricoBasicoPaciente=paciente.HistoricoBasicoPaciente;
                pacienteEncontrado.HistoricoDatosPaciente=paciente.HistoricoDatosPaciente;
                

                _appContext.SaveChanges();
                
            }
            return pacienteEncontrado;
        }
        // metodo de asignacion de Nutricionista -- Paciente

        Nutricionista IRepositorioPaciente.AsignarNutricionista(int IdPaciente, int IdNutricionista)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == IdPaciente);
            if (pacienteEncontrado != null)       
            {
                var nutricionistaEncontrado = _appContext.Nutricionistas.FirstOrDefault(n => n.Id == IdNutricionista);
                if(nutricionistaEncontrado != null)
                {
                    pacienteEncontrado.NutricionistaAsignadoPaciente= nutricionistaEncontrado;
                    _appContext.SaveChanges();
                }
                return nutricionistaEncontrado;
            }
            return null;

        }

        // metodo de asignacion de coach Paciente

        Coach IRepositorioPaciente.AsignarCoach(int IdPaciente, int IdCoach)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id ==IdPaciente);
            if (pacienteEncontrado != null)
            {
                var coachEncontrado = _appContext.Coachs.FirstOrDefault(c => c.Id == IdCoach);
                if (coachEncontrado != null)
                {
                    pacienteEncontrado.CoachAsignadoPaciente=coachEncontrado;
                    _appContext.SaveChanges();
                }
                return coachEncontrado;
            }
            return null;

        }
        // metodo de asignacion de RegistroDatos a Paciente
        RegistroDatos IRepositorioPaciente.AsignarRegistroDatos(int IdPaciente, int IdRegistroDatos)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id ==IdPaciente);
            if (pacienteEncontrado != null)
            {
                var registroDatosEncontrado = _appContext.RegistrosDatos.FirstOrDefault(r => r.Id == IdRegistroDatos);
                if(registroDatosEncontrado != null)
                {
                    pacienteEncontrado.RegistroDatosPaciente= registroDatosEncontrado;
                    _appContext.SaveChanges();
                }
                return registroDatosEncontrado;
            }
            return null;

        }
        // metodo de asignacion de Histocio Basico Paciente

        HistoricoBasico IRepositorioPaciente.AsignarHistoricoBasico(int IdPaciente, int IdHistoricoBasico)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == IdPaciente);
            if(pacienteEncontrado != null)
            {
                var historicoBasicoEncontrado = _appContext.HistoricoBasicos.FirstOrDefault(h => h.Id == IdHistoricoBasico);
                if (historicoBasicoEncontrado != null)
                {
                    pacienteEncontrado.HistoricoBasicoPaciente = historicoBasicoEncontrado;
                    _appContext.SaveChanges();
                }
                return historicoBasicoEncontrado;
            }
            return null;
        }

        SeguimientoNutris IRepositorioPaciente.AsignarSeguimiPaciente(int IdPaciente, int IdSeguimientoNutri)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id ==IdPaciente);
            if (pacienteEncontrado != null)
            {
                var seguimientoNutriEncontrado = _appContext.SeguimientosNutri.FirstOrDefault(s => s.Id == IdSeguimientoNutri);
                if(seguimientoNutriEncontrado != null)
                {
                    pacienteEncontrado.SeguimientoNutrisPaciente = seguimientoNutriEncontrado;
                    _appContext.SaveChanges();
                }
                return seguimientoNutriEncontrado;
            }
            return null;
        }

        HistoricoDatos IRepositorioPaciente.AsignarHistoricoDatos(int IdPaciente, int IdHistoricoDatos)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id ==IdPaciente);
            if(pacienteEncontrado != null)
            {
                var historicoDatosEncontrado = _appContext.HistoricosDatos.FirstOrDefault(h => h.Id == IdHistoricoDatos);
                if(historicoDatosEncontrado != null)
                {
                    pacienteEncontrado.HistoricoDatosPaciente = historicoDatosEncontrado;
                    _appContext.SaveChanges();
                }
                return historicoDatosEncontrado;
            }
            return null;
        }

    }
}