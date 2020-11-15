using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzzSample.Services;
using Xunit;

namespace FizzBuzzSampleXUnitTest.Services {
    public class FizzBuzzServiceTest {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        public void ReturnsValidString(int n, string word) {
            var fizzBuzzService = new FizzBuzzService();
            Assert.Equal(word, fizzBuzzService.GetWord(n));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void LessThen1_ThrowException(int n) {
            var fizzBuzzService = new FizzBuzzService();
            var ex = Assert.Throws<ArgumentException>(() => {
                fizzBuzzService.GetWord(n);
            });
            Assert.Contains("は1以上としてください", ex.Message);
        }
    }
}
