using Microsoft.AspNetCore.Mvc;

namespace Training_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
