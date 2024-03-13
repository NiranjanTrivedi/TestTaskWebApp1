using Microsoft.AspNetCore.Mvc;

namespace TestTaskWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.AccessToken = TempData["AccessToken"];
            ViewBag.UserName = TempData["UserName"];
            return View();
        }
    }
}
