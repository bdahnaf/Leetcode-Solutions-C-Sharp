namespace LC_944
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string[] strs = { "cba", "daf", "ghi" };
            Console.WriteLine(program.MinDeletionSize(strs));
        }
        public int MinDeletionSize(string[] strs)
        {
            int len = strs.Length;
            int slen = strs[0].Length;
            for(int i = 0; i < len; i++)
            {
                for(int j = 0; j < slen; j++)
                {

                }
            }
            Console.WriteLine(slen);
            Console.WriteLine(len);
            return 0;
        }
    }
}