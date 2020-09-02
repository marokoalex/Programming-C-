using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Beep();
            System.Threading.Thread.Sleep(500);
            System.Console.Beep();
            System.Threading.Thread.Sleep(500);
            System.Console.Beep();

            int i = 0;
            for (; i < 3;)
            {
                i++;
                System.Console.WriteLine(i);
            }



            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            foreach (string friendName in friendNames)
            {
                Console.WriteLine(friendName);
            }
            Random rand = new Random();
            for (int number = 1; number <= 6; number++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.Write("{0} ", randomNumber);
            }



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
