// Declare variables for principal, rate, and time, then calculate simple interest.



using System;

public class SimpleInterest
{
    
    public static void Main(string[] args)
    {
      double rate = 10;
      double principal = 20;
      double time = 5;
      double SI;
      
      Console.WriteLine($"The value of rate is :{rate} ");
       Console.WriteLine($"The value of principal is :{principal} ");
       Console.WriteLine($"The value of thime is : {time}");
      
      
      SI = (principal*rate*time)/100;
      
      
      Console.WriteLine($"The simple interest is : {SI}");
    }
   
}
