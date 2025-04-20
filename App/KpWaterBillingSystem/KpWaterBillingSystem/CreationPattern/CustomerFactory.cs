using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.CreationPattern
{
    public class CustomerFactory : IUserReportFactory
    {
        public IReport CreateReport()
        {
            throw new NotImplementedException();
        }

        public IUser CreateUser(string name, string email)
        {
            return new Customer
            {
                Name = name,
                Email = email
            };
        }
    }
}
