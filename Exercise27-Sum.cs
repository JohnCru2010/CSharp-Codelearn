using System;

class Program {
    static void Main(string[] args) {
      int sum = 0;
      int num;
      Console.Write("Insert a number: ");
      num = int.Parse(Console.ReadLine());
      sum = num;
      while (num > 0) {
        Console.Write("Insert another number: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0) {
          sum += num;
        }
      }
      Console.WriteLine("The total sum of the given numbers is " + sum);
      Console.WriteLine("Press any key.");
      Console.ReadLine();
    }
}