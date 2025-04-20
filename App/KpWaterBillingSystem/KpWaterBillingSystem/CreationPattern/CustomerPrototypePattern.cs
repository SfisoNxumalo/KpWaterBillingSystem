using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;
using Microsoft.VisualBasic;

namespace KpWaterBillingSystem.CreationPattern
{
    // CustomerPrototypePattern.cs

    public class CustomerPrototypePattern : Customer, ICloneable
    {


        public CustomerPrototypePattern(int id, string name, string address, string email)
            : base(id, name, address, email) { }

        public object Clone() => MemberwiseClone();
    }

    // BillPrototypePattern.cs
    public class BillPrototypePattern : Bill, ICloneable
    {
        public BillPrototypePattern(int billId, int customerId, DateTime billingDate, DateTime dueDate, List<WaterReading> readings)
            : base(billId, customerId, billingDate, dueDate, readings) { }

        public object Clone()
        {
            // Shallow copy of readings; deep clone if needed
            var clonedReadings = new List<WaterReading>(Readings);
            var clone = new BillPrototypePattern(BillId, CustomerId, BillingDate, DueDate, clonedReadings)
            {
                //IsPaid = this.IsPaid,
                //AmountDue = this.AmountDue
            };
            return clone;
        }
    }


}
