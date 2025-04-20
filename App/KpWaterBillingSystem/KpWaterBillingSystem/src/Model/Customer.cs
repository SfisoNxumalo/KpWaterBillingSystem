using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;

namespace KpWaterBillingSystem.src.Model
{
    public class Customer : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void DisplayRole()
        {
            Console.WriteLine($"Customer: {Name}, Email: {Email}");
        }
    }
}
