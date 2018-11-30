using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            month[0] = "January";
            month[1] = "Febraury";
            month[2] = "March";
            month[3] = "April";
            month[4] = "May";
            month[5] = "June";
            month[6] = "July";
            month[7] = "August";
            month[8] = "September";
            month[9] = "October";
            month[10] = "November";
            month[11] = "December";

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(month[i]);
            }

            Console.WriteLine();

                
                     String[] seasons = { "Fall", "Winter", "Spring", "Summer" };

                     foreach (string season in seasons)
                     {
                       Console.WriteLine(season);
                     }

            Console.WriteLine();

            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 100);
            }

            foreach (int i in randomNumber)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine();

                    {
                         string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                         int i = 0;
                         foreach (string name in names)
                         {
                            Console.WriteLine("{0,2}. {1}", i, names[i]);

                            i++;
                         }



                    }







        }
    }
}
