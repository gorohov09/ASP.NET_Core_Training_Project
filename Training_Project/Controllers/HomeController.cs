using Microsoft.AspNetCore.Mvc;

namespace Training_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ConfiguredAction(string id, string Value1)
        {
            return $"Hello world {id} - {Value1}";
        }
    }
}
