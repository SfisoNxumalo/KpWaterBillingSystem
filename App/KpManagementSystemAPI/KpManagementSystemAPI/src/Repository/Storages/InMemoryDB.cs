using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.Interface;

namespace KpWaterBillingSystem.src.Repository.Storages
{
    public class InMemoryDB<T> : IGenericRepository<T, int>
    {
        private static Dictionary<int, T> dict = new Dictionary<int, T>();
        public void delete(int id)
        {
            dict.Remove(id);
        }

        public List<T> findAll()
        {
            List<T> list = new List<T>();
            foreach (T emp in dict.Values)
            {
                
                list.Add(emp);
            }

            return list;
        }

        public T findById(int id)
        {
            return dict[id];
        }

        public void save(T entity)
        {
            dict.Add((dict.Count + 1), entity);
        }
    }
}
