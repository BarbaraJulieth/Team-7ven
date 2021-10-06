using System.Collections.Generic;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia
{
    public interface IRepositorioHistoricoBasico
    {
    IEnumerable<HistoricoBasico> GetAllHistoricoBasicos();
    HistoricoBasico AddHistoricoBasico(HistoricoBasico historicoBasico);
    HistoricoBasico UpdateHistoricoBasico(HistoricoBasico historicoBasico);
    void DeleteHistoricoBasico(int id);
    HistoricoBasico GetHistoricoBasico(int id);

    }
}