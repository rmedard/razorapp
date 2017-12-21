using Microsoft.AspNetCore.Mvc;

namespace RazorApp
{
    public class PrestatairesCtrl : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}