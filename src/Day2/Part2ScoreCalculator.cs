namespace Day2;

public  class Part2ScoreCalculator : IScoreStratergy
{
    public int CalculateScore(string opponentChoice, string gameResult)
    {
        var score = gameResult switch
        {
            "X" when opponentChoice == "A" => 3,
            "X" when opponentChoice == "B" => 1,
            "X" when opponentChoice == "C" => 2,
            "Y" when opponentChoice == "A" => 4,
            "Y" when opponentChoice == "B" => 5,
            "Y" when opponentChoice == "C" => 6,
            "Z" when opponentChoice == "A" => 8,
            "Z" when opponentChoice == "B" => 9,
            "Z" when opponentChoice == "C" => 7,
            _ => 0
        };

        return score;
    }
}