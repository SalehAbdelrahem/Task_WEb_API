using DTOS.Employees;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Employees.Command.CreateEmployee
{
    public class CreateEmployeeCommand:IRequest<EmpolyeeMinimalDTO>
    {

        [MinLength(3), MaxLength(200)]
        public string Name { get; set; }

        [MinLength(2), MaxLength(200)]
        public string Code { get; set; }

     

        [Required]

        public DateTime DateOfBirth { get; set; }

        [Required]

        public DateTime JoinDate { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }

    }
}
