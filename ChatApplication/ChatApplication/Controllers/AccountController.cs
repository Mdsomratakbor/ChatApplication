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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string UserName, string Password) {
            var user =  await _userManager.FindByNameAsync(UserName);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, Password, true, true);
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult >Register(UserViewModels model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = new User
                    {
                        UserName = model.UserName,
                        Email = model.Email
                    };
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, false);
                        return RedirectToAction("Index", "Home");
                    }
                    return View();
                }
                catch (Exception ex)
                {
                    
                    return View(ex.Message);
                }
              
                
            }
            else return View();
          
        }
        public async Task<IActionResult> Logout()
        {
       
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
