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
    public class SingletonPatternTests
    {
        [Test]
        public void Instance_ShouldReturnSameObjectAcrossThreads()
        {
            BillingManagerSingletonPattern first = null;
            BillingManagerSingletonPattern second = null;

            Parallel.Invoke(
                () => first = BillingManagerSingletonPattern.Instance,
                () => second = BillingManagerSingletonPattern.Instance
            );

            Assert.That(first, Is.Not.Null);
            Assert.That(first, Is.EqualTo(second));
        }

        [Test]
        public void CalculateBill_ShouldThrowOnNegativeConsumption()
        {
            var manager = BillingManagerSingletonPattern.Instance;
            var reading = new WaterReading(1, 1, DateTime.Now, -5, "path");

            Assert.Throws<ArgumentException>(
                () => manager.CalculateBill(reading)
            );
        }

        [Test]
        public void CalculateBill_ShouldReturnCorrectAmount()
        {
            var manager = BillingManagerSingletonPattern.Instance;
            // Assuming default RatePerUnit = 12.50m
            var reading = new WaterReading(1, 1, DateTime.Now, 4, "path");
            var expected = 4 * 12.50m;

            Assert.That(expected, Is.EqualTo(manager.CalculateBill(reading)));
        }
    }
}