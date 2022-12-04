namespace Day1
{
    public static class CalorieCounting
    {
        public static int CalculatePart1(string input)
        {

            return ToList(input).Max();

        }

        public static int CalculatePart2(string input)
        {

            return ToList(input).OrderDescending().Take(3).Sum();

        }

        private static List<int> ToList(string input)
        {
            return input.Split("\r\n\r\n").Select(s => s.Split("\r\n")).Select(numberSplit => numberSplit.Sum(Convert.ToInt32)).ToList();
        }
    }
}