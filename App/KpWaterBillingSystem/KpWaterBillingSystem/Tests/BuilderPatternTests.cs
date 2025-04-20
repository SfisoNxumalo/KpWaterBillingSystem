using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.CreationPattern.srccc;
using KpWaterBillingSystem.src.Model;
using NUnit.Framework;

namespace KpWaterBillingSystem.Tests
{
    [TestFixture]
    public class BuilderPatternTests
    {
        [Test]
        public void BillBuilder_ShouldBuildBillWithGivenProperties()
        {
            var readings = new List<WaterReading>
            {
                new WaterReading(1, 1, DateTime.Now, 10, "path1"),
                new WaterReading(2, 1, DateTime.Now, 5, "path2")
            };

            var builder = new BillBuilderPattern();
            var director = new BillingDirectorPattern(builder);
            var bill = director.ConstructStandardBill(1, readings);

            Assert.That(1, Is.EqualTo(bill.CustomerId));
            Assert.That(readings, Is.EqualTo(bill.Readings));
            Assert.That(DateTime.Now.Date, Is.EqualTo(bill.BillingDate.Date));
            Assert.That(DateTime.Now.AddDays(30).Date, Is.EqualTo(bill.DueDate.Date));
        }

        [Test]
        public void BillBuilder_Reset_ShouldProduceNewInstanceOnSubsequentBuilds()
        {
            var builder = new BillBuilderPattern();
            var bill1 = builder.Reset().Build();
            var bill2 = builder.Build();

            Assert.That(bill1, Is.Not.EqualTo(bill2));
        }
    }
}
