using System;
class Program
{
  static void Main ()
  {
	int n,m,o;
	Console.WriteLine("Enter three no : ");
	n=int.Parse(Console.ReadLine());
        m=int.Parse(Console.ReadLine());
        o=int.Parse(Console.ReadLine());
	if(n>m && n>o)
	  Console.WriteLine("Max no is "+n);
	else if(m>n && m>o)
	  Console.WriteLine("Max no is "+m);
	else
	  Console.WriteLine("Max no is "+o);
   }
}