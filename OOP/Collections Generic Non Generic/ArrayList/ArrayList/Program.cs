using System.Collections;

// Array List Is a non generic Collection

ArrayList arrayList = new ArrayList();
var arList = new ArrayList();

arrayList.Add(1);
arrayList.Add(2);
arrayList.Add("Name");
arrayList.Add(1.2);
arrayList.Add(5);

var a1 = new ArrayList()
{
    1,21, 2, 3, 4,"Steve"
};

arrayList.AddRange(a1);

//foreach (var a2 in arrayList)
//{
//    Console.WriteLine(a2);
//}
int[] ints = { 4, 4, 4, 4, 4 };
a1.AddRange(arrayList);
a1.AddRange(ints);

a1.Insert(9, "Insert At 8");

for(int i=0; i< a1.Count; i++)
{
    Console.Write(a1[i] + ",");
}
