using System;

class Program {
    static void Main(string[] args) {
      String result = "";
      String word;
      Console.Write("Insert a text string: ");
      word = Console.ReadLine();
      for (int i = word.Length-1; i >= 0; i--) {
        result += word[i].ToString();
      }
      Console.WriteLine("The result of reversing the string " + word + " is " + result);
      Console.WriteLine("Press any key.");
      Console.ReadLine();
    }
}