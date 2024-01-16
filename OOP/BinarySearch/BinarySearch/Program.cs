// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] ints = { 1, 2, 78, 4, 474, 464, 39 };
Array.Sort(ints);
foreach (int i in ints)
{
    Console.Write(i + ", ");
}

var a = BinarySearchIterative( ints, 39);
Console.WriteLine("\n" + a);
static object BinarySearchIterative(int[] inputArray, int key)
{
    int min = 0;
    int max = inputArray.Length - 1;
    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (key == inputArray[mid])
        {
            return ++mid;
        }
        else if (key < inputArray[mid])
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return "Nil";
}