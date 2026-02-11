namespace Console_Applications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(10000);
            Console.WriteLine("enter Pin: ");
            int enterPin = Convert.ToInt32(Console.ReadLine());
            if (!account.Login(enterPin))
            {
                Console.WriteLine("InCorrect Pin");
                return;
            }
            int choice = 0;
            do
            {
                Console.WriteLine("\n==================== ATM MENU =========");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Exit");
                Console.Write("enter Your Choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            account.CheckBalance();
                            break;
                        case 2:
                            Console.Write("enter amount to deposit: ");
                            double dep = Convert.ToDouble(Console.ReadLine());
                            account.Deposit(dep);
                            break;
                        case 3:
                            Console.Write("enter amount to withdraw:");
                            double with = Convert.ToDouble(Console.ReadLine());
                            account.withdraw(with);
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using ATM");
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter numeric values(1-4) only");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (choice != 4);

        }
    }
}
