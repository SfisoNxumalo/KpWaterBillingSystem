using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.src.Repository.Interface
{
    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        void DisplayRole();
    }
}
