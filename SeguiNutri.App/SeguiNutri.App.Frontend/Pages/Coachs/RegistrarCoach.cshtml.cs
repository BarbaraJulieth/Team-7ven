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
    public class RegistrarCoachModel : PageModel
    {
        private readonly IRepositorioCoach _repoCoach;
        
        public Coach Coach {get;set;}

        public RegistrarCoachModel (IRepositorioCoach _repoCoach)
        {
            this._repoCoach=_repoCoach;
        }
        public void OnGet()
        {
            Coach = new Coach();
        }
        public IActionResult OnPost(Coach coach)
        {
            _repoCoach.AddCoach(coach);
            return RedirectToPage("Index");
        }
    }
}