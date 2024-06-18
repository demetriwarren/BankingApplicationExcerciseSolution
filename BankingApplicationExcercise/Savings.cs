using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationExcercise
{
    internal class Savings
    {
        private Account account = new Account("Savings Account"); //a Field bc there is no get/set (if it did it would be a property. Could make it a prop if wanted)

        public decimal InterestRate { get; set; } = 0.12m;

        public void CalcAndPayInterest(int months)          //adds the interest rate into this class
        {
            var Interest = Balance() * (InterestRate / 12) * months;
            Deposit(Interest);
        }

        public int AccountId() //allows user to read account ID but not change it
        {
        return account.AccountId;
        }
        public string Description() //method allows user to read desc
        {
            return account.Description;
        }
        public void Description(string description) //method allows user to change desc
        {
            account.Description = description;                                                      //COMPOSITION 
        }
        public decimal Balance() //allows the user to view balance but not change
        {
            return account.Balance; 
        }
        public bool Deposit(decimal Amount) // method pulled from account class 
        {
            return account.Deposit(Amount);
        }
        public bool Withdraw(decimal Amount)
        {
            return account.Withdraw(Amount);
        }
        public bool Transfer(decimal Amount, Savings savings)
        {
            if (account.Withdraw(Amount))
            {
                savings.Deposit(Amount);
            }
            return true;
        }
        public Savings(string description) // constructer for the Savings account
        {
        }
    }
    
}
