using NUnit.Framework;

namespace Sumator.UnuitTests
{
    public class SumatorTests
    {
        /*private object NaN;*/

        [Test]
        public void Test_Sumator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };

            var actual = Sumator.Sum(nums);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };

            var actual = Sumator.Sum(nums);
            var expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_OneNumber()
        {
            var nums = new int[] { 5 };

            var actual = Sumator.Sum(nums);
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_ZeroNumber()
        {
            var nums = new int[] {};

            var actual = Sumator.Sum(nums);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_BigNumbers()
        {
            var nums = new int[] {2000000000, 2000000000, 2000000000 };

            var actual = Sumator.Sum(nums);
            var expected = 6000000000;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_AveragePositiveNumbers()
        {
            var nums = new double[] { 5, 6, 7 };

            var actual = Sumator.Average(nums);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_AverageNegativeNumbers()
        {
            var nums = new double[] { -5, -6, -7 };

            var actual = Sumator.Average(nums);

            var expected = -6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_AverageBothPositivePlusNegativeNumbers()
        {
            var nums = new double[] { 5, -6, -7, 10 };

            var actual = Sumator.Average(nums);

            var expected = 0.5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_AverageEmptyArr()
        {
            var nums = new double[] {};

            var actual = Sumator.Average(nums);


            Assert.AreEqual(double.NaN, actual);
        }

        [Test]
        public void Test_Sumator_AverageArrContainingZero()
        {
            var nums = new double[] { 0, 5, 7 };

            var actual = Sumator.Average(nums);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }


    }
}