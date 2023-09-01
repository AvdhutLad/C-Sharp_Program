using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace hw_inh
{
public class Person
{
 public void pr_info()
 {
   Console.WriteLine("This is Method of person");
 }
}
   public class Student:Person
{
  public void st_info()
 {
  Console.WriteLine("This is Method of student");
 }
}
    public class Staff:Person
{
 public void staff_info()
 {
  Console.WriteLine("This is Method of staff");
 }
}
public class teaching_staff:Staff
{
 public void teaching_info()
 {
  Console.WriteLine("This is Method of teaching staff");
 }
}
public class Non_teaching:Staff
{
 public void nonteaching_info()
 {
  Console.WriteLine("This is Method of non teaching staff");
 }

  static void Main ()
  {  
   Non_teaching n=new Non_teaching();
   n.nonteaching_info();
   n.staff_info();
   teaching_staff t=new teaching_staff();
   t.teaching_info();
   t.staff_info();
   Student s=new Student();
   s.st_info();
   s.pr_info();

  }
}
}