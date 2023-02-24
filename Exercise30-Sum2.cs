using System;

class Program {
    static void Main(string[] args) {
      int num;
      int[] nums = new int[10];
      
      for (int i = 0; i < 10; i++) {
        Console.Write("Insert a value: ");
        num = int.Parse(Console.ReadLine());
        nums[i] = num;
      }
      
      Console.Write("Insert integer for multiple value: ");
      num = int.Parse(Console.ReadLine());
      Console.WriteLine("The sum of given values in positions multiples of " + num + " is " + sumMult(nums, num) + ".");
      
      Console.WriteLine("Press any key.");
      Console.ReadLine();
    }
    public static int sumMult (int[] v, int n) {
        int sum = 0;
        for (int i = 0; i < 10; i++) {
          if ((v[i] % n) == 0) {
            sum += v[i];
          }
        }
        return sum;
    }
}