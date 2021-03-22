using NUnit.Framework;
using Methods2;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TripleCalc_Ruturn_Int_Out()
        {
            Assert.AreEqual(250, Program.TripleCalc(5, 10, 5, out int sumTest));
            Assert.AreEqual(20, sumTest);
        }

        [Test]
        public void TripleCalc_Ruturn_Tuple()
        {
            Assert.AreEqual((20, 250), Program.TripleCalc(5, 10, 5));
        }

        [Test]
        public void Add_Return_20()
        {
            Assert.AreEqual(20, Calculator.Add(10, 10));
        }

        [TestCase(3,4,7)]
        [TestCase(12, 7, 19)]
        [TestCase(20, 3, 23)]

        public void WhenGiven_Two_Numbers_Add_ReturnsValue(int v1, int v2, int expected)
        {
            Assert.AreEqual(expected, Calculator.Add(v1, v2));
        }

        [TestCase(5, 2, 3)]
        [TestCase(20, 10, 10)]
        [TestCase(6, 16, -10)]
        public void WhenGiven_Two_Numbers_Subtract_ReturnsValue(int v1, int v2, int expected)
        {
            Assert.AreEqual(expected, Calculator.Sub(v1, v2));
        }

        [TestCase(2, 10, 5)]
        [TestCase(30, 90, 3)]
        [TestCase(7, 90, 12)] //Should be 7.5 but integer produes whole numbers
        public void WhenGiven_Two_Numbers_Divide_ReturnsValue(int v1, int v2, int expected)
        {
            Assert.AreEqual(expected, Calculator.Div(v1, v2));
        }

    }
}