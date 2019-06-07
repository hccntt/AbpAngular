using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace angularAbp.Employee.Dto
{
    public class EmployeeEditDto : EntityDto<int>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
