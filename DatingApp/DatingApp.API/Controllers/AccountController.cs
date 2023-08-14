using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
