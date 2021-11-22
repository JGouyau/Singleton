using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Singleton.Class
{
    class Class1
    {
        int ID { get; set; }
        int valeurUn { get; set; }
        int valeurDeux { get; set; }
        int valeurTrois { get; set; }

        public Class1()
        {
            var Database = DataBaseSingleton.GetSingleton();
        }

        


    }
}
