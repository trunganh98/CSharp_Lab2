using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    class CS5_S4
    {
        static void Main(string[] args)
        {
            int yrsOfService = 3;
            double salary = 1500;
            int bonus = 0;
            if (yrsOfService < 5)
            {
                if (salary < 500)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else
            {
                bonus = 700;
            }
            Console.WriteLine("Bonus amount: " +bonus);
        }
    }
}
