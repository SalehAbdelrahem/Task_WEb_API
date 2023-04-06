using DTOS.Departments;
using MediatR;

namespace Application.Features.Departments.Query.GetDepartmentDetailsIncludeEmployess
{
    public class GetDepartmentDetailsIncludeEmployessQuery:IRequest<DepartmentDetailsDTO>
    {
        public int Id { get; set; }
    }
}
