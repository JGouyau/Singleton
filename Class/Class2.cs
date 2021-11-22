using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Class
{
    class Class2
    {
        int ID { get; set; }
        string stringUn { get; set; }
        string stringDeux { get; set; }
        string stringTrois { get; set; }

        DataBaseSingleton DataBase { get;  }

        public Class2()
        {
            DataBase = DataBaseSingleton.GetSingleton();
        }
    }
}
