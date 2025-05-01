using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.DI;
using KpManagementSystemAPI.src.Services;
using KpWaterBillingSystem.src.Repository.Interface;

namespace KpWaterBillingSystem.Tests.Services
{
    [TestFixture]
    public class UserServiceTests
    {
        private Mock<StorageService<Employee>> _mockStorageService;
        private UserService _userService;

        [SetUp]
        public void Setup()
        {
            _mockStorageService = new Mock<StorageService<Employee>>();
            _userService = new UserService(_mockStorageService.Object);
        }

        [Test]
        public void Save_CallsAddOnStorageService()
        {
            var employee = new Employee(1, "John Doe", "john@example.com");

            _userService.save(employee);

            _mockStorageService.Verify(s => s.Add(employee), Times.Once);
        }

        [Test]
        public void Delete_CallsDeleteOnStorageService()
        {
            int id = 1;

            _userService.delete(id);

            _mockStorageService.Verify(s => s.delete(id), Times.Once);
        }

        [Test]
        public void FindAll_ReturnsAllEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee(1, "Jane Doe", "jane@example.com"),
                new Employee(2, "John Smith", "john@example.com")
            };

            _mockStorageService.Setup(s => s.findAll()).Returns(employees);

            var result = _userService.findAll();

            Assert.That(result, Is.EqualTo(employees));
        }

        [Test]
        public void FindById_ReturnsCorrectEmployee()
        {
            int id = 1;
            var employee = new Employee(id, "Jane Doe", "jane@example.com");

            _mockStorageService.Setup(s => s.findById(id)).Returns(employee);
            var result = _userService.findById(id);

            Assert.That(result, Is.EqualTo(employee));
        }
    }
}
