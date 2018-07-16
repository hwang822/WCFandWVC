﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MixwellMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
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
