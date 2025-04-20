using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;

namespace KpWaterBillingSystem.CreationPattern
{
    public class ReportDirector
    {
        private IReportBuilder _builder;

        public ReportDirector(IReportBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IReportBuilder builder)
        {
            _builder = builder;
        }

        public string ConstructStandardReport(string userName, string dataSummary)
        {
            _builder.Reset();
            _builder.SetTitle($"Report for {userName}");
            _builder.SetBody(dataSummary);
            _builder.SetFooter($"Generated on {DateTime.Now}");

            return _builder.GetReport();
        }
    }
}
