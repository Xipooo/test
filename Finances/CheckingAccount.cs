using System;

namespace test.Finances
{
    public class CheckingAccount : BankAccount
    {
        private static decimal _mgmFee;
        public CheckingAccount(decimal balance, decimal mgmtFee) : base(balance)
        {
            _mgmFee = mgmtFee;
            Console.WriteLine(
                "Initial CheckingAccount -> mgmtFee: " + _mgmFee
            );
        }
        public void ChargeMgmtFee() {
            _balance -= _mgmFee;
            Console.WriteLine(
                "After ChargeMgmtFee -> balance: " + base.GetBalance()
            );
        }
    }
}