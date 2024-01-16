// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections;

Dictionary<int, string> numbers = new Dictionary<int, string>();
numbers.Add(1, "Ooo");
numbers.Add(2, "Ttt");
numbers.Add(3, "Trr");

foreach (var i in numbers)
{
    Console.WriteLine($"{i.Key}  {i.Value}");
}
Hashtable hashtable = new Hashtable()
{
    {"USA", "New York, Texas, Washington" },
    {"BD", "Dhaka, Chitagong, Rajsahi" },
    {"IND", "Mumbai, Delhi, Rajsthan" }
};

foreach (DictionaryEntry i in hashtable)
{
    Console.WriteLine($"{i.Key} {i.Value}");
}
Hashtable table  = new Hashtable(numbers);
foreach (DictionaryEntry i in table)
{
    Console.WriteLine(i);
}