using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Departments.Command.UpdateDepartment
{
    public class UpdateDepartmentCommand:IRequest<bool>
    {
        public int Id { get; set; }
        [MinLength(3),MaxLength(100)]
        public string Name { get; set; }
    }
}
