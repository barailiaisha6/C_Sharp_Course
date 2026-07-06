// Store the length and breadth of a rectangle and calculate the perimeter.


using System;

public class Rectangle
{
    
    public static void Main(string[] args)
    {
      int length = 10;
      int breadth = 20;
      int p;
      
      Console.WriteLine($"The value of length is :{length} ");
       Console.WriteLine($"The value of breadth is :{breadth} ");
      
      
      p = 2*(length + breadth);
      
      
      Console.WriteLine($"The rectangle of perimeter is : {p} ");
    }
   
}
