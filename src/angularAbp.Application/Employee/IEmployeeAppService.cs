using Abp.Application.Services;
using angularAbp.Employee.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace angularAbp.Employee
{
    public interface IEmployeeAppService : IAsyncCrudAppService<EmployeeDto, int, PagedEmployeeResultRequestDto, CreateEmployeeDto, EmployeeDto>
    {
    }
}
