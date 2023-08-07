namespace LC_2798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] hours = { 0, 1, 2, 3, 4 };
            int target = 2;
            int ans = program.NumberOfEmployeesWhoMetTarget(hours, target);
            Console.WriteLine(ans);
        }
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int ans = 0;
            for(int i = 0; i < hours.Length; i++)
            {
                if (hours[i] >= target)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}