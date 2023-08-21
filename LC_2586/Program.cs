namespace LC_2586
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hey", "aeo", "mu", "ooo", "artro" };
            int left = 1;
            int right = 4;
            Program program = new Program();
            Console.WriteLine(program.VowelStrings(words, left, right));
        }
        public int VowelStrings(string[] words, int left, int right)
        {
            int ans = 0;
            for (int i = left; i <= right; i++)
            {
                char firstChar = words[i][0];
                char lastChar = words[i][words[i].Length - 1];
                if(firstChar == 'a' || firstChar == 'e' || firstChar == 'i' || firstChar == 'o' || firstChar == 'u')
                {
                    if(lastChar == 'a' || lastChar == 'e' || lastChar == 'i' || lastChar == 'o' || lastChar == 'u')
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}