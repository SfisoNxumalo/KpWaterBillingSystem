using KpWaterBillingSystem.src.Interface;

namespace KpWaterBillingSystem.src.Model
{
    internal class CustomerReport : IReport
    {
        public string Generate()
        {
            return "Employee report generated with usage details and submission stats.";
        }
    }
}