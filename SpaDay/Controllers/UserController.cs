using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User newUser, string confirmPassword)
        {
            ViewBag.UserName = newUser.UserName;
            ViewBag.Date = newUser.Date;
            ViewBag.message = "Password does not match!";
            ViewBag.username = newUser.UserName;
            ViewBag.email = newUser.Email;
            if (newUser.Password == confirmPassword)
            {
                
                return View("Index");
            }

            return View();
            
        }
    }


}
