using Application.Contract.Departments;
using DTOS.Departments;
using MediatR;

namespace Application.Features.Departments.Query.GetAllDepartment
{
    public class GetAllDepartmentQueryHandler : IRequestHandler<GetAllDepartmentQuery, IEnumerable<DepartmentMinimalDTO>>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public GetAllDepartmentQueryHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<IEnumerable<DepartmentMinimalDTO>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            return (await _departmentRepository.GetAllAsync()).Select(x => new DepartmentMinimalDTO()
            {
                Id = x.Id,
                Name = x.Name
            });
        }
    }
}
