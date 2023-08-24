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
            int carry = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                digits[i] = sum % 10; // Update current digit
                carry = sum / 10; // Update carry
            }

            // If there's still a carry after processing all digits
            if (carry > 0)
            {
                int[] result = new int[digits.Length + 1];
                result[0] = carry;
                Array.Copy(digits, 0, result, 1, digits.Length);
                return result;
            }
            else
            {
                return digits;
            }
        }
    }
}