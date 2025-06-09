using FizzBuzzConsole;

namespace FizzBuzzConsoleEndTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz sut;

        public FizzBuzzTests()
        {
            sut = new FizzBuzz();
        }

        [TestMethod]
        public void DivisibleBy3ReturnsFizz()
        {
            // ARRANGE
            long num = 6;
            string expected = "Fizz";

            // ACT
            var result = sut.WriteFizzBuzz(num);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivisibleBy5ReturnsBuzz()
        {
            // ARRANGE
            long num = 25;
            string expected = "Buzz";

            // ACT
            var result = sut.WriteFizzBuzz(num);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivisibleBy3And5ReturnsFizzBuzz()
        {
            // ARRANGE
            long num = 30;
            string expected = "FizzBuzz";

            // ACT
            var result = sut.WriteFizzBuzz(num);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NotDivisibleBy3Or5ReturnsNumberAsString()
        {
            // ARRANGE
            long num = 7;
            string expected = "7";

            // ACT
            var result = sut.WriteFizzBuzz(num);

            // ASSERT
            Assert.AreEqual(expected, result);
        }
    }
}