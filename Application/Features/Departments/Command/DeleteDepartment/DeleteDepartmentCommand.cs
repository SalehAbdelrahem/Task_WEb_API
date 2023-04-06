using MediatR;

namespace Application.Features.Departments.Command.DeleteDepartment
{
    public class DeleteDepartmentCommand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
