using System;  
public class Person 
{  
 public int id;   
        public String nm;  
        public Person(int i, String a)  
        {  
            id = i;  
            nm = a;   
        }  
}  
public class Student: Person  
{  
          
        public string cls; 
         public string Year;  
        
        public Student(int i, String a ,String n,string s):base(i,a)  
        {
            cls=n;  
            Year=s;
        }  
    public void get_info()  
    {  
         Console.WriteLine("Student Info:\n");
        Console.WriteLine("ID:"+base.id);
        Console.WriteLine("Name:"+base.nm);    
        Console.WriteLine("Class:"+cls);  
        Console.WriteLine("Year:"+Year);  
        Console.WriteLine();
    }  
      
}  
public class Staff: Person  
{  
          
        public float sal; 
         public string pal;  
        
        public Staff(int i, String a ,float p,string e):base(i,a)  
        {
            sal=p;  
            pal=e;
        }  
    public void show_info()  
    {  
        Console.WriteLine("Staff Info:\n");
        Console.WriteLine("ID:"+base.id);
        Console.WriteLine("Name:"+base.nm);    
        Console.WriteLine("Salary:"+sal);  
        Console.WriteLine("Designation:"+pal);  
    }  
      
} 

public class TestBase  
{  
    public static void Main()  
    {  
        Student s = new Student(1,"Avadhut","BCS","last");  
        s.get_info();
        Staff s1 = new Staff(10,"xyz",15000.0f,"CEO");
        s1.show_info(); 
         
    }  
}  