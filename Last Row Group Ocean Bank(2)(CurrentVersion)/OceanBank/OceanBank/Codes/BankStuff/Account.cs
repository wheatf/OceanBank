using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    public class Account
    {
        private string acctNo;
        private double balance;

        public Account(string a, double b)
        {
            acctNo = a;
            balance = b;
        }

        public string getAcctNo()
        {
            return acctNo;
        }

        public double getBalance()
        {
            return balance;
        }

        public void withdraw(double amt)
        {
            balance = balance - amt;
        }

        public void deposit(double amt)
        {
            balance = balance + amt;
        }
    }
}
