using List;
using System.Collections.Generic;
using System.Globalization;



List<int> primeNumbers = new List<int>();
primeNumbers.Add(1);
primeNumbers.Add(3);
primeNumbers.Add(5);
primeNumbers.Add(7);

List<string> cities = new List<string>();
cities.Add("New York");
cities.Add("Dhaka");
cities.Add("Mumbai");
cities.Add("Manhattan");
cities.Add(null);

List<string> country = new List<string>()
{
    "Brumburg",
    "Ionia",
    "PiltOver",
    "Shadow Isles"
};

List<Student> students = new List<Student>()
{
    new Student(){ Id = 1, Name = "Alam"},
    new Student(){ Id = 2, Name = "Paul" },
    new Student(){ Id = 3, Name = "Rick"}
};

students.Insert(0, new Student() { Id = 4, Name = "Felix" });
students.Remove(students[1]);
//students.Clear();
Console.WriteLine("Students:");
foreach (Student student in students)
{
    Console.WriteLine($"{student.Id} {student.Name}");
}

//Console.WriteLine("Country:");
//string[] c2 = { "Abudhabi", "Liverpool", "Gotham"  };
//country.AddRange(c2);
//foreach(var ctry in country)
//{
//    Console.WriteLine(ctry);
//}

List<int> ints = new List<int>() { 99, 88, 77, 66, 55, 44, 33, 22, 11, 00 };
//Console.WriteLine(ints[0]);
//Console.WriteLine(ints[1]);
//Console.WriteLine(ints[2]);
//Console.WriteLine(ints[3]);
//Console.WriteLine(ints[4]);
//Console.WriteLine(ints[5]);
//Console.WriteLine(ints[6]);
//Console.WriteLine(ints[7]);
//Console.WriteLine(ints[8]);
//for(int i = 0; i < ints.Count; i++)
//{
//    Console.WriteLine(ints[i]);
//}
ints.Insert(0, 1);
//foreach (var a in ints)
//{
//    Console.WriteLine(a);
//}
