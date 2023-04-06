using Application.Contract.Departments;
using MediatR;

namespace Application.Features.Departments.Command.DeleteDepartment
{
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand, bool>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DeleteDepartmentCommandHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<bool> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            return await _departmentRepository.DeleteAsync(request.Id);
        }
    }
}
