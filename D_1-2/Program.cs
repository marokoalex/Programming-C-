using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            string myName = "丸子";
            Console.WriteLine(myName);
            myName = Console.ReadLine();
            Console.WriteLine(myName);

            int myAge = 40;
            Console.WriteLine(myAge);
            myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myAge);

            float myHeight = 170.5f;
            Console.WriteLine(myHeight);
            myHeight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(myHeight);

            double tinyLength = 0.0000001;
            Console.WriteLine(tinyLength);
            tinyLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(tinyLength);

            bool myAnswer = true;
            Console.WriteLine(myAnswer);
            myAnswer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(myAnswer);

            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            today = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(today);
*/
            double minDouble = Double.MinValue;
            Console.WriteLine("Minimum Value of Double is: " + minDouble);
            float minFloat = float.MinValue;
            Console.WriteLine("Minimum Value of Float is: " + minFloat);
            Int32 maxInt32 = Int32.MaxValue;
            Console.WriteLine("Maximum Value of Int32 is: " + maxInt32);
            Int64 maxInt64 = Int64.MaxValue;
            Console.WriteLine("Maximum Value of Int64 is: " + maxInt64);


            int one = 1;
            int zero = 0;

            double dMinusOne = -1.0;
            double dZero = 0.0;
            Console.WriteLine(dMinusOne / zero); // -Infinity 
            Console.WriteLine(one / dZero); // Infinity 




            string myName = "丸子";
            int age = 40;
            float height = 170.5f;
            float weight = 70.0f;

            Console.WriteLine("嗨 我的名字叫{0}!", myName);
            Console.WriteLine("嗨 我的名字叫" + myName);


            Console.WriteLine("丸子今年40歲　身高170.5公分");
            Console.WriteLine(myName + "今年" + age + "歲　身高" + height + "公分");

            Console.WriteLine("請依序輸入姓名年齡身高");
            myName = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            
            height = (float)Convert.ToDouble(Console.ReadLine());
            height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(myName + "今年" + age + "歲　身高" + height + "公分");

            string yourName;

            yourName = Console.ReadLine();
            Console.WriteLine("你的名字叫" + yourName);

            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            

            Console.ReadKey(true);
            Console.ReadKey();
        }
    }
}
