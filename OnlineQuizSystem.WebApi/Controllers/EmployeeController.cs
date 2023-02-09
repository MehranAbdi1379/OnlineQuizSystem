using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizSystem.Service.Contracts;
using OnlineQuizSystem.Service.Contracts.Dto;

namespace OnlineQuizSystem.WebApi.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] CreateEmployeeDto dto)
        {
            employeeService.CreateEmployee(dto);
            return Ok();
        }
    }
}
