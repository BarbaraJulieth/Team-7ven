using System.Collections.Generic;
using SeguiNutri.App.Dominio;
using System.Linq;

namespace SeguiNutri.App.Persistencia.AppRepositorios
{
    public interface IRepositorioNutricionista
    {
        IEnumerable<Nutricionista> GetAllPNutricionista();
        Nutricionista AddNutricionista(Nutricionista nutricionista);
        Nutricionista UpdateNutricionista(Nutricionista nutricionista);
        void DeleteNutricionista(string IdNutricionista);
        Nutricionista GetNutricionista(string IdNutricionista);
    }
}