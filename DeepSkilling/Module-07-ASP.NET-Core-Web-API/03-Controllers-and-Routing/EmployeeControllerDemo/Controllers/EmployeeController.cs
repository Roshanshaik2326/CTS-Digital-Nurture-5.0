using Microsoft.AspNetCore.Mvc;
using EmployeeControllerDemo.Models;

namespace EmployeeControllerDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Roshan",
                Department = "IT",
                Salary = 50000
            },
            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Department = "HR",
                Salary = 45000
            },
            new Employee
            {
                Id = 3,
                Name = "Priya",
                Department = "Finance",
                Salary = 55000
            }
        };

        // GET api/employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        // GET api/employee/2
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        // GET api/employee/search?department=IT
        [HttpGet("search")]
        public IActionResult SearchByDepartment(string department)
        {
            var result = employees
                .Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(result);
        }

        // GET api/employee/highsalary/50000
        [HttpGet("highsalary/{salary}")]
        public IActionResult HighSalary(decimal salary)
        {
            var result = employees
                .Where(e => e.Salary >= salary)
                .ToList();

            return Ok(result);
        }
    }
}