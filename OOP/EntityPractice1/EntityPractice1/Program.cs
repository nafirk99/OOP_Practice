using System;
using System.Collections.Generic;

class owner
{
    public string Username { get; set; }
    public string Password { get; set; }
}

class Program
{
    static void Main()
    {
        List<owner> owners = new List<owner>
        {
            new owner{ Username = "h", Password = "123" }
        };

        Console.WriteLine("Welcome to the Owner Portal!");

        owner loggedInUser = Login(owners);

        if (loggedInUser != null)
        {
            Console.WriteLine($"Login successful! Welcome, {loggedInUser.Username}.");

            bool isLoggedIn = true;

            while (isLoggedIn)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Change Password");
                Console.WriteLine("2. Logout");
                Console.WriteLine("3. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ChangePassword(loggedInUser);
                            break;
                        case 2:
                            Console.WriteLine("Logout successful. Goodbye!");
                            isLoggedIn = false;
                            break;
                        case 3:
                            Console.WriteLine("Exiting. Goodbye!");
                            isLoggedIn = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
        else
        {
            Console.WriteLine("Login failed. Exiting. Goodbye!");
        }

        Console.ReadLine(); // Wait for user input before closing the console
    }

    private static owner Login(List<owner> owners)
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        owner user = owners.Find(o => o.Username == username && o.Password == password);
        return user;
    }

    private static void ChangePassword(owner user)
    {
        Console.Write("Enter current password: ");
        string currentPassword = Console.ReadLine();

        if (currentPassword == user.Password)
        {
            Console.Write("Enter new password: ");
            string newPassword = Console.ReadLine();

            // Update the password in the list
            user.Password = newPassword;

            Console.WriteLine("Password changed successfully!");
        }
        else
        {
            Console.WriteLine("Incorrect current password. Password change failed.");
        }
    }
}
