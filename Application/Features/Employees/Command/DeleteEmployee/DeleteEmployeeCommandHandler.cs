using Application.Contract.Departments;
using Application.Contract.Empolyees;
using MediatR;

namespace Application.Features.Employees.Command.DeleteEmployee
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.DeleteAsync(request.Id);
        }
    }
}
