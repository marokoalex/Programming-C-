using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            long myLong = myInt; // there's no warning on implicit type casting

            double myDouble = 5;
            Console.WriteLine(myDouble);
            myDouble = 5.0d;
            Console.WriteLine(myDouble);

            // Data Loss during conversion
            float myFloat = 5.2f;
            myInt = (int)myFloat; // Need an explicit type casting
            Console.WriteLine(myFloat);
            Console.WriteLine(myInt);


            const Int32 MASK_ONOFF = 0x0001;
            Int32 regVal = 0xfff0;
            regVal = regVal & MASK_ONOFF;
            regVal &= ~MASK_ONOFF;
            Console.WriteLine("regVal: " + regVal);
            regVal |= MASK_ONOFF;
            Console.WriteLine("regVal: " + regVal);
            Console.ReadKey();
        }
    }
}
