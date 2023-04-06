using DTOS.Employees;
using MediatR;

namespace Application.Features.Employees.Query.GetEmployeeDetailsWithDept
{
    public class GetEmployeeDetailsIncludeDeptQuery:IRequest<EmployeeDetailsDTO>
    {
        public int Id { get; set; }
    }
}
