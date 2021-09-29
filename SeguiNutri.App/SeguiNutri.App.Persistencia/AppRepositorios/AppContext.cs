using Microsoft.EntityFrameworkCore;
using SeguiNutri.App.Dominio;

namespace SeguiNutri.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Coach> Coachs {get ; set;}
        public DbSet<HistoricoBasico> HistoricoBasicos {get ; set; }
        public DbSet<HistoricoDatos> HistoricosDatos {get ; set; }
        public DbSet<Nutricionista> Nutricionistas {get ; set; }
        public DbSet<Paciente> Pacientes {get ; set; }
        public DbSet<Persona> Personas {get ; set; }
        public DbSet<RegistroDatos> RegistrosDatos {get ; set; }
        public DbSet<SeguimientoNutris> SeguimientosNutri {get ; set; }
    }
}