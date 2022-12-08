namespace Day1
{
    public static class CalorieCounting
    {
        public static int CalculatePart1(string input)
        {

            return input.ToCalorieList().Max();

        }

        public static int CalculatePart2(string input)
        {

            return input.ToCalorieList().OrderDescending().Take(3).Sum();

        }

        private static IEnumerable<int> ToCalorieList(this string input)
        {
            return input.Split("\r\n\r\n").Select(s => s.Split("\r\n")).Select(numberSplit => numberSplit.Sum(Convert.ToInt32)).ToList();
        }
    }
}