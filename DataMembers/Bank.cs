using System;
/*2.Create a Bank class, assign balance in constructor, create deposit & withdraw method & display methods
Deposit will add amount in balance
Withdraw will remove the amount from balance . amount should be remove if its less than balance
Display will show balance
*/

namespace DataMembers
{
    public class Bank
    {
        private double balance;
       
        public Bank(int bal)
        {
            balance = bal;
        }

        public string display()
        {
            return $"Available Balance :{balance}";
        }

        public void deposit(double amount)
        {
            //Console.WriteLine("Enter amount to deposit : ");
            //amount = System.Convert.ToDouble(Console.ReadLine());
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Available Balance After Deposit : " + balance);
            }
            else
            {
                Console.WriteLine("Deposit amount more than 0");
            }
        }

        public void withdraw(double amount)
        {
            // Console.WriteLine("Enter amount to withdraw : ");
            //amount = System.Convert.ToDouble(Console.ReadLine());

            if (amount > 0 && amount < balance)
            {
                balance = balance - amount;
                Console.WriteLine("Available Balance After Withdraw : " + balance);
            }
            else {
                  Console.WriteLine("Insufficient Funds To Withdraw");
            }
        }
    }
}
