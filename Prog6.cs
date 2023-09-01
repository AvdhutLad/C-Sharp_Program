using System;
class Program
{
  static void Main ()
  {
	int n,m,o;
	float avg;
	Console.WriteLine("Enter marks of three subject  : ");
	n=int.Parse(Console.ReadLine());
        m=int.Parse(Console.ReadLine());
        o=int.Parse(Console.ReadLine());
	avg=(n+m+o)/3.0f;
	if(avg>=70)
	  Console.WriteLine("Distanction");
	else if(avg>=60)
	  Console.WriteLine("Grad A");
	else if(avg>=50)
	  Console.WriteLine("Grad B");
	else if(avg>=40)
	  Console.WriteLine("Pass");
	else
	  Console.WriteLine("Fail");
   }
}