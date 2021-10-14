using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguiNutri.App.Persistencia;
using SeguiNutri.App.Dominio;

namespace SeguiNutri.App.Frontend.Pages.Nutricionistas
{
    public class IndexModel : PageModel
    {

        private readonly IRepositorioNutricionista _repoNutricionista;
    
        public IEnumerable<Nutricionista> Nutricionista{get;set;}
        public IndexModel (IRepositorioNutricionista _repoNutricionista)
        {
            this._repoNutricionista=_repoNutricionista;
        }

        public void OnGet()
        {
            Nutricionista=_repoNutricionista.GetAllNutricionista();
        }
    }
}
