using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia
{
    public class RepositorioSeguimientoNutricional : IRepositorioSeguimientoNutricional
    {
        private readonly AppContext _appContext = new AppContext();

        SeguimientoNutris IRepositorioSeguimientoNutricional.AddSeguimientoNutris(SeguimientoNutris seguimientoNutris)
        {
            var SeguimientoNutrisAgregado = _appContext.SeguimientosNutri.Add(seguimientoNutris);
            _appContext.SaveChanges();
            return SeguimientoNutrisAgregado.Entity;
        }

        void IRepositorioSeguimientoNutricional.DeleteSeguimientoNutris(int Id)
        {
            var SeguimientoNutrisAgregado = _appContext.SeguimientosNutri.FirstOrDefault(p => p.Id == Id);
            if(SeguimientoNutrisAgregado == null)
                return;
            _appContext.SeguimientosNutri.Remove(SeguimientoNutrisAgregado);
            _appContext.SaveChanges();    
        }

        IEnumerable<SeguimientoNutris> IRepositorioSeguimientoNutricional.GetAllSeguimientoNutris(int IdPaciente)
        {
            var lista = _appContext.SeguimientosNutri.Where(p => p.IdPaciente == IdPaciente);
            return lista;
        }

        SeguimientoNutris IRepositorioSeguimientoNutricional.GetSeguimientoNutris(int IdPaciente)
        {
            var SeguimientoNutrisAgregado = _appContext.SeguimientosNutri.FirstOrDefault(p => p.IdPaciente == IdPaciente);
            return SeguimientoNutrisAgregado;
        }

        SeguimientoNutris IRepositorioSeguimientoNutricional.UpdateSeguimientoNutris(SeguimientoNutris seguimientoNutris)
        {   
            var SeguimientoNutrisEncontrado = _appContext.SeguimientosNutri.FirstOrDefault(p => p.Id == seguimientoNutris.Id);
            if(SeguimientoNutrisEncontrado!=null)
            {
                SeguimientoNutrisEncontrado.Id = seguimientoNutris.Id;
                SeguimientoNutrisEncontrado.IdNutricionista = seguimientoNutris.IdNutricionista;
                SeguimientoNutrisEncontrado.IdCoach = seguimientoNutris.IdCoach;
                SeguimientoNutrisEncontrado.IdPaciente = seguimientoNutris.IdPaciente;
                SeguimientoNutrisEncontrado.SugerenciasCuid = seguimientoNutris.SugerenciasCuid;

                SeguimientoNutrisEncontrado.HistoricoBasicoPaciente = seguimientoNutris.HistoricoBasicoPaciente;
                _appContext.SaveChanges();
            }
            return SeguimientoNutrisEncontrado;
        }       
    }
}