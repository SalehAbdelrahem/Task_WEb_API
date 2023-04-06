using Application.Contract.Departments;
using Application.Contract.Empolyees;
using Domain;
using DTOS.Departments;
using DTOS.Employees;
using MediatR;

namespace Application.Features.Employees.Query.GetAllEmployee
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmpolyeeMinimalDTO>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetAllEmployeeQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<EmpolyeeMinimalDTO>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return (await _employeeRepository.GetAllAsync()).Select(x => new EmpolyeeMinimalDTO()
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                DateOfBirth = x.DateOfBirth,
                JoinDate = x.JoinDate,
               Salary=x.Salary,
             
            });
        }
    }
}
