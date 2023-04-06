using Application.Contract.Empolyees;
using DTOS.Employees;
using MediatR;

namespace Application.Features.Employees.Query.GetEmployeeDetails
{
    public class GetEmployeeDetailsHandler : IRequestHandler<GetEmployeeDetailsQuery, EmpolyeeMinimalDTO>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeDetailsHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<EmpolyeeMinimalDTO> Handle(GetEmployeeDetailsQuery request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetDetailsAsync(request.Id);
            if (employee == null)
            {
                throw new Exception("Not Fount Employee");
            }
            else
            {
                return new EmpolyeeMinimalDTO
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Code = employee.Code,
                    DateOfBirth = employee.DateOfBirth,
                    JoinDate = employee.JoinDate,
                    Salary = employee.Salary
                };
            }
        }
    }
}
