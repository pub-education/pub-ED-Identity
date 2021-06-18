using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.Models;

namespace Identity.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
    //[Area("Admin")]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult EditUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditUser(int userId)
        {
            return View();
        }

        public IActionResult DeleteUser(int userId)
        {
            return View();
        }

        public IActionResult AddCountry()
        {
            return View();
        }

        public IActionResult AddCity()
        {
            return View();
        }
    }
}
