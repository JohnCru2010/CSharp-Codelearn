using System;
using System.Threading;
public class HelloWorld {
  public static void Main() {
    int seg = 50;
    int min = 59;
    int hours = 23;
    while (hours < 24) {
        seg += 1;
        Thread.Sleep(1000);
        if (seg == 60) {
            seg = 0;
            min += 1;
        }
        if (min == 60) {
            min = 0;
            hours += 1;
        }
        Console.SetCursorPosition(15, 2);
        Console.WriteLine(hours + " : " + min + " : " + seg);
    }
    
  }
}