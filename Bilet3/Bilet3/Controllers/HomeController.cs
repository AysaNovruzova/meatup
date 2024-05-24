
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bilet3_.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
          
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
