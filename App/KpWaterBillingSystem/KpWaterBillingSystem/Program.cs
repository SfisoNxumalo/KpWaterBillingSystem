using KpWaterBillingSystem.CreationPattern;
using KpWaterBillingSystem.src.Interface;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== KP Water Billing System Started ====\n");


            var userFactory = new UserSimpleFactoryPattern();
            IUser employee = userFactory.CreateUser(UserType.Employee, 1, "Alice", "alice@kpwater.com");
            IUser customer = userFactory.CreateUser(UserType.Customer, 2, "Bob", "bob@gmail.com");

            employee.DisplayRole();
            customer.DisplayRole();
            Console.WriteLine();


            IUserReportAbstractFactoryPattern employeeFactory = new EmployeeAbstractFactoryPattern();
            IEmployee employee2 = employeeFactory.CreateUser(1, "Charlie", "Cape town", "charlie@kpwater.com");
            IReport empReport = employeeFactory.CreateReport();

            Console.WriteLine(empReport.Generate());


            var billBuilder = new BillBuilderPattern();
            var director = new BillingDirectorPattern(billBuilder);
            director.ConstructStandardBill(1, new List<WaterReading> { });

            Console.WriteLine("\n==== System Shutdown ====");
        }
    }
}
