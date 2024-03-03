using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_assign3
{
    class Accounts

    {
        //data members of class accounts //by default members are private need not mention 
         string accountNo;
         string customerName;
         string accountType;
         char transactionType;
         decimal amount;
         decimal balance;

        // Constructor
        public Accounts(string accountNo, string customerName, string accountType, char transactionType, decimal amount, decimal balance)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = balance;
        }

        // Function to update balance based on transaction type
        public void UpdateBalance()
        {
            if (transactionType == 'D' || transactionType == 'd')
            {
                Credit((int)amount);//calls the function in line no 52
                Console.WriteLine("Deposit successful ");
            }
            else if (transactionType == 'W' || transactionType == 'w')
            {
                Debit((int)amount);//calls the function in line no 57
                Console.WriteLine("Withdrawal successful ");
            }
            else
            {
                Console.WriteLine("Invalid transaction type. Use 'D' for Deposit or 'W' for Withdrawal...!");
            }
        }

        // Credit function for deposit
        private void Credit(int amount)
        {
            balance += amount;
        }

        // Debit function for withdrawal
        private void Debit(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed ");
            }
        }

        // Displaying account details
        public void ShowData()
        {
            Console.WriteLine($"Account Number: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
            
        }

       
        static void Main()
        {
            // Create an instance of the Accounts class
            Accounts account1 = new Accounts("91089", "ramya", "Savings", 'D', 1000, 1000);

            // Display account details
            account1.ShowData();

            // Update balance based on transaction type
            account1.UpdateBalance();

            // Display updated account details
            account1.ShowData();
            Console.ReadLine();
        }
        

    }
    
}