// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IDictionary<int, string> numbernames = new Dictionary<int, string>();
numbernames.Add(1, "One");
numbernames.Add(2, "Two");
numbernames.Add(3, "Three");
numbernames.Add(4, "Four");
foreach (KeyValuePair<int, string> name in numbernames)
{
    Console.WriteLine($"Key: {name.Key} | Value: {name.Value}");
}

IDictionary<string, string> champLocation = new Dictionary<string, string>();
champLocation.Add("Yi", "Ionia");
champLocation.Add("Darius", "Noxus");
champLocation.Add("Teemo", "Bandle City");
champLocation.Add("Garen", "Demacia");
champLocation.Add("Kalista", "Shadow Isles");
champLocation.Add("Twich", "Zawn");
champLocation.Add("Zed", "Ionia");
champLocation.Add("Yasuo", "Ionia");
champLocation.Add("Riven", "Noxus");
champLocation.Add("Pantheon", "Mount Targon");

foreach(var i in champLocation)
{
    Console.WriteLine($"Key: {i.Key} \t Value: {i.Value}");
}

IDictionary<string, string> cities = new Dictionary<string, string>()
{
    {"USA", "Washington, New York, Dalas" },
    {"BD", "Dhaka, Rajsahi, Citagong" },
    {"IND", "Bombat, Mumbai, Delhi" }
};
foreach(var c in cities)
{
    Console.WriteLine("key: {0, -15} Value: {1}", c.Key, c.Value);
}
Console.WriteLine(cities["USA"]);
Console.WriteLine("------------------------------");
Dictionary<int, string> pairs = new Dictionary<int, string>()
{
    { 1, "List" },
    { 2, "Array List" },
    { 3, "Hash Table" },
    { 4, "Dictionary" },
    { 5, "Stack" },
    { 6, "Queue" },
    { 7, "Sorted List" }
};
pairs.Remove(6);
if (pairs.ContainsKey(7))
{
    pairs.Remove(7);
}
foreach(var pair in pairs)
{
    Console.WriteLine(pair);
}