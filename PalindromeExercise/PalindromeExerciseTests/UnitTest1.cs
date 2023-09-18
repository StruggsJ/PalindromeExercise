using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]

        [InlineData("Radar", true)] // ← you will need to put some test data and expected result here.  For example [InlineData(“racecar”, true)]
        [InlineData("Plate", false)]
        [InlineData("Noon", true)]
        [InlineData("Card", false)]
        [InlineData("Dad", true)]

        
        public void IsAPalindromeTest (string input, bool expected)
        {

            //Arrange

            var instance = new WordSmith();

            //Act

            var actual = instance.IsAPalindrome(input);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
