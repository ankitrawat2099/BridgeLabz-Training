using System;
using System.Collections.Generic;
using System.Text;

namespace Review.BankAccountManager
{
    public class BankAccount
    {
        private int AccountNo;
        private double Balance;
        public double GetBalance() {
            return Balance;
        }
        public int GetAccountNo() {
            return AccountNo; }
        public void SetBalance(double balance) {
            Balance = balance;
        }
        public void SetAccountNo(int accountNo) { 
        AccountNo=accountNo;
        }
    }
}
