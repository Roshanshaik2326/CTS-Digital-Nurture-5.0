using EmployeeServiceAPI.Models;

namespace EmployeeServiceAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> employees =
        [
            new Employee
            {
                Id = 1,
                Name = "Roshan",
                Department = "IT",
                Salary = 60000
            },

            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Department = "HR",
                Salary = 50000
            },

            new Employee
            {
                Id = 3,
                Name = "Priya",
                Department = "Finance",
                Salary = 65000
            }
        ];

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee? GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}