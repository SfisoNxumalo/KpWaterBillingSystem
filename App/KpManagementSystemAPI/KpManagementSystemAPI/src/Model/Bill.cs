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
        public int CustomerId { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime DueDate { get; set; }
        public double AmountDue { get; private set; }
        public bool IsPaid { get; private set; }


        public Customer Customer { get; set; }       
        public List<WaterReading> Readings { get; set; }

        public Bill(int billId, int customerId, DateTime billingDate, DateTime dueDate, List<WaterReading> readings)
        {
            BillId = billId;
            CustomerId = customerId;
            BillingDate = billingDate;
            DueDate = dueDate;
            Readings = readings ?? new List<WaterReading>();
            AmountDue = 0;
            IsPaid = false;
        }

        /// <summary>
        /// Calculates the total amount due based on consumption and a given rate.
        /// </summary>
        public void GenerateBill(double ratePerUnit)
        {
            if (ratePerUnit < 0)
                throw new ArgumentException("Rate must be non-negative.", nameof(ratePerUnit));

            AmountDue = Readings.Sum(r => r.Consumption * ratePerUnit);
        }

        /// <summary>
        /// Marks this bill as paid.
        /// </summary>
        public void MarkAsPaid()
        {
            IsPaid = true;
        }

        /// <summary>
        /// Simulates sending the bill via email.
        /// </summary>
        public void SendBill()
        {
            Console.WriteLine($"Sending bill #{BillId} to {Customer.Email}. Amount: R{AmountDue:F2}");
        }

        /// <summary>
        /// Displays bill details for debugging.
        /// </summary>
        public void DisplayBill()
        {
            Console.WriteLine($"Bill #{BillId} for Customer {CustomerId} on {BillingDate:d}");
            Console.WriteLine($"Due Date: {DueDate:d}, Amount Due: R{AmountDue:F2}, Paid: {IsPaid}");
        }
    }
}
