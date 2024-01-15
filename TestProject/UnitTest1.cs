using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        [InlineData(18, "Fizz")]
        public void Print_Fizz_WhenDivideBy_3_Only(int input, string expected)
        {
            //Act
            var res = Program.Print(input);
            //Assert
            Assert.Equal(res, expected);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        [InlineData(25, "Buzz")]
        public void Print_Buzz_WhenDivideBy_5_Only(int input, string expected)
        {
            //Act
            var res = Program.Print(input);
            //Assert
            Assert.Equal(res, expected);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(60, "FizzBuzz")]
        [InlineData(90, "FizzBuzz")]
        public void Print_FizzBuzz_WhenDivideBy_5_AND_3(int input, string expected)
        {
            //Act
            var res = Program.Print(input);
            //Assert
            Assert.Equal(res, expected);
        }
    }
}