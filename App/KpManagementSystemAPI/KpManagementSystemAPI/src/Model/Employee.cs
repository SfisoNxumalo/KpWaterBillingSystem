using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Model
{
    using System;
    using System.Collections.Generic;
    using KpWaterBillingSystem.src.Repository.Interface;

    public class Employee : IUser
    {
      
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

    
        public string Name { get ; set ; }

        public Employee(int employeeId, string fullName, string email)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            Email = email;
        } 

        public void DisplayRole()
        {
            throw new NotImplementedException();
        }
    }
}