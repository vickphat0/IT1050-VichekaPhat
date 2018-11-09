using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*These two statements are similar because they both select between two actions. 
            However, for the while repetition statement, it allows apps to perform statements repeatedly.*/


            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 45;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");

            }

        }
    }
}
