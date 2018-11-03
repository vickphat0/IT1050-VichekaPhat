using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; //10
            int number2; //5
            int product; //50

            Console.Write("10"); // prompt user
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("5"); // prompt user
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            //product = 10 * 5; // 50
            // Let's use the numbers that were input
            product = number1 * number2


            Console.WriteLine("Product is {0}", product); // display product


        }
    }
}
