namespace LC_2469
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 36.50;
            Program program = new Program();
            double[] ans = program.ConvertTemperature(celsius);
            foreach(double val in ans)
            {
                Console.WriteLine(val);
            }
        }
        public double[] ConvertTemperature(double celsius)
        {
            double[] ans = new double[2];
            ans[0] = celsius + 273.15;
            ans[1] = celsius * 1.80 + 32.00;
            return ans;
        }
    }
}