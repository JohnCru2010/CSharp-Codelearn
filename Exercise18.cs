using System;

public class Exercise18
{
    public static void Main(string[] args)
    {
        String name;
        Console.Write("Insert your name: ");
        name = Console.ReadLine();
        if (name == "Codelearn") {
            Console.WriteLine("Hi Codelearn! It is nice to see you again!");
        } else {
            Console.WriteLine("I do not even know you.");
        }
        Console.WriteLine("Press any key.");
        Console.ReadLine();
    }
}