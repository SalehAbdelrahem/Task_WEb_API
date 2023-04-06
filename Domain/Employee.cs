using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Domain
{
    public class Employee
    {
        
        public int Id { get; set; }

        [Required]
    
        [MinLength(2),MaxLength(200)]
        public string Code { get; set; }

        [MinLength(3), MaxLength(200)]

        public string Name { get; set; }

        [Required]
       
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Join Date")]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [Required]
        [Column(TypeName = "Decimal(18,2)")]
        public decimal Salary { get; set; }

      

        public  Department Department { get; set; }


    }
}