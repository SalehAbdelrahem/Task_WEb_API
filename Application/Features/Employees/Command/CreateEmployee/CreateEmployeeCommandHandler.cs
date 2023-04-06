using Application.Contract.Departments;
using Application.Contract.Empolyees;
using Domain;
using DTOS.Departments;
using DTOS.Employees;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Employees.Command.CreateEmployee
{
    internal class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, EmpolyeeMinimalDTO>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository,
            IDepartmentRepository departmentRepository)
        {
           _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }
        public async Task<EmpolyeeMinimalDTO> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var dept= await _departmentRepository.GetDetailsAsync(request.DepartmentId);
            if (request == null || dept==null)
            {
                throw new Exception("Not Allowed To be a Employee is Null or dept is null");
            }
            else
            {
                var employee = new Employee();
                employee.Name = request.Name;
                employee.Salary = request.Salary;
                employee.Code = request.Code;
                employee.DateOfBirth = request.DateOfBirth;
                employee.JoinDate = request.JoinDate;
                employee.Department = dept;
                var result = await _employeeRepository.CreateAsync(employee);
                return new EmpolyeeMinimalDTO
                {
                    Id = result.Id,
                    Name = result.Name,
                    Code = result.Code,
                    DateOfBirth = result.DateOfBirth,
                    JoinDate = result.JoinDate,
                    Salary = result.Salary
                };
            }
           

          
           
        }
    }
}
