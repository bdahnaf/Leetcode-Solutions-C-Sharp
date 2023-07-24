namespace LC_1672
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts = new int[3][];
            accounts[0] = new int[2];
            accounts[1] = new int[2];
            accounts[2] = new int[2];
            accounts[0][0] = 1;
            accounts[0][1] = 5;
            accounts[1][0] = 7;
            accounts[1][1] = 3;
            accounts[2][0] = 3;
            accounts[2][1] = 5;
            Program program = new Program();
            int ans = program.MaximumWealth(accounts);
            Console.WriteLine(ans);
        }
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            int temp = 0;
            for(int i = 0; i < accounts.Length; i++)
            {
                for(int j = 0; j < accounts[i].Length; j++)
                {
                    temp = temp + accounts[i][j];
                }
                if(temp >= max)
                {
                    max = temp;
                }
                temp = 0;
            }
            return max;
        }
    }
}