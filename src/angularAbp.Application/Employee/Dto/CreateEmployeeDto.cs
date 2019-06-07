using Abp.AutoMapper;

namespace angularAbp.Employee.Dto
{
    [AutoMapTo(typeof(angularAbp.ManagementEmployee.Employee))]
    public class CreateEmployeeDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
