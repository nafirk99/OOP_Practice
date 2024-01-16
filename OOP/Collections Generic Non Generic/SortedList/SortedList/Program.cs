

SortedList<int, string> numberNames = new SortedList<int, string>();
numberNames.Add(0, "Zero");
numberNames.Add(1, "One");
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");
numberNames.Add(4, "Four");
numberNames.Add(5, null);

foreach (var name in numberNames)
{
    Console.WriteLine(name);
}

SortedList<string, string> cities = new SortedList<string, string>()
{
    { "London", "UK" },
    { "New York", "USA" },
    { "Dhaka", "Bangladesh" },
    { "Tokio", "Japan" }
};
foreach (var item in cities)
{
    Console.WriteLine(item);
}

SortedList<int, string> sList = new SortedList<int, string>()
{
    { 55, "Ionia" },
    { 99, "Piltover" },
    { 32, "Zawn" },
    { 12, "Shadow Isles" },
    { 13, "Mount Targon" },
    { 14, "Shurima" },
    { 10, "Bandle City" },
    { 22, "Freliord" },
    { 23, "Demacia" },
    { 24, "Noxus"  }
};
foreach (KeyValuePair<int, string> item in sList)
{
    Console.WriteLine(item);
}

SortedList<int, string> a1 = new SortedList<int, string>()
{
    { 5, "Ionia-" },
    { 9, "Piltover-" },
    { 3, "Zawn-" },
    { 1, "Shadow Isles-" },
    { 13, "Mount Targon-" },
    { 14, "Shurima-" },
    { 10, "Bandle City-" },
    { 2, "Freliord-" },
    { 23, "Demacia-" },
    { 4, "Noxus-"  }
};

Console.WriteLine(a1[5]);

