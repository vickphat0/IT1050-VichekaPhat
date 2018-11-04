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
            Console.WriteLine("{0}\n{1}", "Hello World!", "From Vicheka Phat");
            
            Console.Write("{0}\t{1}", "Hello World!", "From Vicheka Phat");

            // A. The console application starts after you have created a new project and then typing in the nescessary code to and then running it.
            // B. An integer type variable is a number without a decimal point. A double/floating-point variable are numbers that does have a decimal point. 
            //Double is a double precision floating point data while float is a single precision. 
            // C. 





            Console.ReadLine();


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
                product = number1 * number2;


                Console.WriteLine("Product is {0}", product); // display product




            
        } 
    }
}
