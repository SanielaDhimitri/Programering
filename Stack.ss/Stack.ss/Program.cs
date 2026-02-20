using Stack.ss;

class Program
{
    static void Main()
    {
        var stack = new Stack.ss.MyStack(2);

        try
        {
            stack.Push(3);
            stack.Push(4);
            stack.Push(5); // FULL -> exception
        }
        catch (MyStackIsFullException ex)
        {
            Console.WriteLine( ex.Message);
        }

        try
        {
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop()); // EMPTY -> exception
        }
        catch (MyStackIsEmptyException ex)
        {
            Console.WriteLine( ex.Message);
        }
    }
}