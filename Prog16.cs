using System;
class Program
{
  static void Main ()
  {
    
    int n,count=0;
    Console.WriteLine("Enter no  : ");
    
    n=int.Parse(Console.ReadLine());
	
    for(int i=1;i<=n;i++)
    {
      if(n%i==0)
      count++;
    }
   if(count==2)
    Console.WriteLine("Prime");
  else
    Console.WriteLine("Not Prime");

  }
}