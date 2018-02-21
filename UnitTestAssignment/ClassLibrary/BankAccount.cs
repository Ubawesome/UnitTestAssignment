using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLib
{
    public class BankAccount
    {
        private int balance;

        public BankAccount()
        {
            balance = 0;
        }

        public BankAccount(int startBal)
        {
            balance = startBal;
        }

        public int getBalance()
        {
            return balance;
        }

        // Withdraws money from account.  
        // Return true if withdrawl successful, false if amt is negative or would overdraw account (do not perform transaction in those cases)
        public bool withdraw(int amt)
        {
            if (amt > balance)
            { return false; }
            
            if (amt <= 0)
            { return false; }

            balance -= amt;

            return true;
        }

        // Deposits amt into acocunt.  Returns true is operation successful, false otherwise.
        public bool deposit(int amt)
        {
            if (amt <= 0)
            { return false;  }

            balance += amt;

            return true;
        }
    }
}
