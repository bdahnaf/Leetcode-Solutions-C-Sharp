namespace LC_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            bool isValid = program.IsValid("()()()((");
            Console.WriteLine(isValid);
        }
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count > 0 && c == ')' && stack.Peek() == '(')
                    stack.Pop();
                else if (stack.Count > 0 && c == '}' && stack.Peek() == '{')
                    stack.Pop();
                else if (stack.Count > 0 && c == ']' && stack.Peek() == '[')
                    stack.Pop();
                else
                    stack.Push(c);
            }
            if(stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}