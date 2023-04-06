namespace Domain
{
    public class Department
    {
       

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees{ get; set; }

        public Department(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }

        public Department(string name, ICollection<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }
        public Department()
        {
            
        }
    }
}
