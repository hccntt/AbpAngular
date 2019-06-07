using Abp.Data;
using Abp.EntityFrameworkCore;
using angularAbp.ManagementEmployee;
using System;
using System.Collections.Generic;
using System.Text;

namespace angularAbp.EntityFrameworkCore.Repositories.ManagementEmployee
{
    public class EmployeeRepository : angularAbpRepositoryBase<Employee, int>, IEmployeeRepository
    {
        private readonly IActiveTransactionProvider _transactionProvider;

        public EmployeeRepository(IDbContextProvider<angularAbpDbContext> dbContextProvider, IActiveTransactionProvider transactionProvider)
            : base(dbContextProvider)
        {
            _transactionProvider = transactionProvider;
        }


    }
}
