namespace Day2
{
    public static class RockPaperScissors
    {
        public static int CalculatePart1(string input)
        {
            var splitInput = input.Split(" ");

            return CalculateScore(splitInput[0], splitInput[1]);
        }
        //Opponent Choices
        //A for Rock, B for Paper, and C for Scissors.
        //Player Choices
        //X for Rock, Y for Paper, and Z for Scissors
        private static int CalculateScore(string opponentChoice, string playerChoice)
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
            //Draw
            if (opponentChoice == playerChoice)
            {
                score += 3;
            }
            else switch (opponentChoice)
                // ReSharper disable once BadChildStatementIndent
                {
                    case "A" when playerChoice == "Y":
                    case "B" when playerChoice == "Z":
                    case "C" when playerChoice == "X":
                        score += 6;
                        break;
                }

            return score;
        }

    }
}