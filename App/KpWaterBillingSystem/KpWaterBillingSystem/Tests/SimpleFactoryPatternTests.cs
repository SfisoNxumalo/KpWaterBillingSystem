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
    public class SimpleFactoryPatternTests
    {
        [Test]
        public void CreateUser_ShouldReturnEmployee_WhenTypeIsEmployee()
        {
            var user = new UserSimpleFactoryPattern().CreateUser(
                UserType.Employee,
            id: 1,
            name: "Alice", 
                email: "alice@example.com");

            Assert.That(user, Is.InstanceOf<Employee>());
            Assert.That("Alice", Is.EqualTo(user.Name));
            Assert.That("alice@example.com", Is.EqualTo(user.Email));
        }

        [Test]
        public void CreateUser_ShouldReturnCustomer_WhenTypeIsCustomer()
        {
            var user = new UserSimpleFactoryPattern().CreateUser(
                UserType.Customer,
                id: 2,
                name: "Bob",
                email: "bob@example.com",
                address: "123 Main St");

            Assert.That(user, Is.InstanceOf<Customer>());
            Assert.That("Bob", Is.EqualTo(user.Name));
            Assert.That("bob@example.com", Is.EqualTo(user.Email));
        }
    }
}
