using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewsAspCore.Models;

namespace StronglyTypedViewsAspCore.Controllers
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
            //Employee employee = new Employee();
            //employee.EmpId = 111;
            //employee.EmpName = "Test";
            //employee.EmpDesig = "Associate";
            //employee.EmpSal = 89000;

            List<Employee> employees = new List<Employee>
            {
                new Employee{ EmpId = 899, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
                new Employee{ EmpId = 999, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
                new Employee{ EmpId = 777, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
                new Employee{ EmpId = 666, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
                new Employee{ EmpId = 444, EmpName = "Tomm", EmpDesig = "Associate", EmpSal = 9000},
            };

            return View(employees);
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
