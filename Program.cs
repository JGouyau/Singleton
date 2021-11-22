using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseSingleton DataBase = DataBaseSingleton.GetSingleton();
            DataBaseSingleton DataBase2 = DataBaseSingleton.GetSingleton();

            if (DataBase == DataBase2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.ReadKey();
        } 
    }
}
