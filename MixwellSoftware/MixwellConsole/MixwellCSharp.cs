using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace MixwellConsole
{
    class MixwellCSharp        
    {

        //1) What is C-Sharp (C#)?
            //C# is a type-safe, managed and object oriented language, which is compiled by .Net framework for generating intermediate language (IL).
    
        //2) Explain the features of C#?
            //Below are some of the features supported in C# -
            //Constructors and Destructors
            //Properties
            //Passing Parameters
            //Arrays
            //Main
            //XML Documentation and
            //Indexers

        //3) List some of the advantages of C#?
            //Below are the advantages of C# -
             //Easy to learn
            //Object oriented
            //Component oriented
            //Part of .NET framework
 

        //4) What are IDE’s provided by Microsoft for C# development?
            //Below are the IDE’s used for C# development –
            //Visual Studio Express (VCE)
            //Visual Studio (VS)
            //Visual Web Developer
 
        //5) Explain the types of comments in C#?
            //Below are the types of comments in C# -
            //Single Line Comment Eg : //
            //Multiline Comments Eg: /* */
            //XML Comments Eg : ///

        //6) Explain sealed class in C#?
            //Sealed class is used to prevent the class from being inherited from other classes. So “sealed” modifier also can be used with methods to avoid the methods to override in the child classes.

        //7) Give an example of using sealed class in C#?
            //Below is the sample code of sealed class in C# -
            //class X {} 
            //sealed class Y : X {}

            //Sealed methods –

        class A
        {
            protected virtual void First() { }
            protected virtual void Second() { }
        }
        
        class B : A
        {
            sealed protected override void First() {}
            protected override void Second() { }
        }

        //If any class inherits from class “B” then method – “First” will not be overridable as this method is sealed in class B.

        
        //8) List out the differences between Array and ArrayList in C#?
            //Array stores the values or elements of same data type but arraylist stores values of different datatypes.
            //Arrays will use the fixed length but arraylist does not uses fixed length like array.

        //9) Why to use “using” in C#?
            //“Using” statement calls – “dispose” method internally, whenever any exception occurred in any method call and in “Using” statement objects are read only and cannot be reassignable or modifiable.
            //using for classes that require cleaning up after them

        public class MyClass : IDisposable
        {
            public void Action()
            {
            }

            public void Dispose()
            {
            }

            void usingFunc()
            {
                using (MyClass mine = new MyClass())
                {
                    mine.Action();
                }
                // both same but using one easy to read
                MyClass mine1 = new MyClass();
                try
                {
                    mine1.Action();
                }
                finally
                {
                    if (mine1 != null)
                        mine1.Dispose();
                }
            }

        }


        //10) Explain namespaces in C#?
            //Namespaces are containers for the classes. We will use namespaces for grouping the related classes in C#. “Using” keyword can be used for using the namespace in other namespace.

        //11) Why to use keyword “const” in C#? Give an example.
        //“Const” keyword is used for making an entity constant. We can’t reassign the value to constant.

            //Eg: const string _name = "Test";

        //12) What is the difference between “constant” and “readonly” variables in C#?
            //“Const” keyword is used for making an entity constant. We cannot modify the value later in the code. Value assigning is mandatory to constant variables.
            //“readonly” variable value can be changed during runtime and value to readonly variables can be assigned in the constructor or at the time of declaration.

        
        //13) Explain “static” keyword in C#?
            //“Static” keyword can be used for declaring a static member. If the class is made static then all the members of the class are also made static. If the variable is made static then it will have a single instance and the value change is updated in this instance.
        
        //14) What is the difference between “dispose” and “finalize” variables in C#?
            //Dispose - This method uses interface – “IDisposable” interface and it will free up both managed and unmanaged codes like – database connection, files etc.
            //Finalize - This method is called internally unlike Dispose method which is called explicitly. It is called by garbage collector and can’t be called from the code.

        //15) How the exception handling is done in C#?
            //In C# there is a “try… catch” block to handle the error.

        //16) Can we execute multiple catch blocks in C#?
            //No. Once any exception is occurred it executes specific exception catch block and the control comes out.

        //17) Why to use “finally” block in C#?
            //“Finally” block will be executed irrespective of exception. So while executing the code in try block when exception is occurred, control is returned to catch block and at last “finally” block will be executed. So closing connection to database / releasing the file handlers can be kept in “finally” block.

        //18) What is the difference between “finalize” and “finally” methods in C#?
            //Finalize – This method is used for garbage collection. So before destroying an object this method is called as part of clean up activity.
            //Finally – This method is used for executing the code irrespective of exception occurred or not.

        //19) What is the difference between “throw ex” and “throw” methods in C#?
            //“throw ex” will replace the stack trace of the exception with stack trace info of re throw point.
            //“throw” will preserve the original stack trace info.
 

        //20) Can we have only “try” block without “catch” block in C#?
            //Yes we can have only try block without catch block but we have to have finally block.

        //21) List out two different types of errors in C#?
            //Below are the types of errors in C# -
            //Compile Time Error
            //Run Time Error

        //22) Do we get error while executing “finally” block in C#?
            //Yes. We may get error in finally block.

        //23) Mention the assembly name where System namespace lies in C#?
            //Assembly Name – mscorlib.dll
        
        //24) What are the differences between static, public and void in C#?
            //Static classes/methods/variables are accessible throughout the application without creating instance. Compiler will store the method address as an entry point. 
            //Public methods or variables are accessible throughout the application. 
            //Void is used for the methods to indicate it will not return any value.

    //25) What is the difference between “out” and “ref” parameters in C#?
        //“out” parameter can be passed to a method and it need not be initialized where as “ref” parameter has to be initialized before it is used.

    //26) Explain Jagged Arrays in C#?
        //If the elements of an array is an array then it’s called as jagged array. The elements can be of different sizes and dimensions.

    //27) Can we use “this” inside a static method in C#?
        //No. We can’t use “this” in static method.

    //28) What are value types in C#?
        //Below are the list of value types in C# -
        //decimal
        //int
        //byte
        //enum
        //double
        //long
        //float


        //29) What are reference types in C#?
            //Below are the list of reference types in C# -
            //class
            //string
            //interface
            //object

        //30) Can we override private virtual method in C#?
            //No. We can’t override private virtual methods as it is not accessible outside the class.

    //31) Explain access modifier – “protected internal” in C#?
        //“protected internal” can be accessed in the same assembly and the child classes can also access these methods.

    //32) In try block if we add return statement whether finally block is executed in C#?
        //Yes. Finally block will still be executed in presence of return statement in try block.

    //33) What you mean by inner exception in C#?
        //Inner exception is a property of exception class which will give you a brief insight of the exception i.e, parent exception and child exception details.

    //34) Explain String Builder class in C#?
        //This will represent the mutable string of characters and this class cannot be inherited. It allows us to Insert, Remove, Append and Replace the characters. “ToString()” method can be used for the final string obtained from StringBuilder. For example,
        //StringBuilder TestBuilder = new StringBuilder("Hello");
        //TestBuilder.Remove(2, 3); // result - "He"
        //TestBuilder.Insert(2, "lp"); // result - "Help"
        //TestBuilder.Replace('l', 'a'); // result - "Heap"
 

    //35) What is the difference between “StringBuilder” and “String” in C#?
        //StringBuilder is mutable, which means once object for stringbuilder is created, it later be modified either using Append, Remove or Replace.
        //String is immutable and it means we cannot modify the string object and will always create new object in memory of string type.

    //36) What is the difference between methods – “System.Array.Clone()” and “System.Array.CopyTo()” in C#?
        //“CopyTo()” method can be used to copy the elements of one array to other. 
        //“Clone()” method is used to create a new array to contain all the elements which are in the original array.
    
    //37) How we can sort the array elements in descending order in C#?
        //“Sort()” method is used with “Reverse()” to sort the array in descending order.


    //38) Explain circular reference in C#?
        //This is a situation where in, multiple resources are dependent on each other and this causes a lock condition and this makes the resource to be unused.


    //39) List out some of the exceptions in C#?
        //Below are some of the exceptions in C# -
        //NullReferenceException
        //ArgumentNullException
        //DivideByZeroException
        //IndexOutOfRangeException
        //InvalidOperationException
        //StackOverflowException etc.

    //40) Explain Generics in C#?
        //Generics in c# is used to make the code reusable and which intern decreases the code redundancy and increases the performance and type safety. 
        //Namespace – “System.Collections.Generic” is available in C# and this should be used over “System.Collections” types.

    //41) Explain object pool in C#?
    //Object pool is used to track the objects which are being used in the code. So object pool reduces the object creation overhead.


    //42) What you mean by delegate in C#?
        //Delegates are type safe pointers unlike function pointers as in C++. Delegate is used to represent the reference of the methods of some return type and parameters.

    //43) What are the types of delegates in C#?
        //Below are the uses of delegates in C# -
        //Single Delegate
        //Multicast Delegate
        //Generic Delegate

    //44) What are the three types of Generic delegates in C#?
        //Below are the three types of generic delegates in C# -
        //Func
        //Action
        //Predicate

    //45) What are the differences between events and delegates in C#?
        //Main difference between event and delegate is event will provide one more of encapsulation over delegates. So when you are using events destination will listen to it but delegates are naked, which works in subscriber/destination model.

        //46) Can we use delegates for asynchronous method calls in C#?
            //Yes. We can use delegates for asynchronous method calls.

        //47) What are the uses of delegates in C#?
            //Below are the list of uses of delegates in C# -
            //Callback Mechanism
            //Asynchronous Processing
            //Abstract and Encapsulate method
            //Multicasting
 

        //48) What is Nullable Types in C#?
            //Variable types does not hold null values so to hold the null values we have to use nullable types. So nullable types can have values either null or other values as well.
                //Eg: Int? mynullablevar = null;
        
        //49) Why to use “Nullable Coalescing Operator” (??) in C#?
            //Nullable Coalescing Operator can be used with reference types and nullable value types. So if the first operand of the expression is null then the value of second operand is assigned to the variable. For example,
            double? myFirstno = null;
            double mySecno;
            //mySecno = myFirstno ?? 10.11;
 

            //50) What is the difference between “as” and “is” operators in C#?
                //“as” operator is used for casting object to type or class.
                //“is” operator is used for checking the object with type and this will return a Boolean value.

            //51) Define Multicast Delegate in C#?
                //A delegate with multiple handlers are called as multicast delegate. The example to demonstrate the same is given below
/*
            void delegateFun()
            {
                public delegate void CalculateMyNumbers(int x, int y);
                int x = 6;
                int y = 7;
                //CalculateMyNumbers addMyNumbers = new CalculateMyNumbers(FuncForAddingNumbers);
                //CalculateMyNumbers multiplyMyNumbers = new CalculateMyNumbers(FuncForMultiplyingNumbers);
                //CalculateMyNumbers multiCast = (CalculateMyNumbers)Delegate.Combine (addMyNumbers, multiplyMyNumbers);
                //multiCast.Invoke(a,b);
            }
*/
            //52) What is the difference between CType and Directcast in C#?
                //CType is used for conversion between type and the expression.
                //Directcast is used for converting the object type which requires run time type to be the same as specified type.

            //53) Is C# code is unmanaged or managed code?
                //C# code is managed code because the compiler – CLR will compile the code to Intermediate Language.

            //54) Why to use lock statement in C#?
                //Lock will make sure one thread will not intercept the other thread which is running the part of code. So lock statement will make the thread wait, block till the object is being released.

            //55) Explain Hashtable in C#?
                //It is used to store the key/value pairs based on hash code of the key. Key will be used to access the element in the collection. For example,

            //56) How to check whether hash table contains specific key in C#?
                //Method – “ContainsKey” can be used to check the key in hash table. Below is the sample code for the same –
                //Eg: myHashtbl.ContainsKey("1");
          /*  
            void hashtableFun()
            {
                Hashtable myHashtbl = new Hashtable();
                myHashtbl.Add("1", "TestValue1");
                myHashtbl.Add("2", "TestValue2");
                if(myHashtbl.ContainsKey(""))
                    return;
            }
            */


        //57) What is enum in C#?
        //enum keyword is used for declaring an enumeration, which consists of named constants and it is called as enumerator lists. Enums are value types in C# and these can’t be inherited. Below is the sample code of using Enums
        //Eg: enum Fruits { Apple, Orange, Banana, WaterMelon};

        //58) Which are the loop types available in C#?
        //Below are the loop types in C# -
        //For
        //While
        //Do.. While

        //59) What is the difference between “continue” and “break” statements in C#?
        //“continue” statement is used to pass the control to next iteration. This statement can be used with – “while”, “for”, “foreach” loops.
        //“break” statement is used to exit the loop.

        //60) Write a sample code to write the contents to text file in C#?
        //Below is the sample code to write the contents to text file –

            

       // File.WriteAllText(”mytextfilePath”, “MyTestContent”);

        //61) What you mean by boxing and unboxing in C#?
            //Boxing – This is the process of converting from value type to reference type. For example,
        public void boxingDaTa()
        {
            int myvar = 10;
            object myObj = myvar;
            //UnBoxing – It’s completely opposite to boxing. It’s the process of converting reference type to value type. For example,
            int myvar2 = (int)myObj;
        }

        //62) Explain Partial Class in C#?
            //Partial classes concept added in .Net Framework 2.0 and it allows us to split the business logic in multiple files with the same class name along with “partial” keyword.

        //63) Explain Anonymous type in C#?
            //This is being added in C# 3.0 version. This feature enables us to create an object at compile time. Below is the sample code for the same –
            //Var myTestCategory = new { CategoryId = 1, CategoryName = “Category1”};
    
        //64) Name the compiler of C#?
            //C# Compiler is – CSC.

        //65) Explain the types of unit test cases?
        //Below are the list of unit test case types –
        //Positive Test cases
        //Negative Test cases
        //Exception Test cases

        public static class BankAccount
        {
            private static double _balance = 0;
            private static double _debit = 0;
            private static string _title = "";

            public static double Balance
            {
                get { return _balance - _debit; }
                set { _balance = value; }
            }

            public static double Debit
            {
                get { return _debit; }
                set { _debit = value; }
            }

        }

        // unit test code  
        //[TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange  
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            // act  
            BankAccount.Balance = beginningBalance;
            BankAccount.Debit = debitAmount;

            // assert  
            double actual = BankAccount.Balance;
            //Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }  

        // 66) Explain Copy constructor in C#?

        //67) Explain Static constructor in C#?
        //If the constructor is declared as static then it will be invoked only once for all number of instances of a class. Static constructor will initialize the static fields of a class.

        //68) Which string method is used for concatenation of two strings in c#?

        public void strConcat()
        {
            string s1 = "string2";
            string s2 = string.Concat("string1", s1);
            Console.WriteLine(s2);
        }
    


        //69) Explain Indexers in C#?
        //Indexers are used for allowing the classes to be indexed like arrays. Indexers will resemble the property structure but only difference is indexer’s accessors will take parameters. For example,

        class MyCollection<T>
        {
            private T[] myArr = new T[100];
            public T this[int t]
            {
                get
                {
                    return myArr[t];
                }

                set
                {
                    myArr[t] = value;
                }
            }
        }


        //70) What are the collection types can be used in C#?
        //Below are the collection types in C# -
        //ArrayList
        //Stack
        //Queue
        //SortedList
        //HashTable
        //Bit Array

        ArrayList myArryList = new ArrayList();
        Stack stk = new Stack();
        Queue que = new Queue();
        SortedList sl = new SortedList();
        Hashtable ht = new Hashtable();
        BitArray ba;

        void setBitArray()
        {
  
            // Create array of 5 elements and 3 true values.
            bool[] array = new bool[5];
            array[0] = true;
            array[1] = false; // <-- False value is default
            array[2] = true;
            array[3] = false;
            array[4] = true;

            // Create BitArray from the array.
            BitArray bitArray = new BitArray(array);

            // Display all bits.
            foreach (bool bit in bitArray)
            {
                Console.WriteLine(bit);
            }

        }
        

        //71) Explain Attributes in C#?
        //Attributes are used to convey the info for runtime about the behavior of elements like – “methods”, “classes”, “enums” etc.
        //Attributes can be used to add metadata like – comments, classes, compiler instruction etc.

        //72) List out the pre defined attributes in C#?
        //Below are the predefined attributes in C# -
        //Conditional
        //Obsolete
        //Attribute Usag

        public class Class1
        {
            [Obsolete]
            public void Method1()
            {
            }
            public void NewMethod1()
            {
            }

            

        }

        //73) What is Thread in C#?
        // Thread is an execution path of a program. Thread is used to define the different or unique flow of control. If our application involves some time consuming processes then it’s better to use Multithreading., which involves multiple threads.

        //74) List out the states of a thread in C#?
        //Below are the states of thread –
        //Unstarted State
        //Ready State
        //Not Runnable State
        //Dead State

        //75) Explain the methods and properties of Thread class in C#?
        //Below are the methods and properties of thread class –
        //CurrentCulture
        //CurrentThread
        //CurrentContext
        //IsAlive
        //IsThreadPoolThread
        //IsBackground
        //Priority

        public void runAMultipleThreading()
        {
            Thread T1 = new Thread(ThreadFunction);
            Thread T2 = new Thread(ThreadFunction);
            T1.Start();
            T2.Start();
            //T2.CurrentCulture();
            //if(T2.IsAlive())
            //T2.IsThreadPoolThread
            //T2.
            var tp = T2.Priority;
            var tcc = T2.ThreadState;
            var ta = T2.IsAlive;
            var tb = T2.IsBackground;
            var tct = T2.IsThreadPoolThread;
            

        }

        void ThreadFunction()
        {
            Console.WriteLine("called a thread funciton.");
        }
    }
}
