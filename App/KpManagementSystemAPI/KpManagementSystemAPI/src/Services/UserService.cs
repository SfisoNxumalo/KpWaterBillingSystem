using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository;
using KpWaterBillingSystem.src.Repository.DI;

namespace KpManagementSystemAPI.src.Services
{
    public class UserService
    {
        private readonly StorageService<Employee> _service;
        public UserService(StorageService<Employee> service)
        {
            _service = service;
        }

        public void delete(int id)
        {
            _service.delete(id);
        }

        public List<Employee> findAll()
        {
            return _service.findAll();
        }

        public Employee findById(int id)
        {
            return _service.findById(id);
        }

        public void save(Employee entity)
        {
            _service.Add(entity);
        }

    }
}
