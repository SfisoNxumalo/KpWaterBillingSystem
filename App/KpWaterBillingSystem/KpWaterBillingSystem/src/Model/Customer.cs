using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Repository.Interface;

namespace KpWaterBillingSystem.src.Model
{
    public class Customer : IUser
    {

        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public List<WaterReading> WaterReadings { get; set; }
        public string Name { get; set ; }

        public Customer(int customerId, string fullName, string address, string email)
        {
            CustomerId = customerId;
            FullName = fullName;
            Address = address;
            Email = email;
            WaterReadings = new List<WaterReading>();
        }

        public void DisplayRole()
        {
            throw new NotImplementedException();
        }
    }
}
