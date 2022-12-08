namespace Day3
{
    public static class RucksackReorganization
    {
        private const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static int CalculatePriority(string input)
        {
            var splitInputNewline = input.Split("\r\n");

            return (from s in splitInputNewline let half = s.Length / 2 let firstHalf = s[..half] let secondHalf = s.Substring(half, s.Length - half) select firstHalf.FirstOrDefault(letter => secondHalf.Contains(letter)) into common select char.IsLower(common) ? LowerCase.IndexOf(common) + 1 : UpperCase.IndexOf(common) + 27).Sum();
        }

        public static int CalculateGroupPriority(string input)
        {
            var splitInputNewline = input.Split("\r\n");
            var groups = Enumerable.Range(0, splitInputNewline.Length / 3)
                .Select(i => splitInputNewline.Skip(i * 3).Take(3));

            return (from @group in groups select @group.ToList() into groupList let c1 = groupList[0].ToCharArray() let c2 = groupList[1].ToCharArray() let c3 = groupList[2].ToCharArray() select c1.Intersect(c2).Intersect(c3).First() into common select char.IsLower(common) ? LowerCase.IndexOf(common) + 1 : UpperCase.IndexOf(common) + 27).Sum();
        }
    }
}