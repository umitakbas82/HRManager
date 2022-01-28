using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    class EmployeeDetailDTO: IDTOs
    {
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeTitle { get; set; }
        
    }
}
