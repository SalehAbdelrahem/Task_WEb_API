namespace DTOS.Departments
{
    public class DepartmentMinimalDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DepartmentMinimalDTO(string name)
        {
            Name = name;
        }
        public DepartmentMinimalDTO()
        {
            
        }

    }
}
