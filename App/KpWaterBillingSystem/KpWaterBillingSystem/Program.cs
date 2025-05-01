using System.Collections.Generic;
using KpWaterBillingSystem.CreationPattern;
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.DI;
using KpWaterBillingSystem.src.Repository.Interface;
using KpWaterBillingSystem.src.Repository.Storages;

namespace KpWaterBillingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("==== KP Water Billing System Started ====\n");

            //InMemoryDB<Employee> db = new InMemoryDB<Employee>();
            //SqlDb<Employee> sql = new SqlDb<Employee>(); //implements the IGenericRepository. This is can be swapped for the InMemoryDb

            //StorageService<Employee> service = new StorageService<Employee>(db);

            //Employee emp1 = new Employee(1, "Sifiso Mawila", "sfisomawila69@gmail.com");
            //Employee emp2 = new Employee(2, "Ben Mawila", "benmawila69@gmail.com");
            //Employee emp3 = new Employee(3, "Mike Mawila", "Mikemawila69@gmail.com");
            //Employee emp4 = new Employee(5, "Eddy Mawila", "Eddymawila69@gmail.com");

            //service.Add(emp1, emp1.EmployeeId);
            //service.Add(emp2, emp2.EmployeeId);
            //service.Add(emp3, emp3.EmployeeId);
            //service.Add(emp4, emp4.EmployeeId);

            //service.findById(emp1.EmployeeId);
            //service.findAll().ForEach(employee => { Console.WriteLine(employee.Name); });

            //service.delete(emp1.EmployeeId);


            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "yes");
            dict.Add(2, "yess");
            dict.Add(3, "yesss");
            dict.Add(4, "yesss");

            List<string> list = new List<string>();
            foreach (string emp in dict.Values)
            {
                list.Add(emp);
            }


            list.ForEach(employee => { Console.WriteLine(employee); });

            Console.WriteLine(dict.Count);
        }
    }
}
