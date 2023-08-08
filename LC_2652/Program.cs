namespace LC_2652
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.SumOfMultiples(9));
        }
        public int SumOfMultiples(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 || i % 5 == 0 || i % 7 ==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}