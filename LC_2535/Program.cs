namespace LC_2535
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(program.DifferenceOfSum(nums));
        }
        public int DifferenceOfSum(int[] nums)
        {
            int eSum = 0;
            int dSum = 0;
            for(int i = 0; i < nums.Length; i++) 
            {
                eSum += nums[i];
                while (nums[i] > 0)
                {
                    int digit = nums[i] % 10;
                    dSum += digit;
                    nums[i] = nums[i] / 10;
                }
            }
            if(eSum >= dSum)
            {
                return eSum - dSum;
            }
            else
            {
                return dSum - eSum;
            }
        }
    }
}