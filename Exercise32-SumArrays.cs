using System;

class Program {
    static void Main(string[] args) {
      Console.Write("Insert total elements: ");
      int totalElements = int.Parse(Console.ReadLine());
      int[] v1 = readArray(totalElements);
      int[] v2 = readArray(totalElements);
      showArray(sumArray(v1, v2));
      Console.WriteLine ("Press any key.");
      Console.ReadLine();
    }

    public static int[] readArray (int n) {
      int[] array = new int[n];
      for (int i = 0; i < n; i++) {
	      Console.Write ("Insert integer value: ");
	      array[i] = int.Parse (Console.ReadLine ());
      }
      return array;
    }

    public static int[] sumArray (int[] v1, int[] v2) {
      int[] VResult = new int[v1.Length];
      for (int i = 0; i < v1.Length; i++) {
	      VResult[i] += v1[i] + v2[i];
      }
      return VResult;
    }

    public static void showArray (int[] v1) {
      Console.Write("[");
      Console.Write(String.Join (", ", v1));
      Console.WriteLine("]");
    }
}