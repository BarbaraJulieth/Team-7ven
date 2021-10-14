using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiNutri.App.Persistencia;
using SeguiNutri.App.Dominio;

namespace SeguiNutri.App.Frontend.Pages.Coachs
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioCoach _repoCoach;
        public IEnumerable<Coach> Coach{get;set;}
        public IndexModel (IRepositorioCoach _repoCoach)
        {
            this._repoCoach=_repoCoach;
        }

        public void OnGet()
        {
            Coach=_repoCoach.GetAllCoachs();
        }
    }
}
