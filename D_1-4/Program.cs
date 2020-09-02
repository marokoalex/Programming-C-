using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a comment here

            /* The following code is for ...
             * 
             */
            #region Comparison Operators
            int x = 10, y = 5;
            Console.WriteLine("x > y : " + (x > y)); // True 
            Console.WriteLine("x < y : " + (x < y)); // False 
            Console.WriteLine("x >= y : " + (x >= y)); // True 
            Console.WriteLine("x <= y : " + (x <= y)); // False 
            Console.WriteLine("x == y : " + (x == y)); // False 
            Console.WriteLine("x != y : " + (x != y)); // True 

            #endregion

            #region Logical Operators
            /*
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b); // False 
            Console.WriteLine(a || b); // True 
            Console.WriteLine(!b); // True 
            Console.WriteLine(b || true); // True 
            */
            #endregion

            #region bitwise
            byte a = 3; // 0000 0011 = 3 
            byte b = 5; // 0000 0101 = 5 
            Console.WriteLine(a | b); // 0000 0111 = 7 
            Console.WriteLine(a & b); // 0000 0001 = 1 
            Console.WriteLine(a ^ b); // 0000 0110 = 6 
            Console.WriteLine(~a & b); // 0000 0100 = 4 
            Console.WriteLine(a << 1); // 0000 0110 = 6 
            Console.WriteLine(a << 2); // 0000 1100 = 12 
            Console.WriteLine(a >> 1); // 0000 0001 = 1

            #endregion

            // wait user to end this program
            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}
