using Day2;
using FluentAssertions;
using NUnit.Framework;

namespace Day2Tests
{
    public class Day2Tests
    {

        private const string Input = "A Y";
        //A for Rock, B for Paper, and C for Scissors.
        //X for Rock, Y for Paper, and Z for Scissors

        [Test]
        public void Part1()
        {
            RockPaperScissors.CalculatePart1(Input).Should().Be(8);
        }
    }
}