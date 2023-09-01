using System;
class Program
{
  static void Main ()
  {
    
    int i,n,fact=1;
    Console.WriteLine("Enter no  : ");
    
    n=int.Parse(Console.ReadLine());
	
    i=1;
    while(i<=n)
    {
    
      fact=fact*i;
      i++;
    }
    Console.WriteLine("Factorial is: "+fact);

  }
}