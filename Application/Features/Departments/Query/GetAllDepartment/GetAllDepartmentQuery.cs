using DTOS.Departments;
using MediatR;

namespace Application.Features.Departments.Query.GetAllDepartment
{
    public class GetAllDepartmentQuery:IRequest<IEnumerable<DepartmentMinimalDTO>>
    {
    }
}
