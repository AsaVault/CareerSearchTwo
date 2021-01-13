using CareerSearchTwo.Areas.Admin.Models;
using CareerSearchTwo.Areas.Admin.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerSearchTwo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager,
                                 RoleManager<IdentityRole> roleManager,
                                 UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [AllowAnonymous]
        public async Task <IActionResult> Login(AccountLoginViewModel model, string returnUrl = null)

        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if(result.Succeeded)
            {
                if (returnUrl != null)
                    return LocalRedirect(returnUrl);
                else
                    return RedirectToAction("index", "Dashboard");
            }

            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login details");
            }

            return View(model);
        }

        [HttpGet]
        //[Authorize(Roles = "Administrator")]
        [AllowAnonymous]

        
        public IActionResult Register()
        {
            var model = new AccountRegisterViewModel();
            model.UserRoles = GetRolesDropdown();
            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> RegisterAsync(AccountRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = new User { UserName = model.UserName, Email = model.Email, Tel = model.Tel };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {

                    await _userManager.AddToRoleAsync(user, model.Role);

                    TempData["StatusMessage"] = "New account created successfully";
                    return RedirectToAction("Register");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    model.UserRoles = GetRolesDropdown();
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("AllJobs", "Home", new { Area = "" });
        }



        [NonAction]
        public ICollection<SelectListItem> GetRolesDropdown()
        {
            return _roleManager.Roles.Select(r => new SelectListItem { Text = r.Name, Value = r.Name }).ToList();
        }

        public IActionResult Accessdenied()
        {
            return View();
        }
    }
}
