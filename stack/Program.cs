namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // Push elemen ke stack

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Pop elemen dari stack

            Console.WriteLine($"Pop: {stack.Pop()}");

            // Lihat elemen teratas tanpa menghapus

            Console.WriteLine($"Top: {stack.Peek()}");

            Console.WriteLine();

            Console.WriteLine(IsValid("(}"));
        }
        static bool IsValid(string s)
        {
            // Dictionary untuk mencocokkan tanda kurung
            Dictionary<char, char> matchingBrackets = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '['},
                {'}', '{'}
            };

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (matchingBrackets.ContainsKey(c))
                {
                    char topElement = stack.Count > 0 ? stack.Pop() : '#';
                    if (matchingBrackets[c] != topElement)
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }
    }
}