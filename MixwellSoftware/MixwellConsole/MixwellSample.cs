using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Threading;

namespace MixwellConsole
{

    class MixwellSample
    {
        //1. C# Value Types vs. Reference Types 
        //https://www.youtube.com/watch?v=0CsRK1HzJWk

        class Fraction
        {
            public int numerator;
            public int denominator;

        }

        struct FractionStruct
        {
            public int numerator;
            public int denominator;

        }


        public void TestValueTypevsReferenceType()
        {            
            Fraction fract1 = new Fraction{numerator = 1, denominator = 2};
            Fraction fract2 = fract1;

            //stack                      //heap start address
            //fract1     ===>                numberator = 1
            //fract2     ===>                denominator = 2

            fract2.numerator = 555;
            Console.WriteLine(fract1.numerator); //print out 555 
            Console.WriteLine(fract1.numerator);  //print out 555 
            //print out 555 insted of 1. because frac2 have same refernece heap start address of frac1
            // fract1 is reference type

           //using struct as value type
            FractionStruct fractS1 = new FractionStruct { numerator = 1, denominator = 2 };
            FractionStruct fractS2 = fractS1;
            fractS2.numerator = 555;
            Console.WriteLine(fractS1.numerator); //print out 1
            Console.WriteLine(fractS2.numerator); //print out 555 
            //fractS2 has value type which is new clone of fract1.

            //stack
            //fractS1   numberator = 1
            //          denominator = 2
            //fractS2   numberator = 1
            //          denominator = 555

            //************************************************


        }

        
        //2. C# Static Variables.
        //https://www.youtube.com/watch?v=53LWUQVyZb8
        
        int whatever = 5;  //static value put at static memory 

        class Cow
        {
            static int numInstances;  //static value put at static memory, it is global data 
            int id;
            public Cow() { id = ++ numInstances;}
        }

        public void TestStaticVariables()
        {  // all data in class shared in one instance.
            Cow besty = new Cow();   //numInstances = 0; id = ++numInstances = 1
            Cow georgy = new Cow();  //numInstances = 1; id =  = ++numInstances = 2
        }

        //3. C# Static Classes vs Singleton Design Pattern 
        //https://www.youtube.com/watch?v=f-Dv_EuNMfM
        // Static classes is not create instance (put at static memory) 
        // but Singleton create only instance (put at heap)

        static class Logger
        {
            static StreamWriter outStream;
            static int logNumber = 0;
            static public void InitializeLogging()
            {
                outStream = new StreamWriter("mylog.txt");
            }
            static public void ShutdownLogging()
            {
                outStream.Close();
            }
            static public void LogMessage(string message)
            {
                outStream.WriteLine((logNumber++) + ": " + message);
            }
        }

        class LoggerS
        {
            static LoggerS theInstance;// = new LoggerS();
            public static LoggerS TheInstance
            {
                get{ if (theInstance==null)
                        theInstance = new LoggerS();
                    return theInstance;}
            }
            static StreamWriter outStream;
            static int logNumber = 0;
            public void InitializeLogging()
            {
                outStream = new StreamWriter("mylog.txt");
            }
            public void ShutdownLogging()
            {
                outStream.Close();
            }
            public void LogMessage(string message)
            {
                outStream.WriteLine((logNumber++) + ": " + message);
            }
        }


        public void TestStaticClassesvsSingleton()
        {
            Console.WriteLine("me_line");
            Logger.InitializeLogging();
            Logger.LogMessage("I love static data");
            Logger.LogMessage("static data exists before and after main");
            Logger.LogMessage("When I think static, I think memory created by the compller");
            Logger.ShutdownLogging();
            // this log file would write by one instance but not over written by multiple instances.
            // who will create only one instance to write this log file.


            //This is Singleton parten, only first time create instance and reuse this instnace at all life tiem.
            LoggerS.TheInstance.InitializeLogging(); // create The instance preoperty at first time constractor of new.
            LoggerS.TheInstance.LogMessage("I love static data");
            LoggerS.TheInstance.LogMessage("static data exists before and after main");
            LoggerS.TheInstance.LogMessage("When I think static, I think memory created by the compller");
            LoggerS.TheInstance.ShutdownLogging();

        }

        //4. C# Garbage Collection
        //https://www.youtube.com/watch?v=-JOkkn1ET8c

        class IntWrapper
        {
            public int wrappedInt;
        }

        public void TestGarbageCollection()
        {
            var wrapped1 = new IntWrapper();
            var wrapped2 = new IntWrapper();
            var wrapped3 = new IntWrapper();
            wrapped1.wrappedInt = 1;
            wrapped2.wrappedInt = 2;
            wrapped3.wrappedInt = 3;
            GC.Collect(); //it is not necessary to call GC.Collect(), it is automatically GC to call by .net framework
            // also it is not barbage and no collection happen.
            wrapped2 = null;
            GC.Collect(); //here wrapped2 is gabbage and collected.

        }

        //5. C# Why Delegates
        //https://www.youtube.com/watch?v=rxLNJ8jCN1c

        delegate bool MeDelegate(int n);
        static bool lessThanFive(int n) { return n < 5; }
        static bool lessThanTen(int n) { return n < 10; }
        static bool GreaterThanThirteen(int n) { return n > 13; } 
        static int Square(int x) { return x * x; }
        static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            foreach (int number in numbers)
                if (gauntlet(number))
                    yield return number;
            //yield is used as syntactic sugar to return an IEnumerable<T> or 
            //IEnumerator<T> object from a method without having to implement your own class implementing these interfaces.

        }


        class MyDelegates 
        {
            //MeDelegate d = Foo(0);
            //d();
            
            
        }
        static void Foo() { Console.WriteLine("Foo()");}

        public void TestDelegates()
        {
            int[] numbers = new[] { 2, 7, 3, 9, 5, 7, 1, 8 };
            IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, lessThanTen);
            foreach (int n in result)
                Console.WriteLine(n);

        }

        //6. C# Modifying a Boxed Value 
        //https://www.youtube.com/watch?v=Js1JN4D8igM

        public void TestModifyingaBoxedValue()
        {            
            object o = 5;  // boxing converter integer type to object type
            //o++;  //complirer error: Operator '++' canot be applied to operand of type 'object'
            //((int)o)++;  //((int)o) out o with value 5 only but not
            int temp = ((int)o);  // have to create new box
            o = temp++;
        }

        //7. C# Basic Thread Synchronization  
        //https://www.youtube.com/watch?v=Q1sRKlzsXTE

        //********************************
        //Multiple threading Synchronization to share resource

        static int count = 0;
        static object baton = new object();

        static void incrementCount()
        {
            while (true)
            {
                lock (baton) //only one baton will be lock and unlock while thread 1 running. the thered 2 could run until the baton unlock.
                {
                    int temp = count;   //thread 1 change count+1 and save back to count. But befoe save back the thread 2 alyead has get count and save back count++. the will have incrrect count value updated.
                    Thread.Sleep(1000); // we need Synchronized.

                    count = temp + 1;
                    Console.WriteLine("Thread ID " + Thread.CurrentThread.ManagedThreadId + " incremented count to " + count);
                    Thread.Sleep(1000);
                }
            }
        }
        // aslo has dead lock issue to see MixwellMultiThreading
        //********************************
        class Account
        {
            int _balance;
            int _id;

            public Account(int id, int balance)
            {
                _id = id;
                _balance = balance;
            }

            public int ID
            {
                get { return _id; }
            }

            public void Widthraw(int ammount)
            {
                _balance = _balance - ammount;
            }
            public void Deposite(int ammount)
            {
                _balance = _balance + ammount;
            }

            //public void Withdraw()
        }

        class AccountManager
        {
            Account _fromAccount;
            Account _toAccount;
            int _amountTransfer;

            public AccountManager(Account fromAccount, Account toAccount, int amountTransfer)
            {
                _fromAccount = fromAccount;
                _toAccount = toAccount;
                _amountTransfer = amountTransfer;
            }

            //This one has deadlock because T1 has lock fromaccount and T2 has lock toAccount to withrow.               
            //But T1 try to ask toAccount to lock to make deposte and toAccount is locked by T2.
            //And T2 try to ask fromAccount to lock to make deposit and fromAccount is locked by T1

            public void Transfer()
            {
                Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());
                lock (_fromAccount)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccount.ID.ToString());
                    Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 sec");
                    Thread.Sleep(1000);
                    Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + _toAccount.ID.ToString());

                    lock (_toAccount)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _toAccount.ID.ToString());
                        _fromAccount.Widthraw(_amountTransfer);
                        _toAccount.Deposite(_amountTransfer);
                    }
                }
            }

            public void NoLockTransfer()
            {
                object _lock1, _lock2;

                if (_fromAccount.ID < _toAccount.ID)
                {
                    _lock1 = _fromAccount; _lock2 = _toAccount;
                }
                else
                {
                    _lock1 = _toAccount; _lock2 = _fromAccount;
                }

                Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + ((Account)_lock1).ID.ToString());
                lock (_lock1)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock1).ID.ToString());
                    Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 sec");
                    Thread.Sleep(1000);
                    Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + ((Account)_lock2).ID.ToString());

                    lock (_lock2)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock2).ID.ToString());
                        _fromAccount.Widthraw(_amountTransfer);
                        _toAccount.Deposite(_amountTransfer);
                        Console.WriteLine(Thread.CurrentThread.Name + " acquired unlock on " + ((Account)_lock2).ID.ToString());
                    }
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired unlock on " + ((Account)_lock1).ID.ToString());
                }
            }

        }

        //********************************
        public void TestBasicThreadSynchronization()
        {
            //Multiple threading Synchronization to share resource
            var thread1 = new Thread(incrementCount);
            var thread2 = new Thread(incrementCount);
            thread1.Start();
            Thread.Sleep(500);
            thread2.Start();

            //Multiple threading deaklock
            Console.WriteLine("Main Started");
            Account accountA = new Account(101, 5000);
            Account accountB = new Account(102, 5000);
            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
            //Thread T1 = new Thread(accountManagerA.Transfer);
            Thread T1 = new Thread(accountManagerA.NoLockTransfer);
            T1.Name = "T1";
            AccountManager accountManagerB = new AccountManager(accountB, accountA, 1000);
            //Thread T2 = new Thread(accountManagerB.Transfer);
            Thread T2 = new Thread(accountManagerB.NoLockTransfer);
            T2.Name = "T2";
            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            Console.WriteLine("Main Completed");
            Console.Read();

        }

    }
    

}
        

