using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("請輸入數字");
            string numString = Console.ReadLine();
            float number = 0;
            bool canConvert = float.TryParse(numString, out number);
            if (canConvert == true)
            {
                Console.WriteLine("number is {0}", number);
            }
            else
            { 
                Console.WriteLine("This is not a valid numeric number");
            }


            //
            float age;
            while(!GetNumericValue(out age))
            {
                Console.WriteLine("格式錯誤, 再試試");
            }


            //
            float height;
            while (!GetNumericValue("身高", out age))
            {
                Console.WriteLine("格式錯誤, 再試試");
            }
            float weight;
            while (!GetNumericValue("體重", out age))
            {
                Console.WriteLine("格式錯誤, 再試試");
            }


            //
            Console.WriteLine("請按任意鍵離開...");
            Console.ReadKey(true);
        }

        static bool GetNumericValue(out float value)
        {
            Console.WriteLine("請輸入年紀");
            string numString = Console.ReadLine();
            value = 0;
            bool canConvert = float.TryParse(numString, out value);
            if (canConvert == true)
            {
                Console.WriteLine("number is {0}", value);
                return true;
            }
            
            Console.WriteLine("This is not a valid numeric number");
            return false;
        }

        static bool GetNumericValue(string message, out float value)
        {
            Console.WriteLine("請輸入" + message);
            string numString = Console.ReadLine();
            value = 0;
            bool canConvert = float.TryParse(numString, out value);
            if (canConvert == true)
            {
                Console.WriteLine(message + ": " + value);
                return true;
            }

            Console.WriteLine("This is not a valid value for " + message);
            return false;
        }
    }
}
