using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Model
{
    public class Bill
    {
        public int BillId { get; set; }
        public int UserId { get; set; }
        public double AmountDue { get; set; }
        public DateTime BillingDate { get; set; }
        public bool IsPaid { get; set; }

        public void GenerateBill(WaterReading reading) { }
        public void PayBill() { }
    }
}
