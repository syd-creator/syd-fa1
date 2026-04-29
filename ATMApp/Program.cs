using System;

class Program
{
    static void Main(string[] args)
    {
        int correctPin = 1234;
        int enteredPin;
        int attempts = 0;
        bool accessGranted = false;

        double balance = 1500.00;
        double withdrawalAmount;

        // PIN validation (3 attempts)
        while (attempts < 3)
        {
            Console.Write("Enter your PIN: ");

            if (int.TryParse(Console.ReadLine(), out enteredPin))
            {
                if (enteredPin == correctPin)
                {
                    accessGranted = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect PIN.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter numbers only.");
            }

            attempts++;
        }

        if (!accessGranted)
        {
            Console.WriteLine("Too many incorrect attempts. Access blocked.");
            return;
        }

        // Withdrawal
        Console.WriteLine("\nWelcome to ATM");
        Console.WriteLine("Current Balance: R" + balance);

        Console.Write("Enter withdrawal amount: ");

        if (double.TryParse(Console.ReadLine(), out withdrawalAmount))
        {
            if (withdrawalAmount <= balance)
            {
                balance -= withdrawalAmount;

                Console.WriteLine("\nWithdrawal successful!");
                Console.WriteLine("Amount withdrawn: R" + withdrawalAmount);
                Console.WriteLine("Remaining balance: R" + balance);
                Console.WriteLine("Transaction time: " + DateTime.Now);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount entered.");
        }

        Console.ReadLine();
    }
}