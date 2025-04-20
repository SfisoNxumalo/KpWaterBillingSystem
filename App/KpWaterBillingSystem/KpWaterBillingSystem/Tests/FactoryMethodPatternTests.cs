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
    public class FactoryMethodPatternTests
    {
        [Test]
        public void EmployeeReportFactory_ShouldCreateEmployeeReportInstance()
        {
            IReportFactoryMethodPattern factory = new EmployeeReportFactoryMethodPattern();
            var report = factory.CreateReport();
            Assert.That(report, Is.InstanceOf<EmployeeReport>());
            Assert.That(report.Generate(), Does.Contain("Employee report"));
        }

        [Test]
        public void CustomerReportFactory_ShouldCreateCustomerReportInstance()
        {
            IReportFactoryMethodPattern factory = new CustomerReportFactoryMethodPattern();
            var report = factory.CreateReport();
            Assert.That(report, Is.InstanceOf<EmployeeReport>());
            Assert.That(report.Generate(), Does.Contain("Customer report"));
        }
    }
}
