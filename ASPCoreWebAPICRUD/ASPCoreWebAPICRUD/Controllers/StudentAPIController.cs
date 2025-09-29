using ASPCoreWebAPICRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreWebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly MyDbContext dbContext;
        public StudentAPIController(MyDbContext context) {
            this.dbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var students = await dbContext.Students.ToListAsync();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                await dbContext.Students.AddAsync(student);
                await dbContext.SaveChangesAsync();
            }

            return Ok(student);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> UpdateStudentById(int id, Student std)
        {
            if(id != std.Id)
            {
                return BadRequest();
            }

            dbContext.Entry(std).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();

            return Ok(std);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var std = await dbContext.Students.FindAsync(id);

            if(std == null)
            {
                return NotFound();
            }
            dbContext.Students.Remove(std);
            await dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
