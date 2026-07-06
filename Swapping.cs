
// Swap the value of two variable using third variable


using System;

public class Swapping
{
    
    public static void Main(string[] args)
    {
      int a = 10;
      int b = 5;
      int c = 0;
      
      Console.WriteLine($"The value of a, b, and c without swapping is :{a}, {b} , {c}");
      
      a = b;
      b = c;
      c = a;
      
      Console.WriteLine($"The value of a, b, and c after swapping is:a = {b}, b = {c}, c = {a}");
    }
    
   
}
