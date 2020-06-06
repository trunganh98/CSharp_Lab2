using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    class CS9_S4
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j;
            while (i <= 5)
            {
                j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
