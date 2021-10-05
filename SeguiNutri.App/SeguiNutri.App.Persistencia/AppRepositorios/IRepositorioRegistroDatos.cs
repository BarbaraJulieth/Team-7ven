using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRegistroDatos
    {
        IEnumerable<RegistroDatos> GetAllRegistrosDatos();
        RegistroDatos AddRegistroDatos(RegistroDatos registroDatos);
        RegistroDatos UpdateRegistroDatos(RegistroDatos registroDatos);
        void DeleteRegistroDatos(int IdPaciente ,int Id);
        RegistroDatos GetRegistroDatos(int IdPaciente ,int Id);
    }
}