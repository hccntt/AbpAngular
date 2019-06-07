using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace angularAbp.Employee.Dto
{
    public class PagedEmployeeResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
