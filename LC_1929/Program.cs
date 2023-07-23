namespace LC_1929
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 2, 1};
            Program program = new Program();
            int[] ans = program.GetConcatenation(nums);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
        }
        public int[] GetConcatenation(int[] nums)
        {
            int len = nums.Length;
            int[] ans = new int[len * 2];
            for (int i = 0; i < len; i++)
            {
                ans[i] = nums[i];
                ans[i + len] = nums[i];
            }
            return ans;
        }
    }
}