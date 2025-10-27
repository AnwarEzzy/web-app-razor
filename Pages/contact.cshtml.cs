using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class contactModel : PageModel
    {
        public bool hasData = false;
        public string nom = "";
        public string prenom = "";
        public string message = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            hasData = true;
            nom = Request.Form["nom"];
            prenom = Request.Form["prenom"];
            message = Request.Form["message"];
        }

    }
}
