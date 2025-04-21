using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;

namespace KpWaterBillingSystem.src.Model
{
    using System;
    using System.Collections.Generic;

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
    }
}