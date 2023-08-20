namespace LC_2363
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[][] items1 = new int[3][];
            items1[0] = new int[2];
            items1[1] = new int[2];
            items1[2] = new int[2];
            items1[0][0] = 1;
            items1[0][1] = 1;
            items1[1][0] = 4;
            items1[1][1] = 5;
            items1[2][0] = 3;
            items1[2][1] = 8;

            int[][] items2 = new int[2][];
            items2[0] = new int[2];
            items2[1] = new int[2];
            items2[0][0] = 3;
            items2[0][1] = 1;
            items2[1][0] = 1;
            items2[1][1] = 5;

            program.MergeSimilarItems(items1, items2);
        }
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            IList<IList<int>> ret = new List<IList<int>>();
            // Logic
            return ret;
        }
    }
}