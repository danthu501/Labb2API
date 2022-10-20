using Labb2API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Labb2API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;


        public EmployeeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployess()
        {

            var employess = _employeeRepository.GetAllEmployees();
            
            return Ok(employess);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            var test = _employeeRepository.Create(employee);
            return Ok(test);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return (Ok());

        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> update([FromRoute]int id, Employee employee)
        {
            _employeeRepository.UpdateEmployee(id, employee);

            return (Ok());  
        }
    }
}
