using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shinycalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int shinyChance = 8192;
            int numChosen = 0;
            int counter = 0;

            Random rnd = new Random();

            while(numChosen != shinyChance)
            {
                numChosen = rnd.Next(8193);
                counter++;

                if (counter % 100 == 0)
                    Console.WriteLine("Running... " + counter);
            }

            Console.Write("Number chosen in " + counter + " tries.");
            Console.ReadLine();
        }
    }
}
