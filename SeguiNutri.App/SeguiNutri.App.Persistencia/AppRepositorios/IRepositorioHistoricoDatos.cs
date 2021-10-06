using System.Collections.Generic;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia
{
    public interface IRepositorioHistoricoDatos
    {
     IEnumerable<HistoricoDatos> GetAllHistoricosDatos();
    HistoricoDatos AddHistoricoDatos(HistoricoDatos historicoDatos);
    HistoricoDatos UpdateHistoricoDatos(HistoricoDatos historicoDatos);
    void DeleteHistoricoDatos(int id);
    HistoricoDatos GetHistoricoDatos(int id);

    }
}