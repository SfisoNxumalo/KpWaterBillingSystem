using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Model
{
    public class WaterMeter
    {
        public int MeterId { get; set; }
        public string Location { get; set; }
        public int UserId { get; set; }

        public void AssignToUser(int userId) { }
    }
}
