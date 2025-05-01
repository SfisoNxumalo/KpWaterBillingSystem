using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.DI;
using KpWaterBillingSystem.src.Repository.Interface;
using KpWaterBillingSystem.src.Repository.Storages;

namespace KpWaterBillingSystem.src.Repository
{
    public class Repo<T> 
    {
        private IGenericRepository<T, int> _dbContext;
        public Repo(IGenericRepository<T, int> dbContext) {
            _dbContext = dbContext;
        }

        public void delete(int id)
        {
            _dbContext.delete(id);
        }

        public List<T> findAll()
        {
            return _dbContext.findAll();
        }

        public T findById(int id)
        {
            return _dbContext.findById(id);
        }

        public void save(T entity)
        {
            _dbContext.save(entity);
        }
    }
}
