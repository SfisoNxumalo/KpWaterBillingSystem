using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.CreationPattern
{
    public enum UserType { Employee, Customer }

    // UserSimpleFactoryPattern.cs
    public static class UserSimpleFactoryPattern
    {
        public static IUser CreateUser(UserType type, int id, string name, string email, string address = "")
        {
            switch (type)
            {
                case UserType.Employee:
                    return new Employee(id, name, email);
                case UserType.Customer:
                    return new Customer(id, name, address, email);
                default:
                    throw new ArgumentException("Invalid user type");
            }
        }
    }
}
