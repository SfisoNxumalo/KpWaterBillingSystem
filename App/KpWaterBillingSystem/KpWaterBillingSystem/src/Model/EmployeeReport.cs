using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Repository.Interface;

namespace KpWaterBillingSystem.src.Model
{
    public class EmployeeReport : IReport
    {
        public void delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<WaterReport> findAll()
        {
            throw new NotImplementedException();
        }

        public WaterReport findById(string id)
        {
            throw new NotImplementedException();
        }

        public string Generate()
        {
            return "Employee report generated with usage details and submission stats.";
        }

        public void save(WaterReport entity)
        {
            throw new NotImplementedException();
        }

        public void save(WaterReport entity, string id)
        {
            throw new NotImplementedException();
        }
    }
}
