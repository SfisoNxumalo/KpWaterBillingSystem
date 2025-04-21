using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Interface;

namespace KpWaterBillingSystem.src.Model
{
    public class Admin : Employee
    {
        public List<Customer> ManagedCustomers { get; set; }
        public List<Employee> ManagedEmployees { get; set; }

        public Admin(int adminId, string fullName, string email)
            : base(adminId, fullName, email)
        {
            ManagedCustomers = new List<Customer>();
            ManagedEmployees = new List<Employee>();
        }

        /// <summary>
        /// Adds a new customer to the system.
        /// </summary>
        public void AddCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            ManagedCustomers.Add(customer);
            Console.WriteLine($"Admin {FullName} added Customer {customer.FullName}.");
        }

        /// <summary>
        /// Adds a new meter-reading employee to the system.
        /// </summary>
        public void AddEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            ManagedEmployees.Add(employee);
            Console.WriteLine($"Admin {FullName} added Employee {employee.FullName}.");
        }

        /// <summary>
        /// Generates a summary report for all bills in the system.
        /// </summary>
        public void GenerateReport(List<Bill> bills)
        {
            Console.WriteLine($"Admin {FullName} is generating billing report...");
            double totalRevenue = 0;
            foreach (var bill in bills)
            {
                totalRevenue += bill.AmountDue;
            }
            Console.WriteLine($"Total revenue for {bills.Count} bills: R{totalRevenue:F2}");
        }

        /// <summary>
        /// Reviews system logs (simulated).
        /// </summary>
        public void ReviewLogs()
        {
            Console.WriteLine($"Admin {FullName} is reviewing system logs...");
        }
    }
}
