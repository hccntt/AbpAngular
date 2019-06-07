using Abp.Application.Services;
using Abp.Domain.Repositories;
using angularAbp.Authorization.Roles;
using angularAbp.Authorization.Users;
using angularAbp.Employee.Dto;

namespace angularAbp.Employee
{
    public class EmployeeAppService : AsyncCrudAppService<ManagementEmployee.Employee, EmployeeDto, int, PagedEmployeeResultRequestDto, CreateEmployeeDto, EmployeeDto>, IEmployeeAppService
    {
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        private readonly IRepository<ManagementEmployee.Employee> _repositoryEmployee;

        public EmployeeAppService(
            UserManager userManager,
            RoleManager roleManager, IRepository<ManagementEmployee.Employee> repositoryEmployee)
            : base(repositoryEmployee)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _repositoryEmployee = repositoryEmployee;
        }


    }
}
