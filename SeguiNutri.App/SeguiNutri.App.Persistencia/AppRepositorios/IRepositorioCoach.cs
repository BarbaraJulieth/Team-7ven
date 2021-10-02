using System.Collections.Generic;
using SeguiNutri.App.Dominio;
 
namespace SeguiNutri.App.Persistencia.AppRepositorios
{
    public interface IRepositorioCoach
    {
        IEnumerable<Coach> GetAllCoachs();
        Coach AddCoach(Coach coach);
        Coach UpdateCoach(Coach coach);
        void DeleteCoach(string idCoach);
        Coach GetCoach(string idCoach);
     }
}
