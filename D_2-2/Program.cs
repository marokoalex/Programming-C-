using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pins = { 0, 1, 2, 3 };
            int[] copy = (int[])pins.Clone();

            pins[3] = 10;
            Console.WriteLine("pins[3] = " + pins[3]); // 10
            Console.WriteLine("copy[3] = " + copy[3]); // 3



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
