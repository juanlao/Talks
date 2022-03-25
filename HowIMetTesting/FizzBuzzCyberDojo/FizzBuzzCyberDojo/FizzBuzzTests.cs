using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzzCyberDojo
{
    public class fizz_buzz_should
    {
        [Theory]
        [InlineData(1,"1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void get_back_a_representing_string_when_fizzbuzz_a_number(int number, string expected)
        {       
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.Execute(number);

            output.Should().Be(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(101)]
        [InlineData(102)]
        public void ensure_that_number_is_between_1_and_100_inclusive(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.Execute(number);

            output.Should().Be("error");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(27)]
        [InlineData(33)]
        public void get_back_fizz_when_a_number_is_multiple_of_3(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.Execute(number);

            output.Should().Be("FIZZ");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(20)]
        [InlineData(50)]
        public void get_back_buzz_when_a_number_is_multiple_of_5(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.Execute(number);
            output.Should().Be("BUZZ");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void get_back_fizzbuzz_when_a_number_is_multiple_of_3_and_5(int number)
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.Execute(number);
            output.Should().Be("FIZZBUZZ");
        }
    }

    public class FizzBuzz
    {
           
        public string Execute(int input)
        {
            //if (input <= 0 || input > 100) return "error";

            //if (input % 15 == 0) return "FIZZBUZZ";

            //if (input % 3 == 0) return "FIZZ";

            //if (input % 5 == 0) return "BUZZ";

            return input.ToString();
        }
    }
}
