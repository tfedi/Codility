namespace TriangleTest
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Triangle;

    public class Tests
    {
        private TriangleSolution _triangleSolution;

        [SetUp]
        public void Setup()
        {
            _triangleSolution = new TriangleSolution();
        }

        [Test]
        public void WhenArrayIsEmpty_ShouldReturnZero()
        {
            IList<int> arrayList = new List<int>();
            Assert.AreEqual(0, _triangleSolution.solution(arrayList.ToArray()));
        }
    }
}