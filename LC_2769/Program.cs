namespace LC_2769
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.TheMaximumAchievableX(4, 1));
        }
        public int TheMaximumAchievableX(int num, int t)
        {
            int ans = num + t + t;
            return ans;
        }
    }
}