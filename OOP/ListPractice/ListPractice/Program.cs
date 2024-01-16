using ListPractice;
using System.Xml.Serialization;

class Program
{
    static owner o1 = new owner();

    static void Main()
    {
        Console.WriteLine("Hello, World!");
        o1.Username = "h";
        o1.Password = "123";

        Console.WriteLine("Options:");
        Console.WriteLine("1. Log In");
        Console.WriteLine("2. Change Pass");
        Console.WriteLine("3. Exit");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    LogIn();
                    break;
                case 2:
                    ChangePass();
                    break;
                case 3:
                    Console.WriteLine("Exiting. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void LogIn()
    {
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
    }

    static void ChangePass()
    {
        Console.Write("Enter Pass: ");
        string userPass = Console.ReadLine();

        if (userPass == "123")
        {
            Console.WriteLine("Enter New Pass: ");
            string newPass = Console.ReadLine();
            o1.Password = newPass;
            Console.WriteLine("Password changed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid current password. Unable to change the password.");
        }
    }
}
