using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;
 
namespace SeguiNutri.App.Persistencia
 
{
   public class RepositorioCoach : IRepositorioCoach
   {
      private readonly AppContext _appContext = new AppContext();
     /*  public RepositorioCoach(AppContext  appContext)
      {
         _appContext = appContext;
      } */
 
      Coach IRepositorioCoach.AddCoach(Coach coach)
      {
         var coachAdicionado = _appContext.Coachs.Add(coach);
         _appContext.SaveChanges();
         return coachAdicionado.Entity;
      }
 
      void IRepositorioCoach.DeleteCoach(string cedulaCoach)
      {
         var coachEncontrado =  _appContext.Coachs.FirstOrDefault(p => p.Cedula == cedulaCoach);
         if(coachEncontrado == null)
         return;
         _appContext.Coachs.Remove(coachEncontrado);
         _appContext.SaveChanges();
 
      }
 
      IEnumerable<Coach> IRepositorioCoach.GetAllCoachs()
      {
         return _appContext.Coachs;
      }
 
      Coach IRepositorioCoach.GetCoach(string CedulaCoach)
      {
         var coachEncontrado = _appContext.Coachs.FirstOrDefault(p => p.Cedula == CedulaCoach);
         return coachEncontrado;
      }
 
      Coach IRepositorioCoach.UpdateCoach(Coach coach)
      {
         var coachEncontrado = _appContext.Coachs.FirstOrDefault(p => p.Cedula == coach.Cedula);
         if (coachEncontrado!=null)
         {
            coachEncontrado.Cedula=coach.Cedula;
            coachEncontrado.Nombre=coach.Nombre;
            coachEncontrado.Apellido=coach.Apellido;
            coachEncontrado.FechaNacimiento=coach.FechaNacimiento;
            coachEncontrado.Correo=coach.Correo;
            coachEncontrado.Telefono=coach.Telefono;
            coachEncontrado.Id=coach.Id;
            _appContext.SaveChanges();
           
         }
          return coachEncontrado;
      }
 
   }
}
