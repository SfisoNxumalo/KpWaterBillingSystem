using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Repository.Interface;

namespace KpWaterBillingSystem.src.Repository.Storages
{
    public class SqlDb<T> : IGenericRepository<T, int>
    {
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> findAll()
        {
            throw new NotImplementedException();
        }

        public T findById(int id)
        {
            throw new NotImplementedException();
        }

        public void save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
