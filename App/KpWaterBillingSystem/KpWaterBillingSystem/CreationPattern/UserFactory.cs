using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.CreationPattern
{

    public enum UserType { Admin, Employee, Customer }
    public class UserFactory
    {
        public static IUser CreateUser(UserType type)
        {
            switch (type)
            {
                case UserType.Admin: return new Admin();
                case UserType.Employee: return new Employee();
                case UserType.Customer: return new Customer();
                default: throw new ArgumentException("Invalid user type");
            }
        }
    }
}
