using Application.Contract.Empolyees;
using DTOS.Departments;
using DTOS.Employees;
using MediatR;

namespace Application.Features.Employees.Query.GetEmployeeDetailsWithDept
{
    public class GetEmployeeDetailsIncludeDeptQueryHandler : IRequestHandler<GetEmployeeDetailsIncludeDeptQuery, EmployeeDetailsDTO>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeDetailsIncludeDeptQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<EmployeeDetailsDTO> Handle(GetEmployeeDetailsIncludeDeptQuery request, CancellationToken cancellationToken)
        {
            var emp = await _employeeRepository.GetEmployeeWithDept(request.Id);
            if(emp == null)
            {
                throw new Exception("Not Found this Employee");

            }
            else
            {
                return new EmployeeDetailsDTO()
                {
                    Id = emp.Id,
                    Name = emp.Name,
                    Code = emp.Code,
                    DateOfBirth = emp.DateOfBirth,
                    JoinDate = emp.JoinDate,
                    Salary = emp.Salary,

                    Department = new DepartmentMinimalDTO
                    {
                        Id = emp.Department.Id,
                        Name = emp.Department.Name,


                    }
                };
            }
        }
    }
}
