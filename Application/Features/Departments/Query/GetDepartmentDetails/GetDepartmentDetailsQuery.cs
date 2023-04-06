using DTOS.Departments;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Departments.Query.GetDepartmentDetails
{
    public class GetDepartmentDetailsQuery:IRequest<DepartmentMinimalDTO>
    {
        public int Id { get; set; }
    }
}
