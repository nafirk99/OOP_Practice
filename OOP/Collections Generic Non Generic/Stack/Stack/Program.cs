// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Stack<string> stack = new Stack<string>();
stack.Push("A");
stack.Push("B");
stack.Push("C");
stack.Push("D");
stack.Pop();
foreach (var item in stack)
{
    Console.WriteLine(item);
}
Console.WriteLine(default(string));
Console.WriteLine(default(int));
Console.WriteLine(default(long));
Console.WriteLine(default(float));
Console.WriteLine(default(double));
Console.WriteLine(default(decimal));
Console.WriteLine(default(string));