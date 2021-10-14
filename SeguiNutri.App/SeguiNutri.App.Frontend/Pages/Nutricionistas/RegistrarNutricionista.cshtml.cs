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
    public class RegistrarNutricionistaModel : PageModel
    {
        private readonly IRepositorioNutricionista _repoNutricionista;
        
        public Nutricionista Nutricionista {get;set;}

        public RegistrarNutricionistaModel (IRepositorioNutricionista _repoNutricionista)
        {
            this._repoNutricionista=_repoNutricionista;
        }
        public void OnGet()
        {
            Nutricionista = new Nutricionista();
        }
        public IActionResult OnPost(Nutricionista nutricionista)
        {
            _repoNutricionista.AddNutricionista(nutricionista);
            return RedirectToPage("Index");
        }
    }
}
