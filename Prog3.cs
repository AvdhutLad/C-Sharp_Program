using System;
class Program
{
  static void Main ()
  {
	float pa,i,fb;
	Console.WriteLine("Enter no : ");
	pa=int.Parse(Console.ReadLine());
       
	if(pa>=2000)
	  {
	    i=(pa*10)/100;
	     fb=pa-i;
	     Console.WriteLine("Discount: "+i);
             Console.WriteLine("Final Bill: "+fb);
	  }
	  
	else
	  {
	    i=(pa*5)/100;
	     fb=pa-i;
             Console.WriteLine("Discount: "+i);
             Console.WriteLine("Final Bill: "+fb);
	  }
	  
   }
}