using ChatApplication.ViewModels;
using ChatEntities.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public AccountController(UserManager<User>userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string UserName, string Password) {
            var user =  await _userManager.FindByNameAsync(UserName);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, Password, false, false);
                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Login", "Account");
        }
        [HttpGet]
        public IActionResult Register()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult >Register(string UserName, string Password)
        {
            var user = new User
            {
                UserName = UserName
            };
           var result = await _userManager.CreateAsync(user, Password);
            if (result.Succeeded) {
               await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index","Home");
            }
            return RedirectToAction("Register","Account");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
