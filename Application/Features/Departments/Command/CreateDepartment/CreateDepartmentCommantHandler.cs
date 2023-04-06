using Application.Contract.Departments;
using Domain;
using DTOS.Departments;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Departments.Command.CreateDepartment
{
    internal class CreateDepartmentCommantHandler : IRequestHandler<CreateDepartmentCommant, DepartmentMinimalDTO>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public CreateDepartmentCommantHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<DepartmentMinimalDTO> Handle(CreateDepartmentCommant request, CancellationToken cancellationToken)
        {
            if(request == null)
            {
                throw new Exception("Not Allowed To be a Department name is Null");
            }
            else
            {
                Department deparment = new Department { Name = request.Name };
                var NewDept = await _departmentRepository.CreateAsync(deparment);
                return new DepartmentMinimalDTO {Id=NewDept.Id, Name=NewDept.Name};
            }

          
        }
    }
}
