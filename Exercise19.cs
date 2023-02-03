using System;

public class HelloWorld
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
using System;

public class Exercise19
{
    public static void Main(string[] args)
    {
        int num;
        String weekday = "";
        Console.Write("Insert an integer number from 1 to 7: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (num) {
            case 1:
              weekday="Monday";
              break;
            case 2:
              weekday="Tuesday";
              break;
            case 3:
              weekday="Wednesday";
              break;
            case 4:
              weekday="Thursday";
              break;
            case 5:
              weekday="Friday";
              break;
            case 6:
              weekday="Saturday";
              break;
            case 7:
              weekday="Sunday";
              break;
            default:
              weekday="Wrong";
              break;
        }
        if (weekday == "Wrong") {
            Console.WriteLine("Wrong value");
        } else {
            Console.WriteLine("The corresponding day of the week is " + weekday);
        }
        Console.WriteLine("Press any key.");
        Console.ReadLine();
    }
}