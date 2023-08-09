namespace LC_2810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.FinalString("string"));
        }
        public string FinalString(string s)
        {
            string ans = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'i')
                {
                    ans = ans + s[i];
                }
                else
                {
                    ans = Reverse(ans);
                }
            }
            return ans;
        }
        public string Reverse(string s)
        {
            string revString = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revString += s[i];
            }
            return revString;
        }
    }
}