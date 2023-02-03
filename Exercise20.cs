using System;

public class Exercise20
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Insert an integer number: ");
        num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine(num + " * " + i + " = " + num*i);
        }
        Console.WriteLine("Press any key.");
        Console.ReadLine();
    }
}
