using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem5 : IProblem
    {
        public string Title()
        {
            return @"5. Smallest multiple";
        }
        public string Answer()
        {
            return Title() + @"

2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

";
        }
    }
}
