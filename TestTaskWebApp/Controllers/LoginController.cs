using Microsoft.AspNetCore.Mvc;
using TestTaskWebApp.Models;
using TestTaskWebApp.Services;

namespace TestTaskWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserApiController _userApi;
        public LoginController(UserApiController userApi)
        {
            _userApi = userApi;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Login(LoginModel model, string returnUrl = null)
        {
            // Your existing login logic to verify credentials
            try
            {
                string users = await _userApi.Login(model);

                TempData["AccessToken"] = users;
                TempData["UserName"] = model.UserName;

                // Redirect to Admin Dashboard


                TempData["Sucess"] = "Admin Login Sucessfully";
                return RedirectToAction("Index", "User");
            }
            catch (Exception ex)
            {
                TempData["error"] = "Invalid username or password";
                return View();
                
            }
               
            // If role not found or any other condition, return to the default returnUrl

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
