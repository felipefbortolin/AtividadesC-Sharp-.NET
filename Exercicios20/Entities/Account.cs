using System;
using Exercicio02.Entities.Exeptions;

namespace Exercicio02.Entities
{
    class Account
    {
        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2");
        }
    }
}