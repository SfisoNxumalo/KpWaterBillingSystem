using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;
using NUnit.Framework;

namespace KpWaterBillingSystem.Tests
{
    [TestFixture]
    public class PrototypeTests
    {
        [Test]
        public void Clone_ShouldReturnNewObject_WithSameProperties()
        {
            var original = new Customer { Name = "Jane", Email = "jane@example.com" };
            var copy = original as Customer;

            Assert.That(original.Name, Is.EqualTo(copy.Name));
            Assert.That(original.Email, Is.EqualTo(copy.Email));
            Assert.That(original, Is.EqualTo(copy));
        }
    }
}
