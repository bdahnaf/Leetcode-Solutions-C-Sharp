namespace LC_2413
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SmallestEvenMultiple(2);
        }
        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0) return n;
            else return 2 * n;
        }
    }
}