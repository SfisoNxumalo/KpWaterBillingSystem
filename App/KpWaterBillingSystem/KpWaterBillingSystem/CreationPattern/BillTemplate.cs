using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.CreationPattern
{
    public class BillTemplate : ICloneable
    {
        public string Header;
        public decimal BaseRate;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
