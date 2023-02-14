using NUnit.Framework;

namespace Sumator.UnuitTests
{
    public class SumatorTests
    {
        

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


    }
}