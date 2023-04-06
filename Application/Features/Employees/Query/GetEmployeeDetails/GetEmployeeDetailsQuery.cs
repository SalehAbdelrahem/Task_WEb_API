using DTOS.Employees;
using MediatR;

namespace Application.Features.Employees.Query.GetEmployeeDetails
{
    public class GetEmployeeDetailsQuery:IRequest<EmpolyeeMinimalDTO>
    {
        public int Id { get; set; }
    }
}
