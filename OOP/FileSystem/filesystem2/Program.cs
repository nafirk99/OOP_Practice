
using System.Text;

Console.WriteLine("Running..");

string path = "test.txt";
string path2 = "test2.txt";
if (!File.Exists(path))
    File.Create(path);
//File.WriteAllText(path, "Test message on 5:11");

FileInfo file = new FileInfo(path2);
if (!file.Exists)
    file.Create();

//using Stream stream = file.Open(FileMode.Open);
//string message = "Write message 5:12\n";
//string message2 = "Time 5:20";

//byte[] bytes = Encoding.UTF8.GetBytes(message);
//stream.Write(bytes, 0, message.Length);
//stream.Write((Encoding.UTF8.GetBytes(message2)), 0, message2.Length);
//stream.Flush();

//byte[] outBytes = new byte[file.Length];
//int count = stream.Read(outBytes, 0, (int)file.Length);
//string outText = Encoding.UTF8.GetString(outBytes);
//Console.WriteLine(outText);
//Console.WriteLine($"Size: {count}");

DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
string path3 = Path.Combine(currentDirectory.Parent.Parent.Parent.FullName, "temp");
if (!Directory.Exists(path3))
    Directory.CreateDirectory(path3);

DirectoryInfo directoryInfo = new DirectoryInfo(path3);
if (!directoryInfo.Exists)
    directoryInfo.Create();

Console.WriteLine(path3);

foreach (var f in currentDirectory.Parent.GetDirectories())
{
    foreach (var d in f.GetFiles())
    {
        Console.WriteLine(d.Name);
    }
}
 