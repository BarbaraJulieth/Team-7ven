using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia.AppRepositorios
{
    public class RepositorioRegistroDatos : IRepositorioRegistroDatos
    {
        private readonly AppContext _appContext;

        public RepositorioRegistroDatos(AppContext _appContext)
        {
            this._appContext=_appContext;
        }

        RegistroDatos IRepositorioRegistroDatos.AddRegistroDatos(RegistroDatos registroDatos)
        {
            var RegistroDatosAgregado = _appContext.RegistrosDatos.Add(registroDatos);
            _appContext.SaveChanges();
            return RegistroDatosAgregado.Entity;
        }

        void IRepositorioRegistroDatos.DeleteRegistroDatos(int IdPaciente, int Id)
        {
            var RegistroDatosAgregado = _appContext.RegistrosDatos.FirstOrDefault(p  => p.Id == Id );
            if(RegistroDatosAgregado == null)
                return;
            _appContext.RegistrosDatos.Remove(RegistroDatosAgregado);
            _appContext.SaveChanges();            
        }

        IEnumerable<RegistroDatos> IRepositorioRegistroDatos.GetAllRegistrosDatos()
        {
            return _appContext.RegistrosDatos;
        }

        RegistroDatos IRepositorioRegistroDatos.GetRegistroDatos(int IdPaciente , int Id)
        {
            var RegistroDatosAgregado = _appContext.RegistrosDatos.FirstOrDefault(p  => p.Id == Id );
            return RegistroDatosAgregado;
        }

        RegistroDatos IRepositorioRegistroDatos.UpdateRegistroDatos(RegistroDatos registroDatos)
        {
            var RegistroDatosEncontrado = _appContext.RegistrosDatos.FirstOrDefault(p  => p.Id == registroDatos.Id );
            if (RegistroDatosEncontrado != null)
            {
                RegistroDatosEncontrado.Id = registroDatos.Id;
                RegistroDatosEncontrado.Id_Paciente = registroDatos.Id_Paciente;
                RegistroDatosEncontrado.Fecha_Registro = registroDatos.Fecha_Registro;
                RegistroDatosEncontrado.CaloriasConsumi = registroDatos.CaloriasConsumi;
                RegistroDatosEncontrado.ProteinaConsumi = registroDatos.ProteinaConsumi;
                RegistroDatosEncontrado.CarbohidratosConsumi = registroDatos.CarbohidratosConsumi;
                RegistroDatosEncontrado.GrasaConsumi = registroDatos.GrasaConsumi;
                RegistroDatosEncontrado.Peso = registroDatos.Peso;
                RegistroDatosEncontrado.MedidasAntropometricas = registroDatos.MedidasAntropometricas;
                
                _appContext.SaveChanges();
            }
            return RegistroDatosEncontrado;
        }
    }
}