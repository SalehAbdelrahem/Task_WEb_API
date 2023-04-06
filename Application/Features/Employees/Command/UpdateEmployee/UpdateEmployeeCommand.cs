using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Features.Employees.Command.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<bool>
    {
        public int Id { get; set; }
        [MinLength(2), MaxLength(200)]
        public string? Code { get; set; }

        [MinLength(3), MaxLength(200)]

        public string? Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? JoinDate { get; set; }

        public decimal? Salary { get; set; }
        public int DepartmentId { get; set; }

    }

}
