using Application.Contract.Departments;
using Application.Contract.Empolyees;
using MediatR;
using System.ComponentModel.Design;

namespace Application.Features.Employees.Command.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, bool>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository,
            IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }
        public async Task<bool> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emp = await _employeeRepository.GetDetailsAsync(request.Id);
            var Dept = await _departmentRepository.GetDetailsAsync(request.DepartmentId);

            if (emp != null || Dept!=null)
            {
                emp.Department = Dept;
                if (request.Name != null)
                {
                    emp.Name = request.Name;
                }
                if (request.Code != null)
                {
                    emp.Code = request.Code;
                }
                if (request.DateOfBirth != null)
                {
                    emp.DateOfBirth = (DateTime)request.DateOfBirth;
                }
                if (request.JoinDate != null)
                {
                    emp.JoinDate = (DateTime)request.JoinDate;
                }
                if (request.Salary != null)
                {
                    emp.Salary = (decimal)request.Salary;
                }

                return await _employeeRepository.UpdateAsync(emp);
            }
            else
            {
                throw new Exception("Eployee Not Found Or Dept Not Found");
            }

        }
    }
}
