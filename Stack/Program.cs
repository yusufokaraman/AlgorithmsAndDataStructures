namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.PrintAll();
            stack.PrintTop();
            stack.PrintCount();
        }
    }
}
