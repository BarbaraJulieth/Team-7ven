using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiNutri.App.Persistencia;
using SeguiNutri.App.Dominio;

namespace SeguiNutri.App.Frontend.Pages
{
    public class EliminarCoachModel : PageModel
    {
        private readonly IRepositorioCoach _repoCoach;
        public Coach Coach {get;set;}
        public EliminarCoachModel (IRepositorioCoach _repoCoach)

        {
            this._repoCoach=_repoCoach;
        }

       public IActionResult OnGet(string cedula)
        {
            Coach =_repoCoach.GetCoach(cedula);
            if(Coach==null)
            {
                return NotFound ();
            }
            else
            {
                return Page();
            }

        }
        public IActionResult OnPost(string cedula)
        {
            _repoCoach.DeleteCoach(cedula);
            return RedirectToPage("Index");
        }
    }
}