using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6] { 0, 1, 2, 3, 4, 5 };
            //myArray[7] = 5;
            try
            {
                myArray[7] = 5;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // Usually for resource cleaning
            }



            System.Diagnostics.Debug.Assert(myArray[2] == 3, "Your data is not well initialized");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
