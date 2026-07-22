using EmployeeServiceAPI.Models;

namespace EmployeeServiceAPI.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee? GetEmployeeById(int id);
    }
}