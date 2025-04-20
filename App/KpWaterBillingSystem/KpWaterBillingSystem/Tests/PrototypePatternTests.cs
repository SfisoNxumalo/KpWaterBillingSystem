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
    public class PrototypePatternTests
    {
        [Test]
        public void CustomerPrototype_ShouldCloneProperly()
        {
            var original = new CustomerPrototypePattern(1, "Jane", "Addr", "jane@ex.com");
            var clone = (CustomerPrototypePattern)original.Clone();

            Assert.That(original.FullName, Is.EqualTo(clone.FullName));
            Assert.That(original.Email, Is.EqualTo(clone.Email));
            Assert.That(original, Is.Not.EqualTo(clone));
        }

        [Test]
        public void BillPrototype_ShouldCloneWithSameReadingsButDifferentReference()
        {
            var readings = new List<WaterReading>
            {
                new WaterReading(1, 1, DateTime.Now, 3, "path")
            };
            var original = new BillPrototypePattern(1, 1, DateTime.Now, DateTime.Now.AddDays(30), readings);
            var clone = (BillPrototypePattern)original.Clone();

            Assert.That(original.AmountDue, Is.EqualTo(clone.AmountDue));
            Assert.That(original.Readings.Count, Is.EqualTo(clone.Readings.Count));
            Assert.That(original, Is.Not.EqualTo(clone));
        }
    }
}
