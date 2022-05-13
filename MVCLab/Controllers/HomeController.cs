using Microsoft.AspNetCore.Mvc;
using MVCLab.Models;
using System.Diagnostics;

namespace MVCLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public IActionResult RegForm()
        {
            return View();
        }
       public IActionResult UserReg(UserReg Ur)
        {
            return View(Ur);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}