using DTOS.Departments;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Departments.Command.CreateDepartment
{
    public class CreateDepartmentCommant : IRequest<DepartmentMinimalDTO>
    {

        [MinLength(3), MaxLength(100)]

        public string Name { get; set; }

        public CreateDepartmentCommant(string name)
        {
            Name = name;
        }
    }
}
