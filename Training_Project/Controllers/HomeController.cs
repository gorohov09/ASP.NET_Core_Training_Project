using Microsoft.AspNetCore.Mvc;
using Training_Project.Models;

namespace Training_Project.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> List_Employees = new List<Employee>()
        {
            new Employee() { Id = 1, FirstName = "Иван", LastName = "Иванов", Patronymic = "Иванович", Age = 24},
            new Employee() { Id = 2, FirstName = "Петр", LastName = "Петров", Patronymic = "Петрович", Age = 27},
            new Employee() { Id = 3, FirstName = "Сидор", LastName = "Сидоров", Patronymic = "Сидорович", Age = 18}
        };

        public IActionResult Index()
        {
            return View();
        }

        public string ConfiguredAction(string id, string Value1)
        {
            return $"Hello world {id} - {Value1}";
        }

        public IActionResult Employees()
        {
            return View(List_Employees);
        }
    }
}
