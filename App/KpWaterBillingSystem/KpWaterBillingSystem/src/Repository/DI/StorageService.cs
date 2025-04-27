using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.Interface;

namespace KpWaterBillingSystem.src.Repository.DI
{
    public class StorageService<T>
    {
        private readonly IGenericRepository<T, int> _repository;

        public StorageService(IGenericRepository<T, int> repository) {
            _repository = repository;
        }

        public void Add(T entity, int id)
        {
            _repository.save(entity, id);
        }

        public T findById(int id)
        {
            return _repository.findById(id);
        }
        public List<T> findAll()
        {
            return _repository.findAll();
        }
        public void delete(int id)
        {
            _repository.delete(id);
        }
    }
}
