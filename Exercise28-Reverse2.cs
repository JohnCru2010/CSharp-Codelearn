using System;

class Program {
    static void Main(string[] args) {
      String word;
      Console.Write("Insert a text phrase: ");
      word = Console.ReadLine();
      for (int i = word.Length-1; i >= 0; i--) {
        Console.Write(word[i].ToString());
        Console.Write(word[i].ToString());
        Console.Write(word[i].ToString());
        Console.WriteLine(word[i].ToString());
      }
      Console.WriteLine("Press any key.");
      Console.ReadLine();
    }
}