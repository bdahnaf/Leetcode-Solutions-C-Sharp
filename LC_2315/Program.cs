namespace LC_2315
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CountAsterisks("yo|uar|e**|b|e***au|tifu|l");
        }
        public int CountAsterisks(string s)
        {
            int ans = 0;
            int firstP = 0;
            int sAns = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '|' && firstP == 1)
                {
                    firstP = 0;
                    ans = ans - sAns;
                    sAns = 0;
                }
                else if (s[i] == '|' && firstP == 0)
                {
                    firstP = 1;
                }
                //else if (s[i] == '*')
                //{
                //    ans++;
                //    if (firstP == 1)
                //    {
                //        sAns++;
                //    }
                //}
            }
            return ans;
        }
    }
}