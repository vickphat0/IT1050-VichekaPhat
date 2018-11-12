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
            Console.WriteLine("your speed");
            speed = Convert.ToInt32(Console.ReadLine());
            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");

            }
                

                {


                    int istrue = 20;
                    Console.WriteLine("istrue");
                    istrue = Convert.ToInt32(Console.ReadLine());

                    if (istrue <= 21)
                    {
                        Console.WriteLine("It is True!");
                    }
                    else
                    {
                        Console.WriteLine("It is False!");
                    }





                    {
                        Console.WriteLine("Input temperature in Fahrenheit");
                        double fahrenheit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        double Celsius = (fahrenheit - 32d) * 5d / 9d;


                        if (fahrenheit >= 90)
                        {
                        Console.WriteLine("it is hot");
                        }

                        Console.ReadLine();

                        if (fahrenheit <= 40)
                        {
                        Console.WriteLine("it is cold");
                        }

                        Console.ReadLine();







                    }

                        





                       




                }



                         {
                            int x = 1;

                            while (x < 11)
                            {
                             Console.WriteLine(x); 

                             x++;
                            }


                            Console.ReadLine();


                            Console.WriteLine();

                            int a = 60;

                            while (a > 19)
                            {
                             Console.WriteLine(a);

                             a -= 5;
                            }


                             Console.ReadLine();

                         }


                                 {
                                    int x = 10;

                                    while (x < 21)
                                    {
                                        Console.WriteLine(x++);

                                        x++;
                                    }

                                         Console.ReadLine();





                                 }



























        }

    }       
                



              
}

