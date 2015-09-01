using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem1 : IProblem
    {
        public string Title()
        {
            return @"1. Multiples of 3 and 5";
        }

        public string Answer()
        {
            return Title() + @"

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23. 

Find the sum of all the multiples of 3 or 5 below 1000.

" + SumOfTwoMultiples(3, 5, 999).ToString();
        }

        internal int SumOfTwoMultiples(int mult1, int mult2, int limit)
        {
            if ((mult1 < 1) || (mult2 < 1)) throw new ArgumentOutOfRangeException("Multipliers cannot be less than 1.");
            if ((limit < mult1) || (limit < mult2)) throw new ArgumentOutOfRangeException("Limit cannot be less than a multiplier.");

            var sum1 = SumOfMultiples(mult1, limit);
            var sum2 = SumOfMultiples(mult2, limit);
            var duplicateSums = SumOfMultiples(mult1 * mult2, limit);
            return sum1 + sum2 - duplicateSums;
        }

        internal int SumOfMultiples(int multiplier, int limit)
        {
            if (multiplier < 1) throw new ArgumentOutOfRangeException("Multiplier cannot be less than 1.");
            if (limit < multiplier) throw new ArgumentOutOfRangeException("Limit cannot be less than the multiplier.");

            var n = IndexInSequence(multiplier, limit);
            var nthTerm = LargestNumberInSeries(multiplier, limit);
            return nthTerm * (1 + n) / 2;
        }

        internal int IndexInSequence(int multiplier, int nthTerm)
        {
            if (multiplier < 1) throw new ArgumentOutOfRangeException("Multiplier cannot be less than 1.");
            if (nthTerm < multiplier) throw new ArgumentOutOfRangeException("Nth term cannot be less than the multiplier.");

            return nthTerm / multiplier;
        }

        internal int LargestNumberInSeries(int multiplier, int limit)
        {
            if (multiplier < 1) throw new ArgumentOutOfRangeException("Multiplier cannot be less than 1.");
            if (limit < multiplier) throw new ArgumentOutOfRangeException("Limit cannot be less than the multiplier.");

            return multiplier * IndexInSequence(multiplier, limit);
        }


    }
}
