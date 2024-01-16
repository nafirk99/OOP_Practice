string Username = "h";
string Password = "123";


Console.Write("Enter Username: ");
string userName = Console.ReadLine();

Console.Write("Enter Pass: ");
string userPass = Console.ReadLine();

if (userName == "h" && userPass == "123")
{
    Console.WriteLine("Success");
}
else
{
    Console.WriteLine("Login Failed");
}

Console.Write("Change Pass");
Console.Write("Enter Old Pass: ");
string checkPass = Console.ReadLine();

if (checkPass == Password)
{
    Console.WriteLine("Enter New Pass: ");
    string newPass = Console.ReadLine();
    Password = newPass;
    Console.WriteLine("Password changed successfully.");
}


