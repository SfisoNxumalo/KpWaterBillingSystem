
using NUnit.Framework;

namespace KpWaterBillingSystem.Tests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void Singleton_ShouldReturnSameInstance()
        {
            var instance1 = BillingManager.GetInGetInstancestance();
            var instance2 = BillingManager.GetInstance();

            Assert.That(instance1, instance2);
        }
    }
}
