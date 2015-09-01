using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem3 : IProblem
    {
        public string Title()
        {
            return @"3. Largest prime factor";
        }

        public string Answer()
        {
            return Title() + @"

The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?

";
        }
    }
}
