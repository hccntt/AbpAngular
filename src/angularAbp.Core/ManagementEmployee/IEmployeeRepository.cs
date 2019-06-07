using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace angularAbp.ManagementEmployee
{
    public interface IEmployeeRepository : IRepository<Employee, int>
    {
    }
}
