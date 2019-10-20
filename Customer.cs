using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class Customer
    {
        public int accountNumber;
        public string name;
        public double balance;

        Customer() { }

        public Customer(int accountNumber, string name, double balance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.balance = balance;
        }

        public void showBalance()
        {
            Console.WriteLine("Hello, " + name + "!. Your Current Balance is : Rs. " + balance);
        }

        public void depositAmount()
        {
            Console.WriteLine("Enter the amount to be deposited : ");
            balance += double.Parse(Console.ReadLine());
            Console.WriteLine("Updated Balance is : Rs." + balance);
        }

        public void withdrawAmount()
        {
            Console.WriteLine("Enter the amount to be withdrawn : ");
            double withdrawnAmount = double.Parse(Console.ReadLine());
            if (withdrawnAmount > balance)
            {
                Console.WriteLine("Hello, " + name + ". But you dont have enough balance. Try Again.");
            }
            else
            {
                balance -= withdrawnAmount;
                Console.WriteLine("Cash withdrawn. Updated Balance is : Rs." + balance);
            }
        }

    }
}
