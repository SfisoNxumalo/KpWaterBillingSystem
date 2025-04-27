using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Model
{
    using System;
    using System.Collections.Generic;
    using KpWaterBillingSystem.src.Repository.Interface;

    public class Employee : IUser, IEmployee
    {
      
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

       
        public List<WaterReading> SubmittedReadings { get; set; }

        
        public Employee(int employeeId, string fullName, string email)
        {
            EmployeeId = employeeId;
            FullName = fullName;
            Email = email;
            SubmittedReadings = new List<WaterReading>();
        }

    
        public string Name
        {
            get => FullName;
            set => FullName = value;
        }

        public void DisplayRole()
        {
            Console.WriteLine($"Role: Employee, Name: {FullName}, Email: {Email}");
        }

        public void SubmitReading(WaterReading reading)
        {
            if (reading == null) throw new ArgumentNullException(nameof(reading));
            SubmittedReadings.Add(reading);
            Console.WriteLine($"Employee {FullName} submitted reading #{reading.ReadingId}.");
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee Info -> ID: {EmployeeId}, Name: {FullName}, Email: {Email}");
        }

        public void save(User entity)
        {
            throw new NotImplementedException();
        }

        public User findById(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> findAll()
        {
            throw new NotImplementedException();
        }

        public void delete(string id)
        {
            throw new NotImplementedException();
        }

        public void save(Employee entity)
        {
            throw new NotImplementedException();
        }

        Employee IGenericRepository<Employee, string>.findById(string id)
        {
            throw new NotImplementedException();
        }

        List<Employee> IGenericRepository<Employee, string>.findAll()
        {
            throw new NotImplementedException();
        }

        public User findById(int id)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}