using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://a4academics.com/interview-questions/52-dot-net-interview-questions/417-c-oops-interview-questions-and-answers?showall=&start=8

namespace MixwellConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MixwellSample sample = new MixwellSample();
            sample.TestDelegates();
            sample.TestBasicThreadSynchronization();

            MixwellCSharp test = new MixwellCSharp();
            
            test.runAMultipleThreading();
            MixwellProperties.MinSalary = 500;
            Console.WriteLine("Mixwell Min Salary is: " + MixwellProperties.MinSalary);


            MixwellRectangle a = new MixwellRectangle(2, 3);
            MixwellRectangle b = new MixwellRectangle(4, 5);
            if (a > b) Console.WriteLine("a>b");
            if (a < b) Console.WriteLine("a<b");

            MixwellClass obj = new MixwellClass();
            Console.Read();


        }
    }

}

