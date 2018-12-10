using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 12;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (y <= 11)

                    keepLooping = false;
                y++;
                Console.WriteLine(y);


            }

            Console.WriteLine("");
            Console.WriteLine("");

            int i = 2;
            while (i <= 128)
            {
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("[{0}]", i);
                    }
                    else if ((i % 2) != 0)
                    {
                        Console.Write("");
                    }
                    i *= 2;


                }
            }


            Console.WriteLine("");
            Console.WriteLine("");



            {
                string j = ",";
                int p;
                for (p = 49; p >= 1; --p)
                {
                    Console.Write(p);
                    if (p >= 2)
                    {
                        Console.Write(j);
                    }

                }


            }

            Console.WriteLine("");
            Console.WriteLine("");

            {
                int x = 1;
                while (x <= 21)
                {
                    {
                        if ((x % 2) == 0)
                        {
                            Console.Write(" ");
                        }
                        else if ((x % 2) != 0)
                        {
                            Console.Write(x);
                        }
                         x++;
                    }
                }

            }


            Console.WriteLine("");
            Console.WriteLine("");

            {
                bool icyRain = false, tornadoWarning = false;

                if (icyRain == false && tornadoWarning == false)

                {
                    Console.WriteLine("Lets go outside");
                }

            }





        }
    }
}
