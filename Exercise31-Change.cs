using System;
class Program
{
  static void Main (string[]args)
  {
    int totalElements;
    int numPosition;
    int numToInsert;
    Console.Write ("Insert total elements: ");
    totalElements = int.Parse (Console.ReadLine ());
    int[] nums = new int[totalElements];
    for (int i = 0; i < totalElements; i++) {
	  Console.Write ("Insert integer value: ");
	  nums[i] = int.Parse (Console.ReadLine ());
    } 
    Console.Write ("Insert position to insert element: ");
    numPosition = int.Parse (Console.ReadLine ());
    Console.WriteLine();
    Console.Write ("Insert integer value to insert: ");
    numToInsert = int.Parse (Console.ReadLine ());
    Console.WriteLine();
    Console.WriteLine ("The final values for the array are: ");
    Console.WriteLine (String.Join ("\n", insert (nums, numPosition, numToInsert)));
    Console.WriteLine ("Press any key.");
  }
  public static int[] insert (int[]v, int p, int e)
  {
    int[] nums = new int[v.Length + 1];
    int i = 0;
    if (p >= v.Length)
      {
	while (i < nums.Length - 1)
	  {
	    if (i < nums.Length - 2)
	      {
		nums[i] = v[i];
	      }
	    else
	      {
		nums[i] = v[i];
		nums[i + 1] = e;
	      }
	    i++;
	  }
      }
      
    else if (p < 0)
      {
	  while (i < nums.Length - 1) {
	    if (i == 0) {
		  nums[i] = e;
	    }
	    nums[i+1] = v[i];
	    i++;
	  }
    }
    
    else {
	  while (i != p) {
	      nums[i] = v[i];
	      i++;
      }
      nums[i] = e;
      while (i - 1 < nums.Length - 2) {
           nums[i+1] = v[i];
	       i++; 
      }

    }
    return nums;
  }
}