using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Interface
{
    public interface IUserReportFactory
    {
        IUser CreateUser(string name, string email);
        IReport CreateReport();
    }
}
