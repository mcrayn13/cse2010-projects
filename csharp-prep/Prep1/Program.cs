using System;

class Program
{
    static void Main(string[] args)
    {
        // ask for name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        String last = Console.ReadLine();
        
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}