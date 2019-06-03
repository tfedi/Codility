namespace TriangleTest
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Triangle;

    public class TriangleTest
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

        [Test]
        public void WhenArrayHasOneItem_ShouldReturnZero()
        {
            Assert.AreEqual(0, _triangleSolution.solution(new[]{1}));
        }

        [Test]
        public void WhenArrayHasTwoItems_ShouldReturnZero()
        {
            Assert.AreEqual(0, _triangleSolution.solution(new[] { 1, 2 }));
        }

        [Test]
        public void WhenArrayHasThreeItemsInTriangleOrder_ShouldReturnOne()
        {
            Assert.AreEqual(1, _triangleSolution.solution(new[] { 10, 5, 8 }));
        }

        [Test]
        public void WhenArrayHasFourItemsAndExistsTriangle_ShouldReturnOne()
        {
            Assert.AreEqual(1, _triangleSolution.solution(new[] { 10, 2, 5, 8 }));
        }


        [Test]
        public void WhenArrayHasThreeItemsWithoutTriangleOrder_ShouldReturnOne()
        {
            Assert.AreEqual(0, _triangleSolution.solution(new[] { 10, 2, 8 }));
        }

        [Test]
        public void WhenArrayHasFourItemsAndNotExistsTriangle_ShouldReturnOne()
        {
            Assert.AreEqual(0, _triangleSolution.solution(new[] { 10, 2, 2, 8 }));
        }
    }
}