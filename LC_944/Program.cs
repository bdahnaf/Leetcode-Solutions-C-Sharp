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
            Console.WriteLine(slen);
            Console.WriteLine(len);
            return 0;
        }
    }
}