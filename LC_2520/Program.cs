namespace LC_2520
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.CountDigits(150));
        }
        public int CountDigits(int num)
        {
            int originalNum = num;
            int rem = 0;
            int ans = 0;
            while(num > 0)
            {
                rem = num % 10;
                num /= 10;
                if(originalNum % rem == 0)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}