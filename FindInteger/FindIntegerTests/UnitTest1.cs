using FindInteger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindIntegerTests
{
    [TestClass]
    public class UnitTest1
    {
        public AfterMeeting IntSearcher = new AfterMeeting();

        //*************** NULL RESULTS ********************
        [TestMethod]
        public void SameValues_Combination1_ShouldReturnNull()
        {
            var testList = new[] {0, 0, 0};
            var sth = IntSearcher.Run(testList);
            Assert.IsNull(sth);
        }

        [TestMethod]
        public void SameValues_Combination2_ShouldReturnNull()
        {
            var testList = new[] { 1, 1, 1 };
            var sth = IntSearcher.Run(testList);
            Assert.IsNull(sth);
        }

        [TestMethod]
        public void SameValues_Combination3_ShouldReturnNull()
        {
            var testList = new[] { 5, 5, 5 };
            var sth = IntSearcher.Run(testList);
            Assert.IsNull(sth);
        }

        [TestMethod]
        public void SameValues_Combination4_ShouldReturnNull()
        {
            var testList = new[] { -7, -7, -7 };
            var sth = IntSearcher.Run(testList);
            Assert.IsNull(sth);
        }

        [TestMethod]
        public void SameTwoValues_Combination1_ShouldReturnNull()
        {
            var testList = new[] { 4, 4, 5 };
            var sth = IntSearcher.Run(testList);
            Assert.IsNull(sth);
        }

        [TestMethod]
        public void SameTwoValues_Combination2_ShouldReturnNull()
        {
            var testList = new[] { 7, 8, 8 };
            var sth = IntSearcher.Run(testList);
            Assert.IsNull(sth);
        }

        [TestMethod]
        public void ThreeInRowValues_Combination1_ShouldReturnNull()
        {
            var testList = new[] { 7, 8, 9 };
            var sth = IntSearcher.Run(testList);
            Assert.IsNull(sth);
        }

        [TestMethod]
        public void ThreeInRowValues_Combination2_ShouldReturnNull()
        {
            var testList = new[] { -1, -2, -3 };
            var sth = IntSearcher.Run(testList);
            Assert.IsNull(sth);
        }

        //*************** VALUE RESULTS ********************

        [TestMethod]
        public void NoNegative_Combination1_ShouldReturnNull()
        {
            var testList = new[] { 7, 8, 10 };
            var sth = IntSearcher.Run(testList);
            Assert.IsTrue(sth.Equals(9));
        }

        [TestMethod]
        public void NoNegative_Combination2_ShouldReturnNull()
        {
            var testList = new[] { 1, 3, 5 };
            var sth = IntSearcher.Run(testList);
            Assert.IsTrue(sth.Equals(2));
        }

        [TestMethod]
        public void NoNegative_Combination3_ShouldReturnNull()
        {
            var testList = new[] {2, 5, 11, 17, 21};
            var sth = IntSearcher.Run(testList);
            Assert.IsTrue(sth.Equals(3));
        }

        [TestMethod]
        public void WithNegative_Combination1_ShouldReturnNull()
        {
            var testList = new[] {-7, -3, -1, 0, 1, 2, 3, 4, 7};
            var sth = IntSearcher.Run(testList);
            Assert.IsTrue(sth.Equals(5));
        }

        [TestMethod]
        public void WithNegative_Combination2_ShouldReturnNull()
        {
            var testList = new[] {-7, -3, -1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 7};
            var sth = IntSearcher.Run(testList);
            Assert.IsTrue(sth.Equals(5));
        }

        [TestMethod]
        public void WithNegative_Combination3_ShouldReturnNull()
        {
            var testList = new[] {5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 11};
            var sth = IntSearcher.Run(testList);
            Assert.IsTrue(sth.Equals(6));
        }

        [TestMethod]
        public void WithNegative_Combination4_ShouldReturnNull()
        {
            var testList = new[] { -7, 8, 9 };
            var sth = IntSearcher.Run(testList);
            Assert.IsTrue(sth.Equals(1));
        }
    }
}
