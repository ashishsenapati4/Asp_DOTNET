using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;

namespace ModelDataUsingViewData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //Employee emp1 = new Employee();
            //emp1.EmpName = "Ashish";
            //emp1.EmpId = 3455;
            //emp1.EmpDesig = "Associate";
            //emp1.EmpSal = 52000;

            //ViewData["MyEmp"] = emp1;

            List<Employee> employees = new List<Employee>
            { 
                new Employee{ EmpId = 899, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
                new Employee{ EmpId = 999, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
                new Employee{ EmpId = 777, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
                new Employee{ EmpId = 666, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
                new Employee{ EmpId = 444, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
            };

            TempData["employees"] = employees;

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
