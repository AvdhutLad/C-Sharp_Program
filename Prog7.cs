using System;
class Program
{
  static void Main ()
  {
	int n;
	
	Console.WriteLine("Enter Positiv no  : ");
	n=int.Parse(Console.ReadLine());
	
	if(n>0 && n<=9)
	  Console.WriteLine("One Digit");
	else if(n>=10 && n<=99)
	  Console.WriteLine("Two Digit");
	else if(n>=100 && n<+999)
	  Console.WriteLine("Three Digit");
	else if(n>=1000 && n<=9999)
	  Console.WriteLine("Four Digit");
	else
	  Console.WriteLine("More than five Digit");
   }
}