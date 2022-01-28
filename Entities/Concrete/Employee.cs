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
        public string EmployeeSurname { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public string EmlployeeGraduate { get; set; }
        public string EmployeeRole { get; set; }
        public string EmployeeAdrress { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeCellPhoneNumber { get; set; }
        public int EmployeeIBANNumber { get; set; }
        public string EmployeeEMailAdress { get; set; }
        public decimal EmployeeSalary{ get; set; }
    }
}
