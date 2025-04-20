using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;

namespace KpWaterBillingSystem.src.Model
{
    public class EmployeeReport : IReport
    {
        public string Generate()
        {
            return "Employee report generated with usage details and submission stats.";
        }
    }
}
