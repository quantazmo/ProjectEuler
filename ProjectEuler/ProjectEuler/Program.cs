using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine(@"Project Euler

1. Multiples of 3 and 5
2. Even Fibonacci numbers
3. Largest prime factor
4. Largest palindrome product
5. Smallest multiple

Enter problem:");
                var response = Console.ReadLine();
                Console.Clear();

                IProblem problem = null;

                if (response == "1") problem = new Problem1();
                else if (response == "2") problem = new Problem2();
                else if (response == "3") problem = new Problem3();
                else if (response == "4") problem = new Problem4();
                else if (response == "5") problem = new Problem5();

                Console.WriteLine(problem.Answer());

                while (!Console.KeyAvailable)
                {
                    // Do something
                }
            } while (Console.ReadKey(true).Key == null);
        }

    }
}