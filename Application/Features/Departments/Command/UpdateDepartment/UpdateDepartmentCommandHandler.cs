using Application.Contract.Departments;
using MediatR;

namespace Application.Features.Departments.Command.UpdateDepartment
{
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, bool>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<bool> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            
            var dept =await _departmentRepository.GetDetailsAsync(request.Id);
            if(dept == null)
            {
                throw new Exception("Not Found this Departmet ");
            }
            else
            {
                if(request.Name!=null)
                {
                    dept.Name=request.Name;

                }
                return await _departmentRepository.UpdateAsync(dept);
            }

        }
    }
}
