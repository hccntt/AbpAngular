using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace angularAbp.Employee.Dto
{
    [AutoMap(typeof(ManagementEmployee.Employee))]
    public class EmployeeDto : EntityDto<int>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
