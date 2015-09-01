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
            var problems = new List<IProblem>
            {
                new Problem1(),
                new Problem2(),
                new Problem3(),
                new Problem4(),
                new Problem5()
            };
            do
            {
                Console.Clear();
                Console.WriteLine("Project Euler\r\n");
                foreach (var problem in problems)
                {
                    Console.WriteLine(problem.Title());
                }
                Console.WriteLine("\r\nEnter problem:");
                int i = 0;
                i = Int32.Parse(Console.ReadLine()) - 1;
                Console.Clear();
                

                Console.WriteLine(problems[i].Answer());

                while (!Console.KeyAvailable)
                {
                    // Do something
                }
            } while (Console.ReadKey(true).Key == null);
        }

    }
}