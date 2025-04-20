using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpWaterBillingSystem.CreationPattern
{
    public class AppConfig
    {
        private static AppConfig instance;
        private static readonly object lockObj = new object();

        public string ConnectionString { get; private set; }

        private AppConfig()
        {
            ConnectionString = "Server=localhost;Database=WaterApp;";
        }

        public static AppConfig Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new AppConfig();
                    }
                    return instance;
                }
            }
        }
    }
}
