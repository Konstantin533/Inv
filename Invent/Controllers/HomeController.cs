using Invent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Invent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Authorization()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Authorization(AdminViewModel admin)
        {

        
                if (admin.Login.Equals("admin") & admin.Password.Equals("admin"))
                    return Redirect("~/Invent/Index");

                else return Redirect("~/Home/Registration");
            
        }
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}