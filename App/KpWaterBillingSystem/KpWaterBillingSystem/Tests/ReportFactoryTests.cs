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
    public class ReportFactoryTests
    {
        [Test]
        public void CreateReport_ShouldReturnEmployeeReport_WhenTypeIsEmployee()
        {
            var report =  EmployeeFactory.CreateReport();
            Assert.That(report, Is.TypeOf<EmployeeReport>(report));
        }

        [Test]
        public static void CreateReport_ShouldReturnNull_ForInvalidType()
        {
            var report = EmployeeFactory.CreateReport();
            Assert.That(report, Is.Not.Null);
        }
    }
}
