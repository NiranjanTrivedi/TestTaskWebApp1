using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using TestTaskWebApp.Models;
using TestTaskWebApp.Services;

namespace TestTaskWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserApiController _userApi;

        public HomeController(UserApiController userApi)
        {
            _userApi = userApi;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userApi.GetAllUsers();
            if(users!=null)
            {
                return View(users);
            }
            return NotFound();
            
        }

        
        public async Task<IActionResult> Create()
        {
        
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUser user)
        {
           
            if (ModelState.IsValid)
            {
                await _userApi.CreateUser(user);
                TempData["msg"] = "Record Inserted Sucessfully";
                return RedirectToAction(nameof(Index));
            }
           
            TempData["msg"] = "Error occured on server side";
            return View();
        }
        
        public async Task<IActionResult> Update(int Id)
        {
            var users = await _userApi.GetAllUsersbyid(Id);
            if (users != null)
            {
                return View(users);
            }
            return NotFound();
           
        }
        [HttpPost]
        public async Task<IActionResult> Update(CreateUser user)
        {

            if (!ModelState.IsValid)
            {
                return View(user);
            }
            var result = await _userApi.UpdateUser(user);
            if (result!=null)
            {
                TempData["msg"] = "Updated Sucessfully";
                return RedirectToAction(nameof(Index));
            }
            TempData["msg"] = "Error occured on server side";
            return View(user);

            
        }

        
        public async Task<IActionResult> Delete(int Id)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userApi.DeleteUser(Id);
            if (result != null)
            {
                TempData["msg"] = "Deleted Sucessfully";
                return RedirectToAction(nameof(Index));
            }
            TempData["msg"] = "Error occured on server side";
            return View();


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
