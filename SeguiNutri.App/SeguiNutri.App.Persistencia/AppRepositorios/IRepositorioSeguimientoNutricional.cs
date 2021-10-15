using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia
{
    public interface IRepositorioSeguimientoNutricional
    {
        IEnumerable<SeguimientoNutris> GetAllSeguimientoNutris(int IdPaciente);
        SeguimientoNutris AddSeguimientoNutris(SeguimientoNutris seguimientoNutris);
        SeguimientoNutris UpdateSeguimientoNutris(SeguimientoNutris seguimientoNutris);
        void DeleteSeguimientoNutris(int Id);
        SeguimientoNutris GetSeguimientoNutris(int IdPaciente);
    }
}