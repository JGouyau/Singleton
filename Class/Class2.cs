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

        public Class2()
        {
            var Database = DataBaseSingleton.GetSingleton();
        }
    }
}
