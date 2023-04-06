using Domain;

namespace Application.Contract.Departments
{
    public interface IDepartmentRepository : IGeneralRepository<Department,int>
    {
       Task <Department?> GetDeptsWithEmployeesAsync(int id);
    }
}
