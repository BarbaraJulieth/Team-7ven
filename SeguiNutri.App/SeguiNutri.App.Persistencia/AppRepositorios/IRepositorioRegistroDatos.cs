using System.Collections.Generic;
using System.Linq;
using SeguiNutri.App.Dominio;
using System;

namespace SeguiNutri.App.Persistencia
{
    public interface IRepositorioRegistroDatos
    {
        IEnumerable<RegistroDatos> GetAllRegistrosDatos(int IdPaciente);
        RegistroDatos AddRegistroDatos(RegistroDatos registroDatos);
        RegistroDatos UpdateRegistroDatos(RegistroDatos registroDatos);
        void DeleteRegistroDatos(int Id);
        RegistroDatos GetRegistroDatos(int Id);
    }
}