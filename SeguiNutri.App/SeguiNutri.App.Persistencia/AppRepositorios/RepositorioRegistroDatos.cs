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

        void IRepositorioRegistroDatos.DeleteRegistroDatos(string IdPaciente, string Id)
        {
            var RegistroDatosAgregado = _appContext.RegistrosDatos.FirstOrDefault(p , y => p.Id == Id && y.IdPaciente == IdPaciente);
            if(RegistroDatosAgregado == null)
                return;
            _appContext.RegistrosDatos.Remove(RegistroDatosAgregado);
            _appContext.SaveChanges();            
        }

        IEnumerable<RegistroDatos> IRepositorioRegistroDatos.GetAllRegistrosDatos()
        {
            return _appContext.RegistrosDatos;
        }

        RegistroDatos IRepositorioRegistroDatos.GetRegistroDatos(string IdPaciente , string Id)
        {
            var RegistroDatosAgregado = _appContext.RegistrosDatos.FirstOrDefault(p , y => p.Id == Id && y.IdPaciente == IdPaciente);
            return RegistroDatosAgregado;
        }

        RegistroDatos IRepositorioRegistroDatos.UpdateRegistroDatos(RegistroDatos registroDatos)
        {
            var RegistroDatosEncontrado = _appContext.RegistrosDatos.FirstOrDefault(p => p.Id == registroDatos.Id);
            if (RegistroDatosEncontrado != null)
            {
                RegistroDatosEncontrado.Id = registroDatos.Id;
                RegistroDatosEncontrado.IdPaciente = registroDatos.IdPaciente;
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