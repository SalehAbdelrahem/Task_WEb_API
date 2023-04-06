using Application.Contract.Departments;
using Domain;
using Microsoft.EntityFrameworkCore;
using MyDBContext;

namespace Infrastructre.Departments
{
    public class DepartmentRepository : GeneralRepository<Department, int>, IDepartmentRepository
    {
        public DepartmentRepository(TaskDbContext context) : base(context)
        {

        }

        public async Task<Department?> GetDeptsWithEmployeesAsync(int id)
        {
         
                return await _context.Departments.Include(emp => emp.Employees).FirstOrDefaultAsync(d => d.Id == id);

        }
    }
}
