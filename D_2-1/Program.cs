using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_2_1
{
    class Program
    {
        enum Season { Spring, Summer, Fall, Winter }
        enum orientation { n, e, w, s}
        struct route
        {
            public orientation direction;
            public double distance;
        }
        static void Main(string[] args)
        {
            Season currSeason = Season.Summer;
            string strCurrentSeason = currSeason.ToString();
            Console.WriteLine("Current Season is \"" + currSeason + "\"");

            route myRoute;
            myRoute.direction = orientation.n;
            myRoute.distance = 1000;

            Console.ReadKey();
        }
    }
}
