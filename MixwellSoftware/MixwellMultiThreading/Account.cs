using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MixwellMultiThreading
{
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

}
