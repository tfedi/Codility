namespace MaxProductOfThreeTest
{
    using MaxProductOfThree;
    using NUnit.Framework;

    public class MaxProductOfThreeTest
    {
        private Solution _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new Solution();
        }

        [Test]
        public void GivenAnArrayWithOneElement_ShouldReturnThatExactlyElement()
        {
            var result = _solution.solution(new[] {7});
            Assert.AreEqual(7, result);
        }

        [Test]
        public void GivenAnArrayWithTwoElements_ShouldReturnProductOfBoth()
        {
            var result = _solution.solution(new[] {7, 2});
            Assert.AreEqual(14, result);
        }

        [Test]
        public void GivenAnArrayWithThreeElements_ShouldReturnProductOfAll()
        {
            var result = _solution.solution(new[] {2, 3, 5});
            Assert.AreEqual(30, result);
        }

        [Test]
        public void GivenAnArrayWithMoreThanThreeElements_ShouldReturnProductOfThreeBigger()
        {
            var result = _solution.solution(new[] {1, 3, 5, 2});
            Assert.AreEqual(30, result);
        }

        [Test]
        public void GivenAnArrayWithEvenBiggestNegativeNumber_ShouldReturnMaxProductOfThreePositive()
        {
            var result = _solution.solution(new[] { 1, -3, 5, -2 });
            Assert.AreEqual(30, result);
        }

        [Test]
        public void GivenAnArrayWithOddBiggestNegativeNumber_ShouldReturnMaxProductOfThreePositive()
        {
            var result = _solution.solution(new[] {1, -3, 5, 2});
            Assert.AreEqual(10, result);
        }
    }
}