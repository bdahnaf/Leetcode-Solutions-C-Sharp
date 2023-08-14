namespace LC_1732
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] gain = { -4, -3, -2, -1, 4, 3, 2 };
            Console.WriteLine(program.LargestAltitude(gain));
        }
        public int LargestAltitude(int[] gain)
        {
            int ans = 0;
            int max = 0;
            for(int i = 0; i < gain.Length; i++)
            {
                ans = ans + gain[i];
                if(ans >= max)
                {
                    max = ans;
                }
            }
            return max;

        }
    }
}