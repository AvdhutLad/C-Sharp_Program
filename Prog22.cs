using System;
public class A
{
 public void methodA()
 {
  Console.WriteLine("Base Class");
 }
}
public class B:A
{
  public void methodB()
 {
  Console.WriteLine("Derive Class");
 }
  static void Main ()
  {
   B b= new B();
   b.methodA();
   b.methodB();
 }
}