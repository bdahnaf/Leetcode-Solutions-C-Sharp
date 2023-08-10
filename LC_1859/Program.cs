namespace LC_1859
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string words = program.SortSentence("is2 sentence4 This1 a3");
            Console.WriteLine(words);
        }
        public string SortSentence(string s)
        {
            string word = "";
            string[] words = new string[10];
            int max = 0;
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = "s" + i;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' ||
                    s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9')
                {
                    string st = s[i].ToString();
                    int index = int.Parse(st);
                    if(index >= max)
                    {
                        max = index;
                    }
                    words[index] = word;
                    word = "";
                }
                else if (s[i] == ' ')
                {
                    continue;
                }
                else
                {
                    word += s[i];
                }
            }
            string ans = "";
            for(int i = 1; i <= max; i++)
            {
                ans += words[i] + " ";
            }
            ans = ans.Remove(ans.Length - 1);
            return ans;
        }
    }
}