using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace angularAbp.ManagementEmployee
{
    [Table("Employee", Schema = "ME")]
    public class Employee : Entity<int>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
