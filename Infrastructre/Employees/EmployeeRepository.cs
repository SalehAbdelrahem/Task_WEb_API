using Application.Contract.Departments;
using Application.Contract.Empolyees;
using Domain;
using Microsoft.EntityFrameworkCore;
using MyDBContext;

namespace Infrastructre.Employees
{
    public class EmployeeRepository : GeneralRepository<Employee, int>, IEmployeeRepository
    {

        public EmployeeRepository(TaskDbContext context) : base(context)
        {

        }

        public async Task<Employee?> GetEmployeeWithDept(int id)
        {
            return await _context.Employees.Include(e => e.Department).FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
