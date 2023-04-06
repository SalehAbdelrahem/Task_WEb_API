using DTOS.Employees;
using MediatR;

namespace Application.Features.Employees.Query.GetAllEmployee
{
    public class GetAllEmployeeQuery : IRequest<IEnumerable<EmpolyeeMinimalDTO>>
    {

    }
}
