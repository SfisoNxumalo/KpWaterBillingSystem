using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.CreationPattern
{
    
    public interface IBillBuilderPattern
    {
        IBillBuilderPattern Reset();
        IBillBuilderPattern SetCustomer(int customerId);
        IBillBuilderPattern SetReadings(List<WaterReading> readings);
        IBillBuilderPattern SetBillingDate(DateTime date);
        IBillBuilderPattern SetDueDate(DateTime date);
        Bill Build();
    }
    public class BillBuilderPattern : IBillBuilderPattern
    {
        private Bill _bill;

        public BillBuilderPattern() => Reset();

        public IBillBuilderPattern Reset()
        {
            _bill = new Bill(0, 1, DateTime.Now, DateTime.Now, new List<WaterReading>());
            return this;
        }

        public IBillBuilderPattern SetCustomer(int customerId)
        {
            _bill.CustomerId = customerId;
            return this;
        }

        public IBillBuilderPattern SetReadings(List<WaterReading> readings)
        {
            _bill.Readings = readings;
            return this;
        }

        public IBillBuilderPattern SetBillingDate(DateTime date)
        {
            _bill.BillingDate = date;
            return this;
        }

        public IBillBuilderPattern SetDueDate(DateTime date)
        {
            _bill.DueDate = date;
            return this;
        }

        public Bill Build()
        {
            var result = _bill;
            Reset();
            return result;
        }
    }
    public class BillingDirectorPattern
    {
        private readonly IBillBuilderPattern _builder;

        public BillingDirectorPattern(IBillBuilderPattern builder) => _builder = builder;

        public Bill ConstructStandardBill(int customerId, List<WaterReading> readings)
        {
            return _builder
                .Reset()
                .SetCustomer(customerId)
                .SetReadings(readings)
                .SetBillingDate(DateTime.Now)
                .SetDueDate(DateTime.Now.AddDays(30))
                .Build();
        }
    }

}
