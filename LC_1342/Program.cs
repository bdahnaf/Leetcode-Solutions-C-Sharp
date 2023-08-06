namespace LC_1342
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int ans = program.NumberOfSteps(14);
            Console.WriteLine(ans);
        }
        public int NumberOfSteps(int num)
        {
            int rem = 0;
            int counter = 0;
            while (num != 0)
            {
                if(num % 2 == 0)
                {
                    rem = num % 2;
                    num = num / 2;
                } 
                else
                {
                    num = num - 1;
                }
                counter++;
            }
            return counter;
        }
    }
}