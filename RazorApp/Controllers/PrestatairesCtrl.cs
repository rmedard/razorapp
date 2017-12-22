using Microsoft.AspNetCore.Mvc;

namespace RazorApp.Controllers
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