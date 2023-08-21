namespace LC_2586
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "are", "amy", "u" };
            int left = 0;
            int right = 2;
            Program program = new Program();
            Console.WriteLine(program.VowelStrings(words, left, right));
        }
        public int VowelStrings(string[] words, int left, int right)
        {
            for(int i = left; i <= right; i++)
            {
                Console.WriteLine(words[i][0]);
            }
            return 0;
        }
    }
}