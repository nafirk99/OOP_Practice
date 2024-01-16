using System.Text;
//File.Create("hello.txt"); // Creats the file beside .exe
//File.Create("D:\\Codes\\FileSystem\\FileSystem\\bin/hello.txt");



string path = "../../../test/hello.txt";

//if (!File.Exists(path))
//    //File.Create(path);
//    File.WriteAllText(path, "hello world...");

FileInfo file = new FileInfo(path);

//if (!file.Exists)
//   file.Create();

using Stream stream = file.Open(FileMode.Open);
String message = "Test Message";
string message2 = "This is another test";
byte[] bytes = Encoding.UTF8.GetBytes(message);
byte[] b2 = Encoding.UTF8.GetBytes(message2);
stream.Write(bytes, 0, message.Length);
stream.Write(b2, 0, message2.Length);
stream.Flush();



