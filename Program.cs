using System;

class Program
{
    static void Main()
    {
        string correctUsername = "admin";
        string correctPassword = "12345";
        int attemptsRemaining = 3;

        while (attemptsRemaining > 0)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful.");
                return;
            }
            else if (username == correctUsername)
            {
                Console.WriteLine("Invalid password.");
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }

            attemptsRemaining--;
        }

        Console.WriteLine("Login failed.");
    }
}