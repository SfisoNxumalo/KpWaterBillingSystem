using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.src.Repository.Interface
{
    public interface IUserReportFactory : IGenericRepository<Employee, string>
    {
        IUser CreateUser(string name, string email);
        IReport CreateReport();
    }
}
