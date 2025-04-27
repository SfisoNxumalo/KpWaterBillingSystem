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
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Customer(int customerId, string fullName, string address, string email)
        {
            CustomerId = customerId;
            FullName = fullName;
            Address = address;
            Email = email;
            WaterReadings = new List<WaterReading>();
        }

     
        public void AddWaterReading(WaterReading reading)
        {
            WaterReadings.Add(reading);
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer: {FullName} ({CustomerId}), Address: {Address}, Email: {Email}");
        }

        public void DisplayRole()
        {
            throw new NotImplementedException();
        }

        public void save(User entity)
        {
            throw new NotImplementedException();
        }

        public User findById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> findAll()
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
