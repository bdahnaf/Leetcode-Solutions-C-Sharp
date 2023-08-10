namespace LC_1323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.Maximum69Number(9669));
        }
        public int Maximum69Number(int num)
        {
            int rem = 0;
            List<int> list = new List<int>();
            while(num > 0)
            {
                rem = num % 10;
                num = num / 10;
                list.Add(rem);
            }
            list.Reverse();
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == 6)
                {
                    list[i] = 9;
                    break;
                }
            }
            int total = 0;
            foreach(int i in list)
            {
                total = 10 * total + i;
            }
            return total;
        }
    }
}