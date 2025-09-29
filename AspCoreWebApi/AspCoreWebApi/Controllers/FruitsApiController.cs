using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsApiController : ControllerBase
    {
        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Melons",
            "Grapes"
        };

        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetFruitById(int id)
        {
            if (id >= 0 && id < fruits.Count)
            {
                return Ok(fruits.ElementAt(id));
            }
            return BadRequest("Invalid Input");
        }
    }
}
