using AutoMapper;

namespace angularAbp.Employee.Dto
{
    public class EmployeeMapProfile : Profile
    {
        public EmployeeMapProfile()
        {
            // Role and permission
            CreateMap<CreateEmployeeDto, ManagementEmployee.Employee>();
            CreateMap<EmployeeDto, ManagementEmployee.Employee>();
        }
    }
}
