using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;

namespace KpWaterBillingSystem.src.Model
{
    public class Admin : IUser
    {
        public void AddUser(User user) { }
        public void GenerateReport() { }

        public string Name { get; set; }
        public string Email { get; set; }

        public void DisplayRole()
        {
            Console.WriteLine($"Employee: {Name}, Email: {Email}");
        }
    }
}
