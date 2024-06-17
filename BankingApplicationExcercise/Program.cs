namespace BankingApplicationExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account A1 = new Account();                             //creating the different accounts before being able to reference them
            Account A2 = new Account();

            Console.WriteLine($"Balance is {A1.Balance:C}");        //using A1.xxx says to do the referenced Method to the called account
            A1.Deposit(500);
            Console.WriteLine($"Balance is {A1.Balance:C}");
            A1.Withdraw(250);
            Console.WriteLine($"Balance is {A1.Balance:C}");
            A1.Withdraw(260);
            Console.WriteLine($"Balance is {A1.Balance:C}");
            A1.Withdraw(50);
            Console.WriteLine($"Balance is {A1.Balance:C}");
            A1.Deposit(750);
            Console.WriteLine($"Balance is {A1.Balance:C}");
            A1.Deposit(-500);
            Console.WriteLine($"Balance is {A1.Balance:C}");
            A1.Withdraw(-100);
            Console.WriteLine($"Balance is {A1.Balance:C}");

            A1.Transfer(100, A2);                                   // transfers from A1 to A2.

        }
        

    }
}
