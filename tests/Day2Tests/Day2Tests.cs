using Day2;
using FluentAssertions;
using NUnit.Framework;

namespace Day2Tests
{
    public class Day2Tests
    {
        [Test]
        public void Part1()
        {
            RockPaperScissors.CalculatePart1("").Should().Be(0);
        }
    }
}