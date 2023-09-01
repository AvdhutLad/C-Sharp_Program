using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class A
{
 public void methodA()
 {
   Console.WriteLine("This is Method 1");
 }
}
   public class B:A
{
  public void methodB()
 {
  Console.WriteLine("This is Method 2");
 }
}
    public class C:B
{
 public void methodC()
 {
  Console.WriteLine("This is Method 3");
 }
  static void Main ()
  {
   C cobj= new C();
   cobj.methodA();
   cobj.methodB();
   cobj.methodC();
  }
}