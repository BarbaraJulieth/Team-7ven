using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SeguiNutri.App.Frontend.Pages
{
    public class PruebaModel : PageModel
    {

        private string [] lista = {"001","002","003", "004"};

        public List<string> listaHtm {get; set;}

        public void OnGet()
        {
            listaHtm = new List<string>();
            listaHtm.AddRange(lista);
        }
    }
}
