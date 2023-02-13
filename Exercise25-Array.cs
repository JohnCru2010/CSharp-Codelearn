using System;

class Program {
    static void Main(string[] args) {
      String word;
      Console.Write("Insert a text string: ");
      word = Console.ReadLine();
      for (int i = 0; i < word.Length; i++) {
        Console.WriteLine(word[i]);
      }
      Console.WriteLine("Press any key.");
      Console.ReadLine();
    }
}