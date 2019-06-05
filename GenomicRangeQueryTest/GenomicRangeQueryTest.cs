namespace GenomicRangeQueryTest
{
    using GenomicRangeQuery;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GenomicRangeQueryTest
    {
        [TestMethod]
        public void WhenGivenADNAString_ExecutingSolution_ShouldReturnCorrectValues()
        {
            string dnaSequence = "GACACCTA";
            int[] P = {0, 0, 4, 7};
            int[] Q = {7, 2, 5, 7};
            
            SolutionGenomicRangeQuery solution = new SolutionGenomicRangeQuery();
            var result = solution.solution(dnaSequence, P, Q);

            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(1, result[3]);
        }
    }
}
