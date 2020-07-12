﻿using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;
using SpaDay.Data;


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
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = addUserViewModel.Username,
                    Password = addUserViewModel.Password,
                    Email = addUserViewModel.Email                   
                };

                UserData.AddUser(newUser);

                
                return View("Index", addUserViewModel);
                
            }
            return View(addUserViewModel);

        }

    }
}
