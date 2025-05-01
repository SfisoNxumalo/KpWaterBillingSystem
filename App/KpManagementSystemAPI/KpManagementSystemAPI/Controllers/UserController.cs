using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.DI;
using Microsoft.AspNetCore.Mvc;

namespace KpManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("/UserManagement")]
    public class UserController : Controller
    {

        private readonly StorageService<Employee> _service;
        public UserController(StorageService<Employee> service)
        {
            _service = service;
        }

        [HttpPost("/AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _service.Add(employee);
            return Ok("Added New Employee");
        }

        [HttpGet("/GetAllEmplyee")]
        public IActionResult GetAllEmployees()
        {
            var reuslt = _service.findAll();
            return Ok(reuslt);
        }

        [HttpGet("/GetEmplyee/{EmployeeId}")]
        public IActionResult GetEmployee([FromRoute] int EmployeeId)
        {
            var reuslt = _service.findById(EmployeeId);
            return Ok(reuslt);
        }

        [HttpDelete("/DeleteEmployee/{EmployeeId}")]
        public IActionResult DeleteEmployee([FromRoute] int EmployeeId)
        {
            _service.delete(EmployeeId);
            return Ok("Deleted Employee with ID: "+ EmployeeId);
        }
    }
}
