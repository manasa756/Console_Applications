using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Applications
{
    internal class BankAccount
    {
        private int pin = 2003;
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public bool Login(int enterPin)
        {
            return enterPin == pin;
        }
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance:" + balance);
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Entered Invalid Amount!!");
            }
            balance += amount;
            Console.WriteLine("Amount Deposited Successfully");
        }

        public void withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("entered invalid Amount!!");
            }
            if (amount > balance)
            {
                throw new Exception("insufficient Balance");
            }
            balance -= amount;
            Console.WriteLine("Please Collect Your Cash.");
        }
    }
}
