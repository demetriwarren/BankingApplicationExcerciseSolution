using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationExcercise
{
   public class Account                                     // Class
    {
        public int AccountId { get; set; } = 0;             //properties
        public string Description { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;

        public bool Deposit(decimal Amount)                 //methods - the thing in the parenthesis says that you must pass something thru this when referencing.
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Deposit amount cannot be zero or negative");
                return false;
            }
            Balance += Amount;                              // balance is an instance of the property: Balance
            return true;
        }
        public bool Withdraw(decimal Amount)
        {
            if (Amount <= 0)
            {                                               //everything in this curly bracket is what the Method is going to do when its called/ran
                Console.WriteLine("Withdrawal amount cannot be zero or negative");
                return false;
            }
            if (Amount > Balance) { Console.WriteLine("Insufficient funds.");
                return false;
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
        
    }
}
