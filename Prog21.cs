using System;
class Program
{
  static void Main ()
  {
   int l,b,c;
   Console.WriteLine("Enter l and b  : ");
   l=int.Parse(Console.ReadLine());
   b=int.Parse(Console.ReadLine());
   c=area(l,b);
   Console.WriteLine("Area of Rectangle: "+c);
  }
   static int area(int l,int b)
   {
    int c;
    c=l*b;
    return c;
   }
}
   