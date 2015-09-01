using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace UnitTests
{
    [TestClass]
    public class Problem1Tests
    {
        [TestMethod]
        public void SumOfTwoMultiples_Answer()
        {
            var problem = new Problem1();

            var result = problem.SumOfTwoMultiples(3, 5, 999);

            Assert.AreEqual(233168, result);

        }

        [TestMethod]
        public void SumOfMultiples_Test1()
        {
            var problem = new Problem1();

            var result = problem.SumOfMultiples(3, 3);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SumOfMultiples_Test2()
        {
            var problem = new Problem1();

            var result = problem.SumOfMultiples(3, 6);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void SumOfMultiples_Test3()
        {
            var problem = new Problem1();

            var result = problem.SumOfMultiples(3, 10);

            Assert.AreEqual(18, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumOfMultiples_InvalidMultiplier1()
        {
            var problem = new Problem1();

            var result = problem.SumOfMultiples(0, 10);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumOfMultiples_InvalidMultiplier2()
        {
            var problem = new Problem1();

            var result = problem.SumOfMultiples(-10, 10);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumOfMultiples_InvalidLimit1()
        {
            var problem = new Problem1();

            var result = problem.SumOfMultiples(10, 1);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumOfMultiples_InvalidLimit2()
        {
            var problem = new Problem1();

            var result = problem.SumOfMultiples(1, 0);

            Assert.Fail();
        }


        [TestMethod]
        public void IndexInSequence_1stTerm()
        {
            var problem = new Problem1();

            var result = problem.IndexInSequence(4, 4);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IndexInSequence_2ndTerm()
        {
            var problem = new Problem1();

            var result = problem.IndexInSequence(4, 8);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void IndexInSequence_After3rdTermBefore4th()
        {
            var problem = new Problem1();

            var result = problem.IndexInSequence(4, 13);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexInSequence_InvalidMultiplier1()
        {
            var problem = new Problem1();

            var result = problem.IndexInSequence(0, 3);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexInSequence_InvalidMultiplier2()
        {
            var problem = new Problem1();

            var result = problem.IndexInSequence(-10, 3);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexInSequence_InvalidNthTerm1()
        {
            var problem = new Problem1();

            var result = problem.IndexInSequence(10, 3);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexInSequence_InvalidNthTerm2()
        {
            var problem = new Problem1();

            var result = problem.IndexInSequence(1, -2);

            Assert.Fail();
        }

        [TestMethod]
        public void LargestNumberInSeries_1stTerm()
        {
            var problem = new Problem1();

            var result = problem.LargestNumberInSeries(5, 5);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void LargestNumberInSeries_2ndTerm()
        {
            var problem = new Problem1();

            var result = problem.LargestNumberInSeries(5, 10);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void LargestNumberInSeries_After3rdTermBefore4th()
        {
            var problem = new Problem1();

            var result = problem.LargestNumberInSeries(5, 16);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LargestNumberInSeries_InvalidMultiplier1()
        {
            var problem = new Problem1();

            var result = problem.LargestNumberInSeries(0, 3);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LargestNumberInSeries_InvalidMultiplier2()
        {
            var problem = new Problem1();

            var result = problem.LargestNumberInSeries(-9, 3);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LargestNumberInSeries_InvalidLimit1()
        {
            var problem = new Problem1();

            var result = problem.LargestNumberInSeries(10, 3);

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LargestNumberInSeries_InvalidLimit2()
        {
            var problem = new Problem1();

            var result = problem.IndexInSequence(1, -2);

            Assert.Fail();
        }
    }
}
