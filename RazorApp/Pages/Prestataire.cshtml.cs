using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages
{
    public class PrestataireModel : PageModel
    {
        public string WelcomMessage { get; private set; }

        public void OnGet()
        {
            WelcomMessage = "Welcome to Prestataires Page";
        }

    }
}