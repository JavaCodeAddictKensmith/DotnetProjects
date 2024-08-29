using ATMAPPCONSOLE;

class Program
{


    public static void Main(string[] args)
    {
        IAtmOperationInterf op = new AtmOperationImpl();
        // Press Opt+Enter with your caret at the highlighted text to see how
        int atmnumber = 12345;
        int atpin = 123;
        Console.WriteLine("Enter Atm Number");
        int atmNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter pin: ");
        int pin = Convert.ToInt32(Console.ReadLine());
        if ((atmnumber == atmNumber) && (atpin == pin))
        {
            while (true)
            {
                Console.WriteLine("1. View Available Balance\n2. Withdraw Amount\n3. Deposit Amount\n4. View the mini statement\n5. Exit");
                Console.WriteLine("Enter choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    op.ViewBalance();
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter amount to withdraw");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    op.WithDrewAmount(withdrawAmount);
                }
                else if (ch == 3)
                {
                    Console.WriteLine("Enter amount to Deposit");
                    double depositAmount = Convert.ToDouble(Console.ReadLine()); //5000
                    op.DepositAmount(depositAmount);
                }
                else if (ch == 4)
                {
                    op.ViewMiniStatement();
                }
                else if (ch == 5)
                {
                    Console.WriteLine("Collect your ATM Card\n Thank you for using your ATM Machine");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter correct choice");
                }
            }
        }
        else
        {
            Console.WriteLine("Incorrect Atm Number or pin");
            Environment.Exit(0);
        }
    }
}
