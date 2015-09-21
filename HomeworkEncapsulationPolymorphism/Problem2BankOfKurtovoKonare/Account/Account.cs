using System;
using System.Collections.Generic;
using Problem2BankOfKurtovoKonare.CustomerInfo;

namespace Problem2BankOfKurtovoKonare.Account
{
    abstract class Account
    {
        private Customers customer;
        private decimal balance;
        private int interestRate;

        public Account(Customers customer,decimal balance,int interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customers Customer { get; set; }
        public decimal Balance { get; set; }
        public int InterestRate { get; set; }
    }
}
