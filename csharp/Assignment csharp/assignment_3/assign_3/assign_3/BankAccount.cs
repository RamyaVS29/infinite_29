using System;

namespace assign_3
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {


        }
    }


    class BankAccount
    {
        private double balance;


        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount should be greater than 0.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn: {amount}. New Balance: {balance}");
                }
                else
                {
                    // Throwing custom exception for insufficient balance
                    throw new InsufficientBalanceException("Insufficient balance for withdrawal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Amount should be greater than 0.");
            }
        }

        // Method to check balance
        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance: {balance}");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Creating a bank account with an initial balance of 1000
                BankAccount account = new BankAccount(1000);

                // Performing transactions
                account.Deposit(500);
                account.Withdraw(200);
                account.CheckBalance();

                // Attempting to withdraw more than the balance (custom exception will be thrown)
                account.Withdraw(1500);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Exception: {ex.Message}");
            }
        }
    }
}
