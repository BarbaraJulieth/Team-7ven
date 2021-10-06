using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia
{
    public class RepositorioHistoricoDatos : IRepositorioHistoricoDatos
    {
        private readonly AppContext _appContext;
        public RepositorioHistoricoDatos(AppContext appContext)
        {
            _appContext = appContext;
        }

        HistoricoDatos IRepositorioHistoricoDatos.AddHistoricoDatos(HistoricoDatos historicoDatos)
        {
            var historicoDatosAdicionado = _appContext.HistoricosDatos.Add(historicoDatos);
            _appContext.SaveChanges();
            return historicoDatosAdicionado.Entity;
        }

        void IRepositorioHistoricoDatos.DeleteHistoricoDatos(int id)
        {
            var historicoDatosEncontrado = _appContext.HistoricosDatos.FirstOrDefault(p => p.Id == id);
            if(historicoDatosEncontrado == null)
                return;
            _appContext.HistoricosDatos.Remove(historicoDatosEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<HistoricoDatos> IRepositorioHistoricoDatos.GetAllHistoricosDatos()
        {
           return _appContext.HistoricosDatos;
        }

        HistoricoDatos IRepositorioHistoricoDatos.GetHistoricoDatos(int id)
        {
            return _appContext.HistoricosDatos.FirstOrDefault(p => p.Id == id);
        }

        HistoricoDatos IRepositorioHistoricoDatos.UpdateHistoricoDatos(HistoricoDatos historicoDatos)
        {
            var historicoDatosEncontrado = _appContext.HistoricosDatos.FirstOrDefault(p => p.Id == historicoDatos.Id);
            if (historicoDatosEncontrado!=null)
            {
                historicoDatosEncontrado.IdRegistro=historicoDatos.IdRegistro;
                historicoDatosEncontrado.IdPaciente=historicoDatos.IdPaciente;
                historicoDatosEncontrado.SeguimientoNutricionalPaciente=historicoDatos.SeguimientoNutricionalPaciente;
                historicoDatosEncontrado.Registro=historicoDatos.Registro;
                historicoDatosEncontrado.HistoricoBasicoPaciente=historicoDatos.HistoricoBasicoPaciente;

                _appContext.SaveChanges();
            }
            return historicoDatosEncontrado;
        }
    }
}