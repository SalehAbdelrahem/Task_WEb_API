using Application.Features.Departments.Command.CreateDepartment;
using Application.Features.Departments.Command.DeleteDepartment;
using Application.Features.Departments.Command.UpdateDepartment;
using Application.Features.Departments.Query.GetAllDepartment;
using Application.Features.Departments.Query.GetDepartmentDetails;
using Application.Features.Departments.Query.GetDepartmentDetailsIncludeEmployess;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IMediator _mediator;


        public DepartmentsController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments([FromQuery] GetAllDepartmentQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
        [HttpGet("GetDetails")]
        public async Task<IActionResult> GetDepartmentDetails([FromQuery] GetDepartmentDetailsQuery query)
        {
            return Ok(await _mediator.Send(query));
        }

        //Dept With Employees
        [HttpGet("GetDetailsIncloudeEmployees")]
        public async Task<IActionResult> GetDepartmentALLDetails([FromQuery] GetDepartmentDetailsIncludeEmployessQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentCommant commant)
        {
            return Ok(await _mediator.Send(commant));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartment([FromQuery]int id,[FromBody] UpdateDepartmentCommand commant)
        {
            return Ok(await _mediator.Send(commant));

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDepartment([FromQuery] DeleteDepartmentCommand command)
        {
            return Ok(await _mediator.Send(command));

        }
    }
}
