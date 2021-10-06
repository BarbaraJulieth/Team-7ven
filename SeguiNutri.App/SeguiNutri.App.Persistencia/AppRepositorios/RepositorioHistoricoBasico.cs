using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia
{
    public class RepositorioHistoricoBasico : IRepositorioHistoricoBasico
    { 
        private readonly AppContext _appContext;
        public RepositorioHistoricoBasico(AppContext appContext)
        {
            _appContext = appContext;
        }

        HistoricoBasico IRepositorioHistoricoBasico.AddHistoricoBasico(HistoricoBasico historicoBasico)
        {
            var historicoBasicoAdicionado = _appContext.HistoricoBasicos.Add(historicoBasico);
            _appContext.SaveChanges();
            return historicoBasicoAdicionado.Entity;
        }

        void IRepositorioHistoricoBasico.DeleteHistoricoBasico(int id)
        {
            var historicoBasicoEncontrado = _appContext.HistoricoBasicos.FirstOrDefault(p => p.Id == id);
            if(historicoBasicoEncontrado == null)
                return;
            _appContext.HistoricoBasicos.Remove(historicoBasicoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<HistoricoBasico> IRepositorioHistoricoBasico.GetAllHistoricoBasicos()
        {
           return _appContext.HistoricoBasicos;
        }

        HistoricoBasico IRepositorioHistoricoBasico.GetHistoricoBasico(int id)
        {
            return _appContext.HistoricoBasicos.FirstOrDefault(p => p.Id == id);
        }

        HistoricoBasico IRepositorioHistoricoBasico.UpdateHistoricoBasico(HistoricoBasico historicoBasico)
        {
            var historicoBasicoEncontrado = _appContext.HistoricoBasicos.FirstOrDefault(p => p.Id == historicoBasico.Id);
            if (historicoBasicoEncontrado!=null)
            {
                historicoBasicoEncontrado.Id=historicoBasico.Id;
                historicoBasicoEncontrado.IdPaciente=historicoBasico.IdPaciente;

                _appContext.SaveChanges();
            }
            return historicoBasicoEncontrado;
        }
    }
}