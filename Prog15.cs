using System;
class Program
{
  static void Main ()
  {
    
    int n,rem,sum=0;
    Console.WriteLine("Enter no  : ");
    
    n=int.Parse(Console.ReadLine());
	
    while(n>0)
    {
      rem=n%10;
      sum=sum+rem;
      n=n/10;
    
    }
    Console.WriteLine("Sum is: "+sum);

  }
}