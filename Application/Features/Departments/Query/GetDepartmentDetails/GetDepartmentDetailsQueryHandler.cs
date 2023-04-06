using Application.Contract.Departments;
using DTOS.Departments;
using MediatR;

namespace Application.Features.Departments.Query.GetDepartmentDetails
{
    public class GetDepartmentDetailsQueryHandler : IRequestHandler<GetDepartmentDetailsQuery, DepartmentMinimalDTO>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public GetDepartmentDetailsQueryHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<DepartmentMinimalDTO> Handle(GetDepartmentDetailsQuery request, CancellationToken cancellationToken)
        {
            var department = await _departmentRepository.GetDetailsAsync(request.Id);
            if (department == null)
            {
                throw new Exception("Not Fount Department");
            }
            else
            {
                return new DepartmentMinimalDTO { Id = department.Id, Name = department.Name };
            }
        }
    }
}
