namespace LC_1389
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = { 0, 1, 2, 3, 4, 9 , 10 };
            int[] index = { 0, 1, 2, 2, 1 };
            int[] ans = program.CreateTargetArray(nums, index);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
        }
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> list = new List<int>();
            for(int i =0; i < nums.Length; i++)
            {
                list.Insert(index[i], nums[i]);
            }
            return list.ToArray();
        }
    }
}