using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://a4academics.com/interview-questions/52-dot-net-interview-questions/417-c-oops-interview-questions-and-answers?showall=&start=8

namespace MixwellConsole
{
    //76) What is a class ?

    //A class is the generic definition of what an object is. A Class describes all the attributes of the object, as well as the methods that implement the behavior of the member object. In other words, class is a template of an object. For ease of understanding a class, we will look at an example. 

    //77) What is an Object?
    //An object is an instance of a class. It contains real values instead of variables. For example, let us create an instance of the class Employee called “John”.
    //Employee John= new Employee();
    //Now we can access all the methods in the class “Employee” via object “John” as shown below.
    //John.setName(“XYZ”); 

    //78) What are the Access Modifiers in C# ?
    //Different Access Modifier are - Public, Private, Protected, Internal, Protected Internal

    //Different Access Modifier are - Public, Private, Protected, Internal, Protected Internal
    //Public – When a method or attribute is defined as Public, it can be accessed from any code in the project. For example, in the above Class “Employee” getName() and setName() are public.
    //Private - When a method or attribute is defined as Private, It can be accessed by any code within the containing class only. For example, in the above Class “Employee” attributes name and salary can be accessed within the Class Employee Only. If an attribute or class is defined without access modifiers, it's default access modifier will be private.
    //Protected - When attribute and methods are defined as protected, it can be accessed by any method in the inherited classes and any method within the same class. The protected access modifier cannot be applied to classes and interfaces. Methods and fields in a interface can't be declared protected.
    //Internal – If an attribute or method is defined as Internal, access is restricted to classes within the current project assembly.
    //Protected Internal – If an attribute or method is defined as Protected Internal, access is restricted to classes within the current project assembly and types derived from the containing clases


    //79) Explain Static Members in C# ?
    //If an attribute's value had to be same across all the instances of the same class, the static keyword is used. For example, if the Minimum salary should be set for all employees in the employee class, use the following code.

    //80) What is Reference Type in C# ?
    
    //Employee emp1;
    //Employee emp2 = new Employee();
    //emp1 = emp2;
    //Here emp2 has an object instance of Employee Class. But emp1 object is set as emp2. What this means is that the object emp2 is referred in emp1, rather than copying emp2 instance into emp1. When a change is made in emp2 object, corresponding changes can be seen in emp1 object. 

    //81) Define Property in C# ?
    //Properties are a type of class member, that are exposed to the outside world as a pair of Methods. For example, for the static field Minsalary, we will Create a property as shown below.

    public static class MixwellProperties
    {
        private static double minimumSalary;
        public static double MinSalary
        {
            get
            {
                return minimumSalary;
            }
            set
            {
                minimumSalary = value;
            }
        }
    }

    //82) Explain Overloading in C# ?
    //When methods are created with the same name, but with different signature its called overloading. For example, WriteLine method in console class is an example of overloading. In the first instance, it takes one variable. In the second instance, “WriteLine” method takes two variable.
    //Different types of overloading in C# are
    //Constructor overloading
    //Function overloading
    //Operator overloading    

    public class MixwellEmployee
    {
        //85) What is Constructor Overloading in C# .net ?
        public MixwellEmployee()
        { }
        public MixwellEmployee(String Name)
        { }

        //85) What is function Overloading in C# .net ?
        public void Employee()
        { }
        public void Employee(String Name)
        { }

    }

    //85) What is Operator Overloading in C# .net ?

    class MixwellRectangle
    {
        private int _height;
        private int _width;

        public MixwellRectangle(int Height, int Width)
        {
            _height = Height;
            _width = Width;
        }

        public static bool operator>(MixwellRectangle a, MixwellRectangle b)
        {
            return a._height > b._height; 
        }

        public static bool operator<(MixwellRectangle a, MixwellRectangle b)
        {
            return a._height < b._height;
        }
        
    }

    //86) What is Data Encapsulation ?
    //Data Encapsulation is defined as the process of hiding the important fields from the end user. using public properity set get method to interface to privae member

    //87) Explain Inheritance in C# ?
    //In object-oriented programming (OOP), inheritance is a way to reuse code of existing objects. In inheritance, there will be two classes - base class and derived classes. A class can inherit attributes and methods from existing class called base class or parent class. The class which inherits from a base class is called derived classes or child class. For m

    //88) Can Multiple Inheritance implemented in C# ?
    //In C#, derived classes can inherit from one base class only. If you want to inherit from multiple base classes, use interface.
    
    //89) What is Polymorphism in C# ?
    //The ability of a programming language to process objects in different ways depending on their data type or class is known as Polymorphism. There are two types of polymorphism
    //Compile time polymorphism. Best example is Overloading
    //Runtime polymorphism. Best example is Overriding

    //90) Explain the use of Virtual Keyword in C# ?
    //When we want to give permission to a derived class to override a method in base class, Virtual keyword is used. For example. lets us look at the classes Car and Ford as shown below

    class MixwellMethodVitualClass
    {
        public MixwellMethodVitualClass()
        {
            Console.WriteLine("Base MixwellMethodVitualClass");
        }

        public virtual void Methodvirtual()
        {
            Console.WriteLine("Bath Methodvirtual");
        }
    }

    class ChildMixwellMethodVitualClass : MixwellMethodVitualClass
    {
        public override void Methodvirtual()
        {
            Console.WriteLine("Child Methodvirtual");
        }
    }
    
    
    //91 What is overriding in c# ?
    //To override a base class method which is defined as virtual, Override keyword is used. In the above example, method DriveType is overridden in the derived class.

    //92) What is Method Hiding in C# ?
        //If the derived class doesn't want to use methods in the base class, derived class can implement it's own version of the same method with same signature. For example, in the classes given below, DriveType() is implemented in the derived class with same signature. This is called Method Hiding.

    class MixwellMethodHideClass
    {
        public MixwellMethodHideClass()
        {
            Console.WriteLine("Base MixwellMethodHideClass");
        }

        public void MethodHide()
        {
            Console.WriteLine("Bath MethodHide");
        }
    }

    class ChildMixwellMethodHideClass : MixwellMethodHideClass
    {
        public new void MethodHide()
        {
            Console.WriteLine("Child MethodHide");
        }
    }


    //93) What is Abstract Class in C#?
        //If we don't want a class to be instantiated, define the class as abstract. An abstract class can have abstract and non abstract classes. If a method is defined as abstract, it must be implemented in derived class. For example, in the classes given below, method DriveType is defined as abstract. 
    
    abstract class MixwellAbstractClass
    {
        public MixwellAbstractClass()
        {
            Console.WriteLine("Base Class Car");
        }

        public abstract void AbstractMethod();
    }

    class ChildMixwellAbstractClass : MixwellAbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Child Abstract Method");
        }
    }


    //94) What is Sealed Classes in c# ?
    //If a class is defined as Sealed, it cannot be inherited in derived class. Example of a sealed class is given below.

    sealed class SealedClass
    {
        SealedClass()
        {
            Console.WriteLine("Welcome message from Mixwell Sealed Class Constractor");
        }

    }

    // class ChildSealedClass : SealedClass{} 
    // Error	1	'MixwellConsole.ChildSealedClass': cannot derive from sealed type 'MixwellConsole.SealedClass'	C:\Workarea\WCFandWVC\MixwellSoftware\MixwellConsole\MixwellClass.cs	24	11	MixwellConsole


    //95) What is an Interface in C# ?
    //An interface is similar to a class with method signatures. There wont be any implementation of the methods in an Interface. Classes which implement interface should have an implementation of methods defined in the abstract class.

    interface Bussiness
    {
        void RunBussiness();
    }

    interface Software
    {
        void TestSoftware();
    }

    class MixwellClass : Bussiness, Software
    {

        //96) What is Constructor of in C#
        // Constructor is a special method that get invoked/called automatically, whenever an object of a given class gets instantiated. In our class car, constructor is defined as shown below

        public MixwellClass()
        {
            Console.WriteLine("Welcome message from Mixwell Class Constractor");
        }

        public void Administrator()
        {
            Console.WriteLine("Welcome message from Mixwell Class Administrator");
        }

        public void RunBussiness()
        {
            Console.WriteLine("Welcome message from Mixwell Class RunBussiness");
        }

        public void TestSoftWare()
        {
            Console.WriteLine("Welcome message from Mixwell Class TestSoftWare");
        }


        //97) What is Destructor of in C#
        // Destructor is a special method that get invoked/called automationcally 
        //whenever an object of a given class get destroyed.

        ~MixwellClass()
        {
            Console.WriteLine("See you later Mixwell Class Destractor");
        }



        void Bussiness.RunBussiness()
        {
            throw new NotImplementedException();
        }

        public void TestSoftware()
        {
            throw new NotImplementedException();
        }

        void Software.TestSoftware()
        {
            throw new NotImplementedException();
        }
    }
}
