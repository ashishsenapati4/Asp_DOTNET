using System.Diagnostics;
using BindDDLWithDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BindDDLWithDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDBContext _dbContext;

        public HomeController(MyDBContext context)
        {
            _dbContext = context;
        }

        private User BindDDL()
        {
            var user = new User();

            user.userListItem = new List<SelectListItem>();

            user.userListItem.Add(new SelectListItem { Text = "Select Name", Value = "" });

            foreach (var item in _dbContext.UsrTbls.ToList())
            {
                user.userListItem.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            return user;
        }

        //get list of students from db and show it in a drop-down list
        public IActionResult Index()
        {
            var user = BindDDL();

            return View(user);
        }

        [HttpPost]
        public IActionResult Index(User usr)
        {
            var user = _dbContext.UsrTbls.Where(x => x.Id == usr.Id).FirstOrDefault();

            if (user != null)
            {
                ViewBag.selectedValue = user.Name;
            }
            var myStudent = BindDDL();
            return View(myStudent);
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
