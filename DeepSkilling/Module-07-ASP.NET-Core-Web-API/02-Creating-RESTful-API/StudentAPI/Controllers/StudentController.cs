using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new()
        {
            new Student
            {
                Id = 1,
                Name = "Roshan",
                Age = 20,
                Department = "CSE"
            },
            new Student
            {
                Id = 2,
                Name = "Rahul",
                Age = 21,
                Department = "ECE"
            }
        };

        // GET: api/student
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        // GET: api/student/1
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        // POST: api/student
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);

            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        // PUT: api/student/1
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Department = updatedStudent.Department;

            return NoContent();
        }

        // DELETE: api/student/1
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            students.Remove(student);

            return NoContent();
        }
    }
}