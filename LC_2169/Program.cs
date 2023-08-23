namespace LC_2169
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.CountOperations(2, 3));
        }
        public int CountOperations(int num1, int num2)
        {
            int ans = 0;
            while(true)
            {
                if(num1 == 0 || num2 == 0)
                {
                    break;
                }
                if (num1 >= num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
                ans++;
            }
            return ans;
        }
    }
}