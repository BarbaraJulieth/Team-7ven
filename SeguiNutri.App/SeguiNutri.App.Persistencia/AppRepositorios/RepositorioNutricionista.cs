using System.Collections.Generic;
using SeguiNutri.App.Dominio;
using System.Linq;
using System;

namespace SeguiNutri.App.Persistencia.AppRepositorios
{
    public class RepositorioNutrucionista : IRepositorioNutricionista
    {
        private readonly AppContext _appContext;

        /* public RepositorioNutrucionista (AppContext _appContext)
        {
            this._appContext=_appContext;
        }    */

        Nutricionista IRepositorioNutricionista.AddNutricionista(Nutricionista nutricionista)
        {
            var nutricionistaEncontrado = _appContext.Nutricionistas.Add(nutricionista);
            _appContext.SaveChanges();
            return nutricionistaEncontrado.Entity;
        }
        void IRepositorioNutricionista.DeleteNutricionista(int IdNutricionista)
        {
            var nutricionistaEncontrado = _appContext.Nutricionistas.FirstOrDefault(p => p.Id == IdNutricionista);
            if(nutricionistaEncontrado == null)
                return;
            _appContext.Nutricionistas.Remove(nutricionistaEncontrado);
            _appContext.SaveChanges();    
        }

        IEnumerable<Nutricionista> IRepositorioNutricionista.GetAllNutricionista()
        {
            return _appContext.Nutricionistas;
        }

        Nutricionista IRepositorioNutricionista.GetNutricionista(int IdNutricionista)
        {
            var nutricionistaEncontrado = _appContext.Nutricionistas.FirstOrDefault(p => p.Id ==IdNutricionista);
            return nutricionistaEncontrado;
        }

        Nutricionista IRepositorioNutricionista.UpdateNutricionista(Nutricionista nutricionista)
        {
            var nutricionistaEncontrado = _appContext.Nutricionistas.FirstOrDefault(p => p.Id ==nutricionista.Id);
            if(nutricionistaEncontrado != null)
            {
                nutricionistaEncontrado.Id=nutricionista.Id;
                nutricionistaEncontrado.Cedula=nutricionista.Cedula;
                nutricionistaEncontrado.Nombre=nutricionista.Nombre;
                nutricionistaEncontrado.Apellido=nutricionista.Apellido;
                nutricionistaEncontrado.FechaNacimiento=nutricionista.FechaNacimiento;
                nutricionistaEncontrado.Correo=nutricionista.Correo;
                nutricionistaEncontrado.Telefono=nutricionista.Telefono;

                nutricionistaEncontrado.IdNutricionista=nutricionista.IdNutricionista;
                
                _appContext.SaveChanges();
            }
            return nutricionistaEncontrado;
        }
    }
}