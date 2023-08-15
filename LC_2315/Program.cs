namespace LC_2315
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CountAsterisks("l|*e*et|c**o|*de|");
        }
        public int CountAsterisks(string s)
        {
            int ans = 0;
            int firstP = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '|' && firstP == 1)
                {
                    continue;
                }
                else if (s[i] == '|')
                {
                    firstP = 1;
                }
                else if (firstP == 1 && s[i] == '*')
                {
                    continue;
                }
                else if (s[i] == '*')
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
            return ans;
        }
    }
}