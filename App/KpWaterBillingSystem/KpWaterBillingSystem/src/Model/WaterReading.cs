using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Model
{
    public class WaterReading
    {
        // Attributes
        public int ReadingId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReadingDate { get; set; }
        public double Consumption { get; set; }      // e.g., in cubic meters
        public string PhotoPath { get; set; }        // path or URL to proof image

        // Relationship
        public Customer Customer { get; set; }       // many-to-1 with Customer

        // Constructor
        public WaterReading(int readingId, int customerId, DateTime readingDate, double consumption, string photoPath)
        {
            ReadingId = readingId;
            CustomerId = customerId;
            ReadingDate = readingDate;
            Consumption = consumption;
            PhotoPath = photoPath;
        }

        // Methods
        public bool ValidateReading()
        {
            // Basic validation: consumption must be non-negative
            return Consumption >= 0;
        }

        public void DisplayReading()
        {
            Console.WriteLine($"Reading #{ReadingId} for Customer {CustomerId} on {ReadingDate:d}: {Consumption} m³");
        }
    }
}
