using DTOS.Employees;

namespace DTOS.Departments
{
    public class DepartmentDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<EmpolyeeMinimalDTO> Empolyees { get; set; }

    }
}
