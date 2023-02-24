using System;

class Program {
    static void Main(string[] args) {
      float result = 0.0f;
      int num;
      Console.Write("Insert a value: ");
      num = int.Parse(Console.ReadLine());
      result = num;
      for (int i = 0; i < 9; i++) {
        Console.Write("Insert a value: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0) {
          result += num;
        }
      }
      result = result / 10;
      Console.WriteLine("The average of the given integers is " + result);
      Console.WriteLine("Press any key.");
      Console.ReadLine();
    }
}