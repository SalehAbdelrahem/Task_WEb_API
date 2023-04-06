using MediatR;

namespace Application.Features.Employees.Command.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
