using NUnit.Framework;
using Selection83;

namespace NUnitTest83
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase(40)]
        [TestCase(100)]
        public void GivenMarkMoreThan40(int mark)
        {
            Assert.AreEqual("Pass", Program.PassFail(mark));
        }

        [TestCase(39)]
        [TestCase(0)]
        public void GivenMark40LessThan40(int mark)
        {
            Assert.AreEqual("Fail", Program.PassFail(mark));
        }

        [TestCase(74)]
        [TestCase(69)]
        [TestCase(66)]
        [TestCase(72)]
        public void GivenMarkBetween60To74(int mark)
        {
            Assert.AreEqual("Pass with Merit", Program.PassFail(mark));
        }

        [TestCase(75)]
        [TestCase(100)]
        [TestCase(84)]
        [TestCase(95)]
        public void GivenMarkBetween75To100(int mark)
        {
            Assert.AreEqual("Pass with Distinction", Program.PassFail(mark));
        }

        [TestCase(3, "Code Red")]
        [TestCase(1, "Code Amber")]
        [TestCase(2, "Code Amber")]
        [TestCase(0, "Code Green")]
        public void GivenLevelReturnPriority(int level, string code)
        {
            Assert.AreEqual(code, Program.Priority(level));
        }*/

        [TestCase(-1, "George")]
        [TestCase(4, "George")]
        public void WhenAnIllegalPositionIsSpecifiedAnExceptionIsThrown(int pos, string person)
        {
            var ex = Assert.Throws<AssertionException>(() => Program.SeatDiner(pos, person));
            Assert.AreEqual($"The dining table does not have a position {pos}", ex.Message,
                "Exception message not correct");
        }
    }
}