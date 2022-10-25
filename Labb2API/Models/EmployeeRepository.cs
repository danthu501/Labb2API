using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Labb2API.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly AppDbContext _appDbContext;


        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var test = _appDbContext.Employees.Include(e => e.Department).ToList();

            return test;
        }


        public Employee Create(Employee employee)
        {
            _appDbContext.Employees.Add(employee);
            _appDbContext.SaveChanges();
            return employee;
            
        }

        public Employee DeleteEmployee(int id)
        {
            var EmployeeToDeltet = _appDbContext.Employees.FirstOrDefault(i => i.EmployeeId == id);
            if (EmployeeToDeltet != null)
            {
                _appDbContext.Employees.Remove(EmployeeToDeltet);
                _appDbContext.SaveChanges();
               
            }
            return EmployeeToDeltet;

      
        }

        public Employee GetEmployeeById(int id)
        {
            return _appDbContext.Employees.FirstOrDefault(i => i.EmployeeId == id);
        }

        public Employee UpdateEmployee(int id, Employee employees)
        {
            var EmployeeToUpdate = GetEmployeeById(id);
            if (EmployeeToUpdate != null)
            {
                EmployeeToUpdate.Salary = employees.Salary;
                EmployeeToUpdate.StreetAdress = employees.StreetAdress;
                EmployeeToUpdate.City = employees.City;
                EmployeeToUpdate.Email = employees.Email;
                EmployeeToUpdate.FirstName = employees.FirstName;
                EmployeeToUpdate.LastName = employees.LastName;
                EmployeeToUpdate.Zipcode = employees.Zipcode;
                EmployeeToUpdate.PhoneNumber = employees.PhoneNumber;
                EmployeeToUpdate.Gender = employees.Gender;
                EmployeeToUpdate.DepartmentId = employees.DepartmentId;
            }
            _appDbContext.SaveChanges();
            return EmployeeToUpdate;

        }
    }
}
