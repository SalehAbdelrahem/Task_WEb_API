using Application.Contract.Departments;
using DTOS.Departments;
using MediatR;

namespace Application.Features.Departments.Query.GetDepartmentDetailsIncludeEmployess
{
    public class GetDepartmentDetailsIncludeEmployessQueryHandler :
        IRequestHandler<GetDepartmentDetailsIncludeEmployessQuery, DepartmentDetailsDTO>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public GetDepartmentDetailsIncludeEmployessQueryHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<DepartmentDetailsDTO> Handle(GetDepartmentDetailsIncludeEmployessQuery request, CancellationToken cancellationToken)
        {
            var dept = await _departmentRepository.GetDeptsWithEmployeesAsync(request.Id);

            if (dept == null)
            {
                throw new Exception("Not Found this Department");

            }
            else
            {
                return new DepartmentDetailsDTO()
                {
                    Id = dept.Id,
                    Name = dept.Name,
                    Empolyees = dept.Employees.Select(e => new DTOS.Employees.EmpolyeeMinimalDTO
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Code = e.Code,
                        DateOfBirth = e.DateOfBirth,
                        JoinDate = e.JoinDate,
                        Salary = e.Salary

                    }).ToList()
                };

            }

        }

      
    }
}

