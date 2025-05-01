using NUnit.Framework;
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.Storages;
using KpWaterBillingSystem.src.Repository.DI;
using System;

namespace KpWaterBillingSystem.Tests
{
    [TestFixture]
    public class StorageServiceTests
    {
        private StorageService<Employee> _service;
        private InMemoryDB<Employee> _inMemoryDb;

        [SetUp]
        public void Setup()
        {
            _inMemoryDb = new InMemoryDB<Employee>();
            _service = new StorageService<Employee>(_inMemoryDb);
        }

        [Test]
        public void Add_ShouldSaveEmployeeSuccessfully()
        {
            // Arrange
            var employee = new Employee(1, "Sifiso Mawila", "sfisomawila69@gmail.com");

            // Act
            _service.Add(employee, employee.EmployeeId);
            var result = _service.findById(employee.EmployeeId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("Sifiso Mawila"));
        }

        [Test]
        public void FindById_ShouldReturnCorrectEmployee()
        {
            // Arrange
            var employee = new Employee(2, "Ben Mawila", "benmawila69@gmail.com");
            _service.Add(employee, employee.EmployeeId);

            // Act
            var result = _service.findById(employee.EmployeeId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("Ben Mawila"));
        }

        [Test]
        public void FindAll_ShouldReturnAllEmployees()
        {
            // Arrange
            var employee1 = new Employee(3, "Mike Mawila", "mikemawila69@gmail.com");
            var employee2 = new Employee(4, "Eddy Mawila", "eddymawila69@gmail.com");
            _service.Add(employee1, employee1.EmployeeId);
            _service.Add(employee2, employee2.EmployeeId);

            // Act
            var allEmployees = _service.findAll();

            Assert.That(2, Is.EqualTo(allEmployees.Count));
        }

        [Test]
        public void Delete_ShouldRemoveEmployee()
        {
            // Arrange
            var employee = new Employee(5, "Delete Test", "delete@test.com");
            _service.Add(employee, employee.EmployeeId);

            // Act
            _service.delete(employee.EmployeeId);

            // Assert
            Assert.Throws<KeyNotFoundException>(() => _service.findById(employee.EmployeeId));
        }

        [Test]
        public void Delete_NonExistingId_ShouldNotThrow()
        {
            // Arrange & Act & Assert
            Assert.DoesNotThrow(() => _service.delete(9999));
        }

        [Test]
        public void FindById_NonExistingId_ShouldThrowException()
        {
            // Arrange & Act & Assert
            Assert.Throws<KeyNotFoundException>(() => _service.findById(100));
        }

        [Test]
        public void Save_DuplicateId_ShouldThrowException()
        {
            // Arrange
            var employee = new Employee(6, "Duplicate Test", "duplicate@test.com");
            _service.Add(employee, employee.EmployeeId);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _service.Add(employee, employee.EmployeeId));
        }
    }
}