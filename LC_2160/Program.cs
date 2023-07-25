namespace LC_2160
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.MinimumSum(1000));
        }
        public int MinimumSum(int num)
        {
            int smallest = 0;
            int secondSmallest = 0;
            int digits_sum = 0;
            while (num != 0)
            {
                int digits = num % 10;
                if(digits < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digits;
                }
                else if (digits < secondSmallest)
                {
                    secondSmallest = digits;
                }
                digits_sum += digits;
                num /= 10;
            }
            return digits_sum;
        }
    }
}