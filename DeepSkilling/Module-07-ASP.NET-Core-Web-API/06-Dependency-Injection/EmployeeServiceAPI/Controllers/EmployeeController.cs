using Microsoft.AspNetCore.Mvc;
using EmployeeServiceAPI.Services;

namespace EmployeeServiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employeeService.GetEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = employeeService.GetEmployeeById(id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }
    }
}