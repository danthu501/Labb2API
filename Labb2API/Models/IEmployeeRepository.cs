namespace Labb2API.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        Employee UpdateEmployee(int id, Employee employees);
        Employee DeleteEmployee(int id);
        Employee Create(Employee employee);
    }
}
