namespace Day2
{
    public static class RockPaperScissors
    {
        public static int CalculateScore(string input, IScoreStratergy scoreStratergy)
        {
            var splitInputNewline = input.Split("\r\n");

            return splitInputNewline.Select(line => line.Split(" ")).Select(splitMoves => scoreStratergy.CalculateScore(splitMoves[0], splitMoves[1])).Sum();

        }
    }
}