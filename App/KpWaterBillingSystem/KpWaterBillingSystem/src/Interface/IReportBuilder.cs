using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Interface
{
    public interface IReportBuilder
    {
        void Reset();
        void SetTitle(string title);
        void SetBody(string body);
        void SetFooter(string footer);
        string GetReport();
    }
}
