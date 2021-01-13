using System;

namespace UnitTesting
{
    public static class Program
    {
        public static  decimal balance = 5000;
        public static decimal withdrawalAmt = 0;
        public static decimal depositAmt = 0;
        static void Main(string[] args)
        {
            StartSequence();
        }

        public static void StartSequence()
        {
            int expected =0;

            while(expected > 1 || expected < 4)
            {
                // `\n` == line break, referenced from:
                // https://stackoverflow.com/questions/1187121/c-sharp-encoding-a-text-string-with-line-breaks
                
                Console.WriteLine("How can I help you Today: \n1) View Balance \n2) Withdrawal \n3) Deposit \n4) Exit");
                string userSelection = Console.ReadLine();
                expected = Convert.ToInt32(userSelection);
            }

            if(expected == 1)
            {
                Console.Clear();
                ViewBalance();
                Console.Clear();
                StartSequence();
            }
            else if (expected == 2)
            {
                Withdraw();
                StartSequence();
            }
            else if (expected == 3)
            {
                Deposit();
                StartSequence();
            }
            else if(expected == 4)
            {
                Console.WriteLine("See you next time!");
                Console.WriteLine($" Your balance is {balance}. \nYour withdrawals today were {withdrawalAmt}. \nYour deposits today were {depositAmt}.");
            }
        }

        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your balance is a whopping {balance}.");
            return balance;
        }

        public static decimal Withdraw()
        {
            Console.WriteLine("How much cash are you looking for mate?");
            decimal withdrawalAmt = Convert.ToDecimal(Console.ReadLine());
            if (balance - withdrawalAmt >= 0 && withdrawalAmt > 0)
            {
                balance = balance - withdrawalAmt;
            }
            else
            {
                Console.WriteLine($"Yikes! You should look elsewhere for that much mate, you only have {balance} available");
            }
            return balance;
        }

        public static decimal Deposit()
        {
            Console.WriteLine("How much cash are you feeding me?");
            decimal depositAmt = Convert.ToDecimal(Console.ReadLine());
            if (depositAmt < 0)
            {
                Console.WriteLine("C'mon, you can't deposit negative cash!");
            }
            else
            {
                balance = balance + depositAmt;
            }
            return balance;
        }
    }
}
