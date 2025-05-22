using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Users;

namespace WebApplication1.Controllers
{
    public class AcoountController : Controller
    {
        UserManager<AppUser> userManager;
        SignInManager<AppUser> signInManager;

        public AcoountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Login()
        {
            var result=await signInManager.PasswordSignInAsync("TestUser", "Test", false, false);
            if (result.Succeeded) {
            ViewBag.msg = "Zalogowano pomyślnie";
            }
            else
            {
                ViewBag.msg = "Błędy: "+result;
            }
            return View();
        }
        public async Task< IActionResult> Register()
        {
            var user = await userManager.FindByNameAsync("TestUser");
            if (user != null) { 
                ViewBag.msg = "Użytkownik o podanej nazwie istnieje";
            }
            else
            {
                user = new AppUser()
                {
                    UserName = "TestUser",
                    Email = "testuser@ukw.edu.pl",
                    FirstName = "Jan",
                    LastName = "Kowalski"
                };
                var result =await userManager.CreateAsync(user,"Test");
                ViewBag.msg = result.ToString(); ;

            }
                return View();
        }
    }
}
