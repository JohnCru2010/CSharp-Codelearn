using System;
class Exercise21 {
  static void Main() {
        int num;
        int result = 0;
        int result2 = 1;
        Console.Write("Insert an integer number: ");
        num = int.Parse(Console.ReadLine());
        for (int i = 0; i <= num; i = i + 2) {
            result = result + i;
        }
        
        for (int i = 1; i <= num; i = i + 2) {
            result2 = result2 * i;
        }
        
        Console.WriteLine("The sum of even numbers from 1 to " + num + " is " + result);
        Console.WriteLine("The product of odd numbers from 1 to " + num + " is " + result2);
        Console.WriteLine("Press any key.");
        Console.ReadLine();
  }
}