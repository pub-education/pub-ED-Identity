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
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private IPasswordHasher<ApplicationUser> _passwordHash;

        public AdminController(UserManager<ApplicationUser> usrMgr, IPasswordHasher<ApplicationUser> pwHash)
        {
            _userManager = usrMgr;
            _passwordHash = pwHash;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_userManager.Users);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
                return View(user);
                //return RedirectToAction("Index"); // tmp code
            else
            {
                ModelState.AddModelError("", "Cannot find user");
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(string userId, string fName, string lName, string email, string password, string city, string country)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(fName)) user.FirstName = fName;
                else ModelState.AddModelError("", "First name cannot be empty");

                if (!string.IsNullOrEmpty(lName)) user.LastName = lName;
                else ModelState.AddModelError("", "Last name cannot be empty");

                if (!string.IsNullOrEmpty(email)) user.Email = email;
                else ModelState.AddModelError("", "Email cannot be empty");

                if (!string.IsNullOrEmpty(city)) user.City.Name = city;
                else ModelState.AddModelError("", "City cannot be empty");

                if (!string.IsNullOrEmpty(country)) user.Country.Name = country;
                else ModelState.AddModelError("", "Country cannot be empty");

                if (!string.IsNullOrEmpty(userId))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User not found");

            return View(user);
        }

        [HttpPost]
        public IActionResult DeleteUser(string userId)
        {
            return RedirectToAction("ListUsers");
        }

        [HttpGet]
        public IActionResult ListCountries()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCountry(CountryClass country)
        {

            return RedirectToAction("ListCountries");
        }

        [HttpPost]
        public IActionResult EditCountry(int countryId)
        {

            return RedirectToAction("ListCountries");
        }

        [HttpPost]
        public IActionResult DeleteCountry(int countryId)
        {

            return RedirectToAction("ListCountries");
        }

        [HttpGet]
        public IActionResult ListCities()
        {

            return View();
        }
        public IActionResult AddCity(CityClass city)
        {

            return RedirectToAction("ListCities");
        }

        public IActionResult EditCity(int cityId)
        {

            return RedirectToAction("ListCities");
        }

        public IActionResult DeleteCity(int cityId)
        {

            return RedirectToAction("ListCities");
        }

        public void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
