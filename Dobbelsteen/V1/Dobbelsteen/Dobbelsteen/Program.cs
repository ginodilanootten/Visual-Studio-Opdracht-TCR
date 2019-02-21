using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobbelsteen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object
            Dobbelsteen steen1 = new Dobbelsteen();
            int getal = steen1.Gooi();

            Console.WriteLine("getal=" + getal);
            Console.Read();
        }
    }
}
