using System;
class Program
{
  static void Main ()
  {
	int n;
	Console.WriteLine("Enter no : ");
	n=int.Parse(Console.ReadLine());
	if(n>0)
	  Console.WriteLine("No is +ve ");
	else
	  Console.WriteLine("No is -ve ");
   }
}