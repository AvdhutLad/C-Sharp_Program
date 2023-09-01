using System;
class Program
{
  static void Main ()
  {
    
    int i,n;
    Console.WriteLine("Enter no  : ");
    
    n=int.Parse(Console.ReadLine());
	
    i=1;
    while(i<=n)
    {
      Console.WriteLine(i);
      i++;
    }
  }
}