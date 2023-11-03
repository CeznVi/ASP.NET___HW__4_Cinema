using Microsoft.AspNetCore.Mvc;
using ASP.Core.MVC.Models;

namespace ASP.Core.MVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View(Department.Create());
        }

        public IActionResult Who()
        {
            Random rand = new Random();
            
            return PartialView(Department.Create().stuff[ rand.Next(Department.Create().stuff.Count) ]);
        }

    }
}
