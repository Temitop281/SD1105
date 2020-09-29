using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Cleanwaterprojectsupport.Controllers
{
    public class RegisterAccountController : Controller
    {

        //PROPERTIES
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        //CONSTRUCTOR
        public RegisterAccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(string username, string password)
        {
            IdentityUser newuser = new IdentityUser();
            newuser.Email = username;
            newuser.UserName = username;

            IdentityResult result = _userManager.CreateAsync(newuser, password).Result;

            if (result.Succeeded)
            {
                _userManager.AddToRoleAsync(newuser, "NormalUser").Wait();

                _signInManager.SignInAsync(newuser, false).Wait();
            }

            return RedirectToAction("Create", "UserProfiles");
        }

    }
}