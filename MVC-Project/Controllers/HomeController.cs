using Industrial_Design.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Industrial_Design.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}