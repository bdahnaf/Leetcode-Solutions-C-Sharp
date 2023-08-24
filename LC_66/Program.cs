namespace LC_66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 8, 9 };
            Program program = new Program();
            int[] ans = program.PlusOne(digits);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
        }
        public int[] PlusOne(int[] digits)
        {
            List<int> result = new List<int>();
            int carry = 0;
            if(digits.Length == 1)
            {
                if (digits[0] == 9)
                {
                    result.Add(1);
                    result.Add(0);
                    return result.ToArray();
                }
                else
                {
                    result.Add(digits[0] + 1);
                    return result.ToArray();
                }
            }
            else
            {
                for(int i = digits.Length - 1; i <= 0; i--)
                {
                    Console.WriteLine(digits[i]);
                }
                //foreach (int digit in digits)
                //{
                //    if (digit == 9)
                //    {
                //        result.Add(0);
                //        carry = 1;
                //    }
                //    else
                //    {
                //        if(carry == 1)
                //        {
                //            result.Add(digit+1);
                //        }
                //        else
                //        {
                //            result.Add(digit);
                //        }
                //    }
                //}
                if(carry == 1)
                {
                    result.Add(1);
                }
            }
            return result.ToArray();
        }
    }
}