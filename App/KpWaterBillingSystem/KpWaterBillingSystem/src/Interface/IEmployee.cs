using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KpWaterBillingSystem.src.Model;

namespace KpWaterBillingSystem.src.Interface
{
    // IEmployee.cs
    public interface IEmployee
    {
        /// <summary>
        /// Submit a water reading on behalf of a customer.
        /// </summary>
        /// <param name="reading">The reading to submit.</param>
        void SubmitReading(WaterReading reading);

        /// <summary>
        /// Display basic employee info for logging or debug.
        /// </summary>
        void DisplayEmployeeInfo();
    }

}
