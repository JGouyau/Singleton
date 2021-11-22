using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class DataBaseSingleton
    {
        private static DataBaseSingleton instance = null;

        private DataBaseSingleton()
        {
        }

        public static DataBaseSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBaseSingleton();
                }
                return instance;
            }
        }

        public static DataBaseSingleton GetSingleton()
        {
            return Instance;
        }
    }
}
