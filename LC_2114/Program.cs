namespace LC_2114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string[] sentences = { "please wait", "continue to fight", "continue to win" };
            int ans = program.MostWordsFound(sentences);
            Console.WriteLine(ans);
        }
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;
            foreach (string sentence in sentences)
            {
                int length = sentence.Length;
                int ans = 0;
                for(int i = 0; i < length; i++)
                {
                    bool isWhite = Char.IsWhiteSpace(sentence[i]);
                    if(isWhite)
                    {
                        ans++;
                    }
                }
                if(ans+1 >= max)
                {
                    max = ans+1;
                }
                ans = 0;
            }
            return max;
        }
    }
}