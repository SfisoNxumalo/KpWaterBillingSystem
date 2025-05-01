using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Model
{
    public class Notification
    {

        public int NotificationId { get; set; }
        public int CustomerId { get; set; }
        public int? BillId { get; set; }         
        public string Message { get; set; }
        public DateTime DateSent { get; set; }


        public Customer Customer { get; set; }  
        public Bill Bill { get; set; }          

        public Notification(int notificationId, int customerId, string message, DateTime dateSent, int? billId = null)
        {
            NotificationId = notificationId;
            CustomerId = customerId;
            Message = message;
            DateSent = dateSent;
            BillId = billId;
        }


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
