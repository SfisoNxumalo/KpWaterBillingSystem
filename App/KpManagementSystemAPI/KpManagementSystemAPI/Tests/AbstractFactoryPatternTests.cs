using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.CreationPattern;
using KpWaterBillingSystem.src.Model;
using NUnit.Framework;

namespace KpWaterBillingSystem.Tests
{
    [TestFixture]
    public class AbstractFactoryPatternTests
    {
        [Test]
        public void EmployeeAbstractFactory_ShouldCreateEmployeeAndReport()
        {
            IUserReportAbstractFactoryPattern factory = new EmployeeAbstractFactoryPattern();
            var user = factory.CreateUser(1, "Alice", "Addr", "alice@ex.com");
            var report = factory.CreateReport();

            Assert.That(user, Is.InstanceOf<Employee>());
            Assert.That(report, Is.InstanceOf<EmployeeReport>());
        }

        [Test]
        public void CustomerAbstractFactory_ShouldCreateCustomerAndReport()
        {
            IUserReportAbstractFactoryPattern factory = new CustomerAbstractFactoryPattern();
            var user = factory.CreateUser(2, "Bob", "Addr", "bob@ex.com");
            var report = factory.CreateReport();

       
            Assert.That(user, Is.InstanceOf<Customer>());
            Assert.That(report, Is.InstanceOf<EmployeeReport>());
        }
    }
}
