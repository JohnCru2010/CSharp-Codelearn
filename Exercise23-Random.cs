using System;
class Exercise23 {
  static void Main() {
    int num;
    int result = 0;
    int numOfTimes;
    Random r = new Random();
    
    Console.Write("Insert the total number of elements to sum: ");
    numOfTimes = int.Parse(Console.ReadLine());
    for (int i = 0; i < numOfTimes; i++) {
        num = r.Next(1, 101);
        Console.WriteLine("The generated number is: " + num);
        result += num;
    }
    Console.WriteLine("The sum of the " + numOfTimes + " generated numbers is " + result);
    Console.WriteLine("Press any key.");
    Console.ReadLine();
  }
}