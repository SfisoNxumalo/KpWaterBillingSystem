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

       
    }
}
