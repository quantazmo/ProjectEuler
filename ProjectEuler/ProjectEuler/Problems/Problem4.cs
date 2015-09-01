﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem4 : IProblem
    {
        public string Title()
        {
            return @"4. Largest palindrome product";
        }

        public string Answer()
        {
            return Title() + @"

A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.

";
        }
    }
}
