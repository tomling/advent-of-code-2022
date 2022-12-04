namespace Day2
{
    public static class RockPaperScissors
    {
        public static int CalculateScore(string input, IScoreStratergy scoreStratergy)
        {
            var score = 0;
            var splitInputNewline = input.Split("\r\n");
            foreach (var line in splitInputNewline)
            {
                var splitMoves = line.Split(" ");
                score += scoreStratergy.CalculateScore(splitMoves[0], splitMoves[1]);
                
            }

            return score;

        }
    }
}