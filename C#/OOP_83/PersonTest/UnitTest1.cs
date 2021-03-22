using NUnit.Framework;
using OOP_83;

namespace ClassesTests
{
    public class PersonsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TestCase("Cathy","French", "Cathy French")]

        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);
        }
    }
}