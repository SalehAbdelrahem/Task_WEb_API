using Domain;

namespace Application.Contract.Empolyees
{
    public interface IEmployeeRepository:IGeneralRepository<Employee,int>
    {
         Task<Employee?> GetEmployeeWithDept(int id);
    }
}
