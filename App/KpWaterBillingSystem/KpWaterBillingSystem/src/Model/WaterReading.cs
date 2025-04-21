using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Model
{
    public class WaterReading
    {
       
        public int ReadingId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReadingDate { get; set; }
        public double Consumption { get; set; }      
        public string PhotoPath { get; set; }      

        public Customer Customer { get; set; }     

       
        public WaterReading(int readingId, int customerId, DateTime readingDate, double consumption, string photoPath)
        {
            ReadingId = readingId;
            CustomerId = customerId;
            ReadingDate = readingDate;
            Consumption = consumption;
            PhotoPath = photoPath;
        }

    
        public bool ValidateReading()
        {
            
            return Consumption >= 0;
        }

        public void DisplayReading()
        {
            Console.WriteLine($"Reading #{ReadingId} for Customer {CustomerId} on {ReadingDate:d}: {Consumption} m³");
        }
    }
}
