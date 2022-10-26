using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using WebShopDemo.Models;

namespace WebShopDemo.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            //this.HttpContext.Session.SetString("name", "pesho");


            //if(TempData.ContainsKey("Last Access Time"))
            //{
            //    //TempData.Keep("Last Access Time");
            //    return Ok(TempData.Peek("Last Access Time"));
            //}
            //TempData["Last Access Time"] = DateTime.Now;
            //this.HttpContext.Response.Cookies.Append("myCookie", "Pesho", new CookieOptions
            //{
            //    Secure = true,
            //});
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            //string? name = this.HttpContext.Session.GetString("name");

            //if (!string.IsNullOrEmpty(name))
            //{
            //    return Ok(name);
            //}
            return View();
        }
        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}