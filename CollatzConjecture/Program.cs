using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        private static void Main()
        {
            int n = 0;
            int steps = 1;

            Console.WriteLine("******** COLLATZ CONJECTURE ********\n\n\n");
            Console.Write("Enter a number greater than 1>>> ");
            string number = Console.ReadLine();

            try
            {
                n = Int32.Parse(number);
            }
            catch
            {
                Console.WriteLine("Invalid input, restarting...");
                Main();
            }

            while (n != 1)
            {
                if (n%2 == 0)
                {
                    n = n/2;
                }
                else
                {
                    n = n*3 + 1;
                }
                steps++;
            }

            Console.WriteLine($"It took {steps} steps to reach {n} from {number}");
            Console.ReadKey();
        }
    }
}
