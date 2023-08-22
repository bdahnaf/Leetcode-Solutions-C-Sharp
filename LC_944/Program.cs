namespace LC_944
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string[] strs = { "zyx","wvu","tsr" };
            Console.WriteLine(program.MinDeletionSize(strs));
        }
        public int MinDeletionSize(string[] strs)
        {
            int rowCount = strs.Length;
            int colCount = strs[0].Length;
            int deleteCount = 0;

            for (int col = 0; col < colCount; col++)
            {
                for (int row = 1; row < rowCount; row++)
                {
                    if (strs[row][col] < strs[row - 1][col])
                    {
                        deleteCount++;
                        break;
                    }
                }
            }

            return deleteCount;
        }
    }
}