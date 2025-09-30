using CRUDAppAspCoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace CRUDAppAspCoreWebApi.Controllers
{
    public class StudentController : Controller
    {

        private string baseUrl = "https://localhost:7179/api/StudentAPI";

        private HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage responseMessage = client.GetAsync(baseUrl).Result;
            if(responseMessage != null)
            {
                string message = responseMessage.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<List<Student>>(message);

                if(result != null)
                {
                    students = result;
                }
            }

            return View(students);
        }
    }
}
