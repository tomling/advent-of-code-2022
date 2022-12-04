using Day2;
using FluentAssertions;
using NUnit.Framework;

namespace Day2Tests
{
    public class Day2Tests
    {

        private const string Input = "C X\r\nC X\r\nA Y\r\nC X\r\nB Y\r\nA X\r\nA Z\r\nB Y\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nB Y\r\nC Z\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nC X\r\nB X\r\nC Z\r\nC X\r\nC Z\r\nC X\r\nA Y\r\nB Y\r\nB Z\r\nA X\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nB Y\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nC X\r\nB X\r\nB X\r\nA Y\r\nC Z\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nC X\r\nA Z\r\nC X\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nC Z\r\nB Y\r\nA Y\r\nB X\r\nC X\r\nC X\r\nC Z\r\nC X\r\nA Y\r\nC X\r\nC Z\r\nA Z\r\nB Y\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nC Z\r\nC Z\r\nA Y\r\nA Z\r\nC Z\r\nC Z\r\nA Y\r\nC Z\r\nC Y\r\nB Y\r\nB Y\r\nA Z\r\nA Y\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nA Y\r\nB Z\r\nC X\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nB X\r\nA Y\r\nC Z\r\nC Z\r\nC Z\r\nB Z\r\nA Y\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nC X\r\nA Y\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nB X\r\nB Y\r\nC Z\r\nC X\r\nB X\r\nC Z\r\nC Z\r\nA Y\r\nC Z\r\nA Z\r\nA Y\r\nC Z\r\nA Y\r\nC X\r\nA Y\r\nC Y\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nA Y\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nA Y\r\nB Y\r\nA Y\r\nB X\r\nC Z\r\nC Z\r\nA Z\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nB Z\r\nC Z\r\nC Z\r\nB Z\r\nC Z\r\nA Z\r\nB Y\r\nA Y\r\nC Z\r\nB Y\r\nB X\r\nB X\r\nC X\r\nC Z\r\nA X\r\nC Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA Y\r\nA Y\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nC X\r\nB Z\r\nA Y\r\nB X\r\nC Z\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nB X\r\nB X\r\nB Y\r\nA X\r\nC X\r\nA Z\r\nA Z\r\nC Z\r\nB Y\r\nC Z\r\nA Z\r\nB X\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nA X\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nA Y\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nC Z\r\nA Y\r\nB Y\r\nA Z\r\nA Y\r\nC X\r\nC X\r\nC Z\r\nA Z\r\nC Z\r\nB Z\r\nA Z\r\nA Y\r\nC X\r\nC Z\r\nC X\r\nB Z\r\nC Z\r\nB Y\r\nA Y\r\nB X\r\nA Y\r\nC Z\r\nA Y\r\nC Z\r\nC X\r\nB Y\r\nC X\r\nA Y\r\nA Z\r\nC Z\r\nB Y\r\nC X\r\nA Y\r\nC X\r\nC Z\r\nC X\r\nB Y\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nB Y\r\nC X\r\nB X\r\nA Z\r\nC X\r\nC X\r\nA Y\r\nB X\r\nC X\r\nA Z\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nA Y\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC Z\r\nA Y\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nC Z\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nB Z\r\nB Y\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nA Z\r\nA X\r\nC X\r\nA Y\r\nB Y\r\nA Y\r\nA Z\r\nB Y\r\nB Y\r\nA Y\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nC Z\r\nA Z\r\nB X\r\nA Y\r\nB X\r\nB Y\r\nA Y\r\nA X\r\nC Z\r\nB Z\r\nB X\r\nB Z\r\nC Z\r\nC X\r\nB X\r\nB Y\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA Y\r\nB X\r\nA Y\r\nC X\r\nB Y\r\nB X\r\nB Y\r\nC X\r\nA Y\r\nC X\r\nA Y\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nA Z\r\nC Z\r\nB X\r\nC X\r\nC X\r\nC Z\r\nA Y\r\nC X\r\nC X\r\nB X\r\nC Z\r\nC Z\r\nC X\r\nB Z\r\nC X\r\nC X\r\nC Z\r\nA Y\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nB X\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nB X\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nA Z\r\nA Z\r\nC Z\r\nC X\r\nA Z\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nC Z\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nA Y\r\nC Z\r\nC Z\r\nA Y\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nB X\r\nB Z\r\nA Y\r\nA Z\r\nC X\r\nB Y\r\nB Z\r\nB Y\r\nB Z\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nB Y\r\nB X\r\nB Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nA Y\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nC Z\r\nA Z\r\nA Y\r\nB X\r\nC X\r\nC X\r\nC X\r\nC Z\r\nC X\r\nB X\r\nC Z\r\nA Y\r\nC Z\r\nA X\r\nB Y\r\nB Z\r\nC Z\r\nB Y\r\nC Z\r\nB X\r\nB Y\r\nC Z\r\nB X\r\nA Z\r\nB X\r\nB Y\r\nA Y\r\nB Z\r\nC X\r\nC Z\r\nA Z\r\nA Y\r\nA Z\r\nC X\r\nC Z\r\nB Z\r\nA Z\r\nA Z\r\nC X\r\nC Z\r\nC X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nB X\r\nA Y\r\nB Y\r\nB X\r\nB Y\r\nC Z\r\nB Y\r\nB Z\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nB Z\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nA Y\r\nC X\r\nA Y\r\nC Z\r\nA Z\r\nC Z\r\nB X\r\nC Z\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nB Z\r\nA Y\r\nB X\r\nA Y\r\nB Y\r\nA Y\r\nA Z\r\nA Z\r\nC Z\r\nB X\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nC X\r\nA Y\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nB X\r\nB Y\r\nC X\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nA Z\r\nA Y\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nC Z\r\nA Y\r\nC X\r\nA Z\r\nC Y\r\nA Z\r\nC Z\r\nC X\r\nA Y\r\nC Z\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nC X\r\nC X\r\nA X\r\nA Y\r\nC Z\r\nA Z\r\nC Z\r\nB Y\r\nC X\r\nB X\r\nC X\r\nC X\r\nA Y\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nA Z\r\nB Y\r\nA Y\r\nB Z\r\nB Z\r\nB X\r\nA Z\r\nB X\r\nB X\r\nA Z\r\nA Z\r\nC Y\r\nB Y\r\nC Z\r\nA X\r\nC Z\r\nB X\r\nC Z\r\nA Y\r\nA Y\r\nC Z\r\nC Z\r\nA Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nA Y\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nB X\r\nA Y\r\nA Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nA Y\r\nB X\r\nA Y\r\nA Z\r\nC Z\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nC X\r\nB Y\r\nA Y\r\nB X\r\nC Z\r\nC Z\r\nA Y\r\nC X\r\nC Z\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nC Z\r\nB X\r\nA Z\r\nB Y\r\nC Z\r\nA Z\r\nB X\r\nC Z\r\nB Y\r\nC Z\r\nB Y\r\nC X\r\nC Z\r\nB X\r\nC X\r\nB Y\r\nC X\r\nA Y\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nA Y\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nC X\r\nB Z\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nB X\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nA X\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nB X\r\nC Z\r\nB Z\r\nB Y\r\nB X\r\nC X\r\nC X\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nA Y\r\nC X\r\nB X\r\nA Y\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nB X\r\nB Y\r\nB Y\r\nC Z\r\nB X\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nA Y\r\nC Z\r\nA Y\r\nC Z\r\nC Z\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nC Z\r\nC Z\r\nA Y\r\nA Y\r\nC Z\r\nC Z\r\nC X\r\nA Y\r\nA Y\r\nC Z\r\nA Z\r\nC X\r\nB Z\r\nA Y\r\nC X\r\nB Z\r\nA Y\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nA X\r\nC Y\r\nA Y\r\nB Z\r\nB Y\r\nA X\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nC X\r\nC Y\r\nB Y\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nA Z\r\nB X\r\nC Z\r\nB X\r\nB X\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nA Y\r\nB X\r\nB X\r\nA Y\r\nB Y\r\nB Y\r\nB X\r\nA Z\r\nA Y\r\nC Z\r\nB Y\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nA Z\r\nC X\r\nC Z\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nB X\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nA Y\r\nC Z\r\nC X\r\nA Y\r\nA X\r\nC Z\r\nB Y\r\nB X\r\nC X\r\nC X\r\nC X\r\nC Z\r\nA Z\r\nB Y\r\nA Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nC X\r\nA Z\r\nA X\r\nB Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nC Z\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nA Y\r\nC Z\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nC Z\r\nA Z\r\nC X\r\nA Z\r\nA Y\r\nB Y\r\nC Z\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nA X\r\nC Z\r\nC X\r\nA Y\r\nB Y\r\nB X\r\nC Z\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nA Z\r\nA Y\r\nC X\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC Z\r\nB X\r\nB X\r\nC X\r\nB X\r\nB Y\r\nC X\r\nC X\r\nA Y\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC Z\r\nA Z\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nA Y\r\nC X\r\nC X\r\nB Y\r\nC X\r\nC Z\r\nB X\r\nA Y\r\nC Z\r\nC X\r\nB Y\r\nB X\r\nA Y\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nA Y\r\nB Y\r\nC Z\r\nB Z\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nA Y\r\nC X\r\nC Z\r\nC X\r\nC X\r\nB X\r\nC X\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nB X\r\nB X\r\nC Z\r\nA Y\r\nC Z\r\nC Y\r\nB X\r\nA Z\r\nC X\r\nA Z\r\nB Z\r\nA Y\r\nC Z\r\nC Z\r\nA Z\r\nB Z\r\nA Z\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nA Y\r\nC Z\r\nC X\r\nA Y\r\nB Y\r\nB X\r\nA Z\r\nA Y\r\nC X\r\nB X\r\nA Y\r\nC Z\r\nB Y\r\nC X\r\nC X\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nC X\r\nB X\r\nB X\r\nA Y\r\nC Z\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nC Z\r\nC X\r\nA Y\r\nB Y\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nA Z\r\nA Y\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Y\r\nB Y\r\nB Z\r\nA Z\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nB X\r\nC X\r\nC X\r\nB X\r\nC Z\r\nC X\r\nB Y\r\nB X\r\nC Z\r\nA Z\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nB X\r\nA Y\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nC X\r\nA Z\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nA Z\r\nC Y\r\nB Z\r\nB Y\r\nA Z\r\nC Z\r\nA X\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nA Y\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nC Z\r\nB Y\r\nA Y\r\nC X\r\nB Y\r\nA Y\r\nC X\r\nA Z\r\nA Y\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nA Y\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nB X\r\nB X\r\nB X\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nB Y\r\nA X\r\nC X\r\nA Y\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nA Y\r\nA Z\r\nC X\r\nB Z\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nA Y\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nC Z\r\nC X\r\nB Y\r\nA Y\r\nC X\r\nC Z\r\nA Z\r\nB Y\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nA Z\r\nA Y\r\nA Y\r\nB Y\r\nB Y\r\nA Z\r\nB X\r\nA Y\r\nC X\r\nC X\r\nA Y\r\nC X\r\nA Y\r\nB Y\r\nC Z\r\nA X\r\nB X\r\nA Y\r\nA Z\r\nC Z\r\nB X\r\nC Z\r\nB Y\r\nC X\r\nB Y\r\nC Z\r\nA Z\r\nA Y\r\nC X\r\nC Z\r\nB X\r\nB Y\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nB Z\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nB Z\r\nC X\r\nA Y\r\nC Z\r\nB Y\r\nC X\r\nA Y\r\nC Z\r\nB X\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nA Y\r\nA Y\r\nA Y\r\nC Z\r\nC Z\r\nA Y\r\nA X\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nA Y\r\nB Z\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nB X\r\nB Y\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nB X\r\nC Z\r\nB Y\r\nA Z\r\nC X\r\nB Y\r\nC X\r\nB X\r\nA Z\r\nC X\r\nB Y\r\nA Y\r\nC Z\r\nC X\r\nA Y\r\nC X\r\nB Y\r\nB X\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nC X\r\nC X\r\nA Y\r\nA X\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nC Z\r\nA Z\r\nB X\r\nC Z\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nB Y\r\nB Y\r\nC Z\r\nC Z\r\nA Y\r\nA Z\r\nA Z\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nA Z\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nC Z\r\nA Y\r\nB X\r\nC X\r\nC X\r\nA X\r\nA Y\r\nB X\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nB Z\r\nC Z\r\nC Z\r\nB X\r\nA Y\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nC X\r\nB X\r\nB X\r\nC Z\r\nA X\r\nB Z\r\nA Z\r\nB Y\r\nC X\r\nC Z\r\nB Z\r\nC X\r\nB X\r\nC Z\r\nA Z\r\nB X\r\nC Z\r\nC Z\r\nA Z\r\nA Y\r\nC Z\r\nC Z\r\nB X\r\nA Z\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nA Y\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nB X\r\nB Y\r\nA Z\r\nC Z\r\nB Y\r\nB X\r\nC Z\r\nB X\r\nC Y\r\nC X\r\nB Y\r\nC Z\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC Z\r\nB X\r\nC Z\r\nA Y\r\nC Z\r\nB X\r\nA Z\r\nA Y\r\nB Y\r\nC Z\r\nA Y\r\nB Y\r\nC X\r\nA Z\r\nA Y\r\nC Z\r\nC Z\r\nA Y\r\nB X\r\nC X\r\nB Y\r\nA Y\r\nC X\r\nB X\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nA Y\r\nA Z\r\nB X\r\nA Y\r\nC X\r\nB Y\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nA Z\r\nC X\r\nA Y\r\nC Z\r\nA X\r\nA Z\r\nC Z\r\nB Y\r\nC X\r\nC Y\r\nA Y\r\nB X\r\nB Y\r\nC Z\r\nC Z\r\nB X\r\nB X\r\nC Y\r\nB Y\r\nB X\r\nC X\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nA Z\r\nB X\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nB X\r\nA Z\r\nC Z\r\nB X\r\nC Z\r\nB Z\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nA Y\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nC X\r\nC Z\r\nC Z\r\nA Y\r\nC Z\r\nC Z\r\nC Z\r\nA Y\r\nB X\r\nC Z\r\nC X\r\nB X\r\nC X\r\nC X\r\nB Y\r\nC Z\r\nB X\r\nC X\r\nB Y\r\nA Y\r\nC Z\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nB Z\r\nB Y\r\nB Y\r\nA Y\r\nB Y\r\nB Y\r\nA X\r\nA Y\r\nC Z\r\nC X\r\nB X\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nC Z\r\nC Z\r\nB Y\r\nA Y\r\nB Y\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nA Y\r\nA Y\r\nC Z\r\nA Y\r\nC X\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nB Y\r\nA X\r\nA X\r\nB X\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nC X\r\nB Y\r\nB Z\r\nA Z\r\nA Y\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nB X\r\nB X\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nB X\r\nC Z\r\nC X\r\nC X\r\nC Y\r\nC Z\r\nB Y\r\nC X\r\nC X\r\nA Y\r\nC X\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nC Z\r\nA X\r\nC Z\r\nC Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nA X\r\nC Z\r\nB X\r\nC Z\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nB Y\r\nB Y\r\nA Z\r\nA Y\r\nC X\r\nA Z\r\nC Z\r\nC Z\r\nA Y\r\nA Z\r\nA X\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nA Y\r\nA Z\r\nA Z\r\nA Y\r\nA Y\r\nC X\r\nA Y\r\nA Y\r\nC Z\r\nC Z\r\nC Z\r\nB X\r\nC X\r\nC Z\r\nB X\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nA Z\r\nC Z\r\nB X\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nC X\r\nA Y\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nB Y\r\nB X\r\nC X\r\nB X\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nA Y\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nA Y\r\nA Y\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nA Z\r\nC X\r\nA X\r\nC X\r\nA Z\r\nC X\r\nC Z\r\nC X\r\nA Y\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nC Z\r\nA Y\r\nC Z\r\nB Y\r\nA Z\r\nA X\r\nC Z\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nB X\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nA X\r\nC X\r\nA Z\r\nC X\r\nA Y\r\nB Y\r\nC Z\r\nB Y\r\nB X\r\nC Z\r\nA X\r\nB Z\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nA Y\r\nC Z\r\nA Z\r\nC X\r\nC Z\r\nB Y\r\nC X\r\nA Y\r\nB X\r\nA Y\r\nB X\r\nB Y\r\nC Z\r\nA Y\r\nB Y\r\nA Y\r\nB Y\r\nC Z\r\nC X\r\nC X\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nB X\r\nC X\r\nA Y\r\nA X\r\nB Y\r\nA Z\r\nC Z\r\nA Y\r\nA Z\r\nC X\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nC Y\r\nC X\r\nA Z\r\nA Y\r\nC X\r\nA Y\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC Z\r\nC X\r\nB X\r\nB Y\r\nA Z\r\nA Z\r\nB X\r\nB Y\r\nC X\r\nB Y\r\nC Z\r\nB Y\r\nC Y\r\nB Y\r\nB X\r\nB Y\r\nA Y\r\nB Y\r\nC Z\r\nB X\r\nB Y\r\nC Z\r\nA Z\r\nC Z\r\nB X\r\nA Y\r\nB X\r\nC Z\r\nB Y\r\nA Y\r\nC Z\r\nC Z\r\nC Y\r\nC Z\r\nA Y\r\nC X\r\nA Y\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC Z\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nC X\r\nC Z\r\nB X\r\nC X\r\nC Z\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nA Z\r\nB X\r\nB Y\r\nC Z\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nC Z\r\nC Z\r\nA Y\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nC X\r\nB X\r\nC X\r\nC Z\r\nA Y\r\nA Y\r\nA Y\r\nC Z\r\nC Z\r\nB X\r\nC X\r\nA Z\r\nC Z\r\nC X\r\nC Z\r\nB X\r\nC Z\r\nB Z\r\nC X\r\nA Y\r\nC Z\r\nA Y\r\nC X\r\nB Y\r\nB Y\r\nA Z\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nC X\r\nA Y\r\nC Z\r\nA Y\r\nC Z\r\nA Z\r\nA Z\r\nB Y\r\nC Z\r\nA Z\r\nC X\r\nA Y\r\nC Z\r\nC Z\r\nC X\r\nC X\r\nC X\r\nA X\r\nB Z\r\nC Z\r\nC X\r\nA Y\r\nA Z\r\nC Z\r\nB X\r\nB Y\r\nC X\r\nC Z\r\nB X\r\nB Y\r\nC X\r\nB X\r\nC Z\r\nC X\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nA Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nA X\r\nC Z\r\nB X\r\nC Z\r\nC Z\r\nA Z\r\nB Y\r\nC Z\r\nC Z\r\nA Y\r\nA Z\r\nA Z\r\nA Z\r\nB X\r\nC X\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nA Y\r\nC X\r\nC Z\r\nC Z\r\nC X\r\nC Y\r\nA Y\r\nA Z\r\nC X\r\nC X\r\nA Z\r\nB X\r\nC Z\r\nA X\r\nC Z\r\nC X\r\nC Z\r\nA X\r\nA Z\r\nC X\r\nB Y\r\nC Z\r\nC Z\r\nB X\r\nA Y\r\nB Y\r\nC Z\r\nC Z\r\nA Z\r\nA Y\r\nC Z\r\nC Z\r\nA X\r\nB Y\r\nC Z\r\nC Z\r\nB Y\r\nC X\r\nC Z\r\nB X\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nB Z\r\nB Y\r\nC Z\r\nC X\r\nA Y\r\nC X\r\nA Y\r\nA Z\r\nB Y\r\nB X\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nC Z\r\nA Y\r\nB Y\r\nA Z\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nA Y\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nC X\r\nB Y\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nB Z\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nC Z\r\nB Y\r\nB X\r\nC Z\r\nC Z\r\nB Y\r\nA Y\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nB X\r\nC X\r\nA Y\r\nB X\r\nA Y\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nC X\r\nC X\r\nB X\r\nB Z\r\nC Z\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nC Z\r\nA Z\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nC Y\r\nA Z\r\nC Z\r\nC Z\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nA Z\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nC X\r\nA Y\r\nA Z\r\nA Z\r\nA Y\r\nB X\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nA Y\r\nA Z\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nC X\r\nC X\r\nA Y\r\nB Z\r\nA Z\r\nA Z\r\nB X\r\nC X\r\nA Y\r\nC X\r\nC Z\r\nC X\r\nA Y\r\nA Z\r\nC Z\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nA Z\r\nB X\r\nB X\r\nB Y\r\nC Z\r\nC Z\r\nC X\r\nC X\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nB X\r\nC Z\r\nC X\r\nB X\r\nA Y\r\nB Y\r\nC Z\r\nA Z\r\nA Y\r\nC Z\r\nA Y\r\nA Y\r\nC Z\r\nB Y\r\nC Z\r\nB Z\r\nC Z\r\nA Z\r\nC X\r\nC X\r\nC Z\r\nB X\r\nC X\r\nB Y\r\nC Z\r\nB X\r\nC Z\r\nC X\r\nB X\r\nB Y\r\nB Z\r\nB X\r\nA Y\r\nC X\r\nC Z\r\nC Z\r\nA Y\r\nB X\r\nA Y\r\nC X\r\nC Z\r\nB Y\r\nC Z\r\nC Z\r\nC Z\r\nA Z\r\nA Z\r\nA Y\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nC Z\r\nA X\r\nC X\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nA Z\r\nA Y\r\nC Z\r\nC Z\r\nB X\r\nC Z\r\nA Z\r\nA Y\r\nC X\r\nA Y\r\nC Z\r\nC X\r\nC X\r\nC X\r\nB Y\r\nC X\r\nA Y\r\nC X\r\nB Y\r\nB X\r\nA Y\r\nB X\r\nA Y\r\nB Z\r\nC Z\r\nA Z\r\nB Y\r\nB X\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nA Z\r\nA Z\r\nA Y\r\nA Y\r\nC Z\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nC Z\r\nC Z\r\nC Z\r\nA Y\r\nA Z";
        
        [Test]
        public void Part1()
        {
            var part1ScoreCalculator = new Part1ScoreCalculator();
            RockPaperScissors.CalculateScore(Input, part1ScoreCalculator).Should().Be(13809);
        }

        [Test]
        public void Part2()
        {
            var part1ScoreCalculator = new Part2ScoreCalculator();
            RockPaperScissors.CalculateScore(Input, part1ScoreCalculator).Should().Be(12316);
        }
    }
}