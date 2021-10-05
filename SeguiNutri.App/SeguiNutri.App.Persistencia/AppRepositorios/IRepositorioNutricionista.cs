using System.Collections.Generic;
using SeguiNutri.App.Dominio;
using System.Linq;

namespace SeguiNutri.App.Persistencia.AppRepositorios
{
    public interface IRepositorioNutricionista
    {
        IEnumerable<Nutricionista> GetAllNutricionista();
        Nutricionista AddNutricionista(Nutricionista nutricionista);
        Nutricionista UpdateNutricionista(Nutricionista nutricionista);
        void DeleteNutricionista(int IdNutricionista);
        Nutricionista GetNutricionista(int IdNutricionista);
    }
}