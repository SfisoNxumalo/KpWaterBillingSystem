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
        public int MeterId { get; set; }
        public DateTime ReadingDate { get; set; }
        public double CurrentReading { get; set; }
        public string PhotoPath { get; set; }

        public bool ValidateReading() { return true; }
    }
}
