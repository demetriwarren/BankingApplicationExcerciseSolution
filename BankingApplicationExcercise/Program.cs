namespace BankingApplicationExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A1 = new Savings("Savings1");                             //creating the different accounts before being able to reference them
            var A2 = new Savings("Savings2");

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
            A1.CalcAndPayInterest(1);
            Console.WriteLine($"Balance is {A1.Balance:C}");
        }
        

    }
}
