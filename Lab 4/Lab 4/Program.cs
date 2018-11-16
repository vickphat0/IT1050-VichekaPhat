using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Four basic elements of the counter-controlled repetition are the following:
                1. Control Variable - also known as a loop counter
                2. The initial value of the control variable
                3. The increment/decrement by which the control variable is modified each time through the loop
                   also known as each iteration of the loop.
                4. The loop-continuation condition that determines whether to continue looping*/

            /* The while statement can be used to implement any counter-controlled loop and
               for repetition statement, it specifies the elements of counter-controlled-repetition 
               in a single line of code. The key difference between the two is organization.
               For Loops allow you to run through the loop when you know how many times you'd like it 
               to run through the problem until the condition returns false. While Loops allow you a 
               little more flexability in what you put in it and also when it will stop.*/

            /* In the while statement, the app tests the loop-continuation condition at the beginning of the loop, 
               before executing the loop’s body. The do-while statement would test the condition after excuting the loop's body.*/


            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);

                if ((i % 2) == 0)
                {
                    Console.WriteLine("Number is even");

                }

                else if ((i % 2) != 0)
                {
                    Console.WriteLine("Number is odd");
                }
            }


                

                {
                    Console.Write("Please enter a temperature: ");
                    int temp = Convert.ToInt32(Console.ReadLine());
                    if (temp >= 90)

                    {
                        Console.WriteLine("Fish");
                    }

                    else if (temp >= 80)

                    {
                        Console.WriteLine("Lion");
                    }

                    else if (temp >= 70)

                    {
                        Console.WriteLine("Turtle");
                    }

                    else if (temp >= 60)

                    {
                        Console.WriteLine("Deer");
                    }

                    else if (temp >= 50)

                    {
                        Console.WriteLine("Reindeer");
                    }

                    else if (temp >= 40)

                    {
                        Console.WriteLine("Moose");
                    }

                    else if (temp >= 20)

                    {
                        Console.WriteLine("Penguin");
                    }

                    else if (temp >= 10)

                    {
                        Console.WriteLine("Polar Bear");
                    }

                    else

                    {
                        Console.WriteLine("Bug");
                    }

                            Console.ReadLine();

                }





            {
                int i = 10;
                while (i < 21)
                {
                    Console.WriteLine(i);

                    i++;
                }
            }



                    {
                        for (int i = 0; i < 101; i++)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine("********");
                        }

                    }



            
















        }
    }
}
