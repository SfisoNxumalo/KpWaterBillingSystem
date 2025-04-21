using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.CreationPattern
{
    public class BillingManagerSingletonPattern
    {
        private static BillingManagerSingletonPattern _instance;
        private static readonly object _lock = new object();

        public decimal RatePerUnit { get; private set; }

        private BillingManagerSingletonPattern()
        {
            RatePerUnit = 12.50m;
        }

        public static BillingManagerSingletonPattern Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new BillingManagerSingletonPattern();
                    return _instance;
                }
            }
        }

        public decimal CalculateBill(WaterReading reading)
        {
            if (reading.Consumption < 0)
                throw new ArgumentException("Consumption must be non-negative.");
            return (decimal)reading.Consumption * RatePerUnit;
        }
    }

}
