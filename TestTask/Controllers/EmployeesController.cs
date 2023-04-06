using Application.Features.Employees.Command.CreateEmployee;
using Application.Features.Employees.Command.DeleteEmployee;
using Application.Features.Employees.Command.UpdateEmployee;
using Application.Features.Employees.Query.GetAllEmployee;
using Application.Features.Employees.Query.GetEmployeeDetails;
using Application.Features.Employees.Query.GetEmployeeDetailsWithDept;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;


        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments([FromQuery] GetAllEmployeeQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
        [HttpGet("GetDetails")]
        public async Task<IActionResult> GetDepartmentDetails([FromQuery] GetEmployeeDetailsQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        // Get Employee with his Dept
        [HttpGet("GetEmployeeDetailsIncludeDept")]
        public async Task<IActionResult> GetDepartmentALLDetails([FromQuery] GetEmployeeDetailsIncludeDeptQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateEmployeeCommand commant)
        {
            return Ok(await _mediator.Send(commant));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDepartment([FromQuery] int id, [FromBody] UpdateEmployeeCommand commant)
        {
            return Ok(await _mediator.Send(commant));

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDepartment([FromQuery] DeleteEmployeeCommand command)
        {
            return Ok(await _mediator.Send(command));

        }
    }
}
