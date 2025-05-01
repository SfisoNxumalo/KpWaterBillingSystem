using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.src.Repository.Interface
{
    public interface IGenericRepository<T, ID>
    {
        void save(T entity); // Create/Update
        T findById(ID id); // Read
        List<T> findAll(); // Read All
        void delete(ID id);
    }
}
