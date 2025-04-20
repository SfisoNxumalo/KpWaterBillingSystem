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
    public class UserFactoryMethodTests
    {
        [Test]
        public void CreateUser_ShouldReturnCustomer_WhenCalledFromCustomerFactory()
        {
            IUserReportFactory factory = new CustomerFactory();
            var user = factory.CreateUser("John", "john@example.com");


            Assert.That("John", Is.EqualTo(user.Name));
        }
    }
}
