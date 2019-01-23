using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanBank
{
    public class Card
    {
        private string PIN;
        private List<Account> accounts; //List is like an array

        public Card(string p)
        {
            PIN = p;
            accounts = new List<Account>();     //Create a new empty List
        }

        public Card(string p, List<Account> accounts)
        {
            PIN = p;
            this.accounts = accounts;
        }

        public string getPIN()
        {
            return PIN;
        }

        public void addAccount(Account newAcct)
        {
            accounts.Add(newAcct);      //Add the newAcct to the list
        }

        public int getNumAccounts()
        {
            return accounts.Count;
        }

        public Account getAcctAtIndex(int i)
        {
            if (i >= 0 && i < getNumAccounts())
                return accounts[i];
            else
                return null;
        }

        public Account getAcctUsingAcctNo(string acctNo)
        {
            Account result = null;
            for (int i=0;i<accounts.Count;i++)
            {
                if (accounts[i].getAcctNo() == acctNo)
                {
                    result = accounts[i];
                    break;
                }
            }
            return result;
        }

    }
}
