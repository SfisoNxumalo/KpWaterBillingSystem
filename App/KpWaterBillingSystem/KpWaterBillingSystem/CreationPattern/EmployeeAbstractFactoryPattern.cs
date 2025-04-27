using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.Interface;

namespace KpWaterBillingSystem.CreationPattern
{
    public interface IUserReportAbstractFactoryPattern
    {
        IEmployee CreateUser(int id, string name, string address, string email);
        IReport CreateReport();
    }

    public class EmployeeAbstractFactoryPattern : IUserReportAbstractFactoryPattern
    {
        public IUser CreateUser(int id, string name, string address, string email)
            => new Employee(id, name, email);

        public IReport CreateReport() => new EmployeeReport();

        IEmployee IUserReportAbstractFactoryPattern.CreateUser(int id, string name, string address, string email)
        {
            throw new NotImplementedException();
        }
    }
    public class CustomerAbstractFactoryPattern : IUserReportAbstractFactoryPattern
    {
        public IEmployee CreateUser(int id, string name, string address, string email)
            => new Employee(id, name, email);

        public IReport CreateReport() => new CustomerReport();
    }
}
