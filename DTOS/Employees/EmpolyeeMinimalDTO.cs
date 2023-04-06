using System.ComponentModel.DataAnnotations;

namespace DTOS.Employees
{
    //Empolyee Minimal DTO
    public class EmpolyeeMinimalDTO
    {
        
        public int Id { get; set; }

        [MinLength(2), MaxLength(200)]
        public string Code { get; set; }

        [MinLength(3), MaxLength(200)]

        public string Name { get; set; }

        [Required]

        public DateTime DateOfBirth { get; set; }

        [Required]

        public DateTime JoinDate { get; set; }

        [Required]
        public decimal Salary { get; set; }



    }
}
