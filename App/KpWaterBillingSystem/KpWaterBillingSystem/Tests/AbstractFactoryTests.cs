using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.CreationPattern;
using KpWaterBillingSystem.src.Interface;
using KpWaterBillingSystem.src.Model;
using NUnit.Framework;

namespace KpWaterBillingSystem.Tests
{
    [TestFixture]
public class AbstractFactoryTests
    {
        [Test]
        public void CreateUserAndReport_ShouldReturnCorrectTypes()
        {
            IUserReportFactory factory = new EmployeeFactory();
            var user = factory.CreateUser("Alice", "alice@example.com");
            var report = factory.CreateReport();

            Assert.That(user, Is.TypeOf<Employee>);
            Assert.That(report, Is.TypeOf<EmployeeReport>);
        }
    }
}
