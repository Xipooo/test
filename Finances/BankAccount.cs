using System;

namespace test.Finances
{
    public class BankAccount
    {
        protected decimal _balance;

        public BankAccount(decimal balance)
        {
            _balance = balance;
            Console.WriteLine(
                    "Initial BankAccount -> balance: " + _balance
                );
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine(
                "After deposit -> balance: " + _balance
            );
        }

        public void Withdraw(decimal amount){
            _balance -= amount;
            Console.WriteLine(
                "After withdraw -> balance: " + _balance
            );
        }
    }
}