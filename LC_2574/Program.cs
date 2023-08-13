namespace LC_2574
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //int[] nums = { 10, 4, 8, 3 };
            int[] nums = { 1 };
            program.LeftRightDifference(nums);
        }
        public int[] LeftRightDifference(int[] nums)
        {
            int len = nums.Length;
            int[] leftSum = new int[len];
            int[] rightSum = new int[len];
            int[] ans = new int[nums.Length];
            leftSum[0] = 0;
            for(int i = 1; i < len; i++)
            {
                leftSum[i] = leftSum[i-1] + nums[i-1];
            }
            rightSum[len - 1] = 0;
            for(int i = len - 2; i >= 0; i--)
            {
                rightSum[i] = rightSum[i + 1] + nums[i + 1];
            }
            for(int i = 0; i < len; i++)
            {
                ans[i] = Math.Abs(leftSum[i] - rightSum[i]);
            }
            return ans;
        }
    }
}