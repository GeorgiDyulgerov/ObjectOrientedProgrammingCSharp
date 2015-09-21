using Problem2BankOfKurtovoKonare.CustomerInfo;

namespace Problem2BankOfKurtovoKonare.Account
{
    class Deposit:Account
    {

        public Deposit(Customers customer, decimal balance, int interestRate) : base(customer, balance, interestRate)
        {
        }
    }
}
