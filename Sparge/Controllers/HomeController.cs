using Microsoft.AspNetCore.Mvc;
using Sparge.Models;
using System.Diagnostics;
using System.Linq;

namespace Sparge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationContext db;
        public HomeController(ILogger<HomeController> logger,ApplicationContext context)
        {
            _logger = logger;
             db = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();

        }
        [HttpPost]
        public IActionResult Index(User model)
        {
            
            var i = db.Users.Any(u => u.Email.Equals(model.Email));
            if (i)
            {

                   
                   
                    User user = db.Users.FirstOrDefault(p => p.Email == model.Email);
                   
                    model.Members = user.Members + 1;
                    
                   
                    db.Users.Remove(user);
                    db.Users.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Privacy");

                

                
            }
            else
            {
                db.Users.Add(model);
                db.SaveChanges();
                return RedirectToAction("Privacy");
            }
            

            
        }

        public IActionResult Privacy()
        {
            var users = db.Users.ToList();
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}