using System;
using Xunit;
using LetsFizzBuzz.Domain;

namespace LetsFizzBuzz.UnitTests
{
    public class FizzBuzzUnitTest
    {
        [Fact]
        public void FizzBuzzTest()
        {
            [Fact]
            void Array_Returns_1_When_Number_Is_1()
            {
                //Arrange && Act
                int input = 1;
                string output = FizzBuzzDomain.GetValue(input);

                //Assert
                Assert.Equal("1", output);
            }

            [Fact]
            void Array_Returns_2_When_Number_Is_2()
            {
                //Arrange && Act
                int input = 2;
                string output = FizzBuzzDomain.GetValue(input);

                //Assert
                Assert.Equal("2", output);
            }

            [Fact]
            void Array_Returns_Fizz_If_Number_is_3()
            {
                //Arrange && Act
                int input = 3;
                string output = FizzBuzzDomain.GetValue(input);

                //Assert
                Assert.Equal("Fizz", output);
            }

            [Fact]
            void Array_Returns_Buzz_if_Number_is_5()
            {
                //Arrange && Act
                int input = 5;
                string output = FizzBuzzDomain.GetValue(input);

                //Assert
                Assert.Equal("Buzz", output);
            }

            [Theory]
            [InlineData(6)]
            [InlineData(9)]
            [InlineData(12)]
            // 15 are divisible for 3 and 5
            void Array_Returns_Fizz_When_Numbers_Are_Divisible_By_3(int input)
            {
                //Arrange && Act
                string output = FizzBuzzDomain.GetValue(input);

                //Assert
                Assert.Equal("Fizz", output);
            }

            [Theory]
            [InlineData(10)]
            [InlineData(20)]
            // 15 are divisible for 3 and 5
            void Array_Returns_Buzz_When_Numbers_Are_Divisible_by_5(int input)
            {
                //Arrange && Act
                string output = FizzBuzzDomain.GetValue(input);

                //Assert
                Assert.Equal("Buzz", output);
            }

            [Theory]

            [InlineData(30)]
            [InlineData(45)]
            void Array_Returns_FizzBuzz_When_Numbers_Are_Divisible_By_3_And_5(int input)
            {
                //Arrange && Act
                string output = FizzBuzzDomain.GetValue(input);

                //Assert
                Assert.Equal("FizzBuzz", output);
            }

            [Theory]
            [InlineData(4, "4")]
            [InlineData(7, "7")]

            void Array_Returns_Input_Numbers_When_The_Are_Not_Divisible_By_3_or_5(int input, string expectedresult)
            {
                //Arrange && Act
                string output = FizzBuzzDomain.GetValue(input);

                //Assert
                Assert.Equal(expectedresult, output);
            }
        }
    }
}
