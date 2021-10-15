using System.Collections.Generic;
using SeguiNutri.App.Dominio;
 
namespace SeguiNutri.App.Persistencia
{
    public interface IRepositorioCoach
    {
        IEnumerable<Coach> GetAllCoachs();
        Coach AddCoach(Coach coach);
        Coach UpdateCoach(Coach coach);
        void DeleteCoach(string cedulaCoach);
        Coach GetCoach(string cedulaCoach);
     }
}
