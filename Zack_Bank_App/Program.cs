namespace Zack_Bank_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Zack Bank!");
            Console.WriteLine("what would you like to do today");
            Console.WriteLine("Press 1 to Deposit");
            Console.WriteLine("Press 2 to Withdraw");
            string UserResponse = Console.ReadLine();

            if (UserResponse == "1")
            {
                Transaction transaction = new Transaction();
                Console.WriteLine("Enter deposit amount");
                string depositAmount = Console.ReadLine();
                int amount = Int32.Parse(depositAmount);

                var myAccount = transaction.Deposit(amount);

                Console.WriteLine($" Your new account balance is {myAccount.AccountBalance}");
            }




        }
    }
}
