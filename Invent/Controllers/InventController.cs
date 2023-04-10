using Invent.Models;
using Microsoft.AspNetCore.Mvc;

namespace Invent.Controllers
{
    public class InventController : Controller
    {
        
        [HttpGet]
        [HttpPost]
        public IActionResult Index(InventViewModel invent)
        {
           
            return View(invent);
        }
       

    }
}
