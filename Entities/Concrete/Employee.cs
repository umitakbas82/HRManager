using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employee:IEntity
    {
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeTitle { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public string EmlployeeGraduateDegree { get; set; }
        public DateTime EmployeeGraduateDate { get; set; }
        public int  EmployeeExperience { get; set; }
       
        public string EmployeeAdrress { get; set; }
        
        public string EmployeeCellPhoneNumber { get; set; }
        
        public string EmployeeEMailAdress { get; set; }
        
    }
}
