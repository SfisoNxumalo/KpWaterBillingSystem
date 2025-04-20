using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.CreationPattern.srccc
{
    public interface IReportFactoryMethodPattern
    {
        IReport CreateReport();
    }

    // EmployeeReportFactoryMethodPattern.cs
    public class EmployeeReportFactoryMethodPattern : IReportFactoryMethodPattern
    {
        public IReport CreateReport() => new EmployeeReport();
    }

    // CustomerReportFactoryMethodPattern.cs
    public class CustomerReportFactoryMethodPattern : IReportFactoryMethodPattern
    {
        public IReport CreateReport() => new CustomerReport();
    }
}
