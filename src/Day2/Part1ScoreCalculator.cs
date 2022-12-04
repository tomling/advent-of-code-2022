namespace Day2;

public  class Part1ScoreCalculator : IScoreStratergy
{
    public int CalculateScore(string opponentChoice, string playerChoice)
    {
        var score = 0;

        switch (playerChoice)
        {
            case "X":
                score += 1;
                break;
            case "Y":
                score += 2;
                break;
            case "Z":
                score += 3;
                break;
        }
        switch (opponentChoice)
            // ReSharper disable once BadChildStatementIndent
        {
            case "A" when playerChoice == "X":
            case "B" when playerChoice == "Y":
            case "C" when playerChoice == "Z":
                score += 3;
                break;
            case "A" when playerChoice == "Y":
            case "B" when playerChoice == "Z":
            case "C" when playerChoice == "X":
                score += 6;
                break;
        }

        return score;
    }
}