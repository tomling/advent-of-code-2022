namespace Day1
{
    public static class ElfCalories
    {
        public static int CalculateTask1(string input)
        {

            return ToList(input).Max();

        }

        public static int CalculateTask2(string input)
        {

            return ToList(input).OrderDescending().Take(3).Sum();

        }

        private static List<int> ToList(string input)
        {
            return input.Split("\r\n\r\n").Select(s => s.Split("\r\n")).Select(numberSplit => numberSplit.Sum(Convert.ToInt32)).ToList();
        }
    }
}