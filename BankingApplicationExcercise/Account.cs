using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationExcercise
{
   public class Account                                     // Class
    {
        private static int nextId { get; set; } = 1;

        public int AccountId { get; private set; } = 0;             //properties    set to private so no other class can change the AcctID
        public string Description { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;

        public bool Deposit(decimal Amount)                 //methods - the thing in the parenthesis says that you must pass something thru this when referencing.
        {
            if (Amount <= 0)
            {
                throw new NonPositiveAmountException();
            } 
            Balance += Amount;                              // balance is an instance of the property: Balance
            return true;
        }

        public bool Withdraw(decimal Amount)
        {
            if (Amount <= 0)
            {                                               //everything in this curly bracket is what the Method is going to do when its called/ran
                throw new NonPositiveAmountException();
            }
            if (Amount > Balance) { 
                throw new InsufficientFundsException { Balance = Balance, Amount = Amount };
            }
            Balance -= Amount;
            return true;
        }
        
        public bool Transfer(decimal Amount, Account accountx) 
        {
            var success = Withdraw(Amount);
            if (success == true)
            {
                accountx.Deposit(Amount);
            }
            return true;
        }

        public Account(string description)
        {
            AccountId = nextId++;
            Description = description;
            Balance = 0;
        }
    }
}
