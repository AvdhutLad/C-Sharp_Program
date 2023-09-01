using System;
class Program
{
  static void Main ()
  {
	int n,m;
	Console.WriteLine("Enter no : ");
	n=int.Parse(Console.ReadLine());
        m=int.Parse(Console.ReadLine());
	if(n>m)
	  Console.WriteLine("Max no "+n);
	else
	  Console.WriteLine("Max no "+m);
   }
}