using Microsoft.AspNetCore.Mvc;
using StudentValidationAPI.Models;

namespace StudentValidationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new();

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            students.Add(student);

            return Ok(student);
        }
    }
}