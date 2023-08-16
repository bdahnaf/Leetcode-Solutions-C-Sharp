namespace LC_2006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = { 1, 3 };
            int k = 3;
            Console.WriteLine(program.CountKDifference(nums, k));
        }
        public int CountKDifference(int[] nums, int k)
        {
            int ans = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (i + 1 < nums.Length)
                {
                    for(int j = i + 1; j < nums.Length; j++)
                    {
                        int diff = Math.Abs(nums[i] - nums[j]);
                        if(diff == k)
                        {
                            ans++;
                        }
                    }
                }
            }
            return ans;
        }
    }
}