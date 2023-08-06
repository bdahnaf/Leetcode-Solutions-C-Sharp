namespace LC_412
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            IList<string> list = program.FizzBuzz(2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public IList<string> FizzBuzz(int n)
        {
            IList<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                    continue;
                }
                if(i % 3 == 0)
                {
                    list.Add("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    list.Add("Buzz");
                    continue;
                }
                list.Add(i.ToString());
            }
            return list;
        }
    }
}