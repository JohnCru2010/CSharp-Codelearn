using System;
class Exercise22 {
  static void Main() {
    int num;
    int result = 0;
    int numOfTimes;
    Console.Write("Insert the total number of elements to sum: ");
    numOfTimes = int.Parse(Console.ReadLine());
    for (int i = 0; i < numOfTimes; i++) {
        Console.Write("Insert an integer number: ");
        num = int.Parse(Console.ReadLine());
        result += num;
    }
    Console.WriteLine("The sum of the " + numOfTimes + " given numbers is " + result);
    Console.WriteLine("Press any key.");
    Console.ReadLine();
  }
}