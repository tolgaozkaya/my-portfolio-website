using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            Authentication authentication = new Authentication();

            if (authentication.authentication(username, password))
            {
                ViewBag.Mesaj = "Giriş Başarılı";
                HttpContext.Session.SetString("UserSession", "1");
                return RedirectToAction("Index", "Home");
            }
            else
            { ViewBag.Mesaj = authentication.ErrorMessage; }

            return View();
        }
    }
}

