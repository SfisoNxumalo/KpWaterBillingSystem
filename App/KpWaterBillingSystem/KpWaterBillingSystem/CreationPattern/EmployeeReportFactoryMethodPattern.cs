using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.Interface;

namespace KpWaterBillingSystem.CreationPattern
{
    public interface IReportFactoryMethodPattern
    {
        IReport CreateReport();
    }

    public class EmployeeReportFactoryMethodPattern : IReportFactoryMethodPattern
    {
        public IReport CreateReport() => new EmployeeReport();
    }

    public class CustomerReportFactoryMethodPattern : IReportFactoryMethodPattern
    {
        public IReport CreateReport()
        {
            throw new NotImplementedException();
        }
    }
}
