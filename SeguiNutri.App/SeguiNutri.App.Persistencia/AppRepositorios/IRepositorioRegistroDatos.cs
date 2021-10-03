namespace SeguiNutri.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRegistroDatos
    {
        IEnumerable<RegistroDatos> GetAllRegistrosDatos();
        RegistroDatos AddRegistroDatos(RegistroDatos registroDatos);
        RegistroDatos UpdateRegistroDatos(RegistroDatos registroDatos);
        void DeleteRegistroDatos(string IdPaciente ,string Id);
        RegistroDatos GetRegistroDatos(string IdPaciente ,string Id);
    }
}