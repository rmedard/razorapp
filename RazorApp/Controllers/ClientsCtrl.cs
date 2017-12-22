using Microsoft.AspNetCore.Mvc;

namespace RazorApp.Controllers
{
    public class ClientsCtrl : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}