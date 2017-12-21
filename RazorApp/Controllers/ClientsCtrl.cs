using Microsoft.AspNetCore.Mvc;

namespace RazorApp
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