using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Model
{
    public class Notification
    {
        // Attributes
        public int NotificationId { get; set; }
        public int CustomerId { get; set; }
        public int? BillId { get; set; }         // Optional link to a Bill
        public string Message { get; set; }
        public DateTime DateSent { get; set; }

        // Relationships
        public Customer Customer { get; set; }   // many-to-1 with Customer
        public Bill Bill { get; set; }           // 0..1 with Bill

        // Constructor
        public Notification(int notificationId, int customerId, string message, DateTime dateSent, int? billId = null)
        {
            NotificationId = notificationId;
            CustomerId = customerId;
            Message = message;
            DateSent = dateSent;
            BillId = billId;
        }

        // Methods

        /// <summary>
        /// Simulates sending the notification (e.g., via email).
        /// </summary>
        public void Send()
        {
            Console.WriteLine($"Sending notification to Customer {CustomerId}: {Message}");
        }

        /// <summary>
        /// Displays notification details for debugging.
        /// </summary>
        public void DisplayNotification()
        {
            Console.WriteLine($"Notification #{NotificationId} (Sent: {DateSent:d}): {Message}");
        }
    }
}
