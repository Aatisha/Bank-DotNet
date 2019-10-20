using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer[] customers = new Customer[5];
            string[] names = { "Aatisha", "Rahul", "Deevika", "Harshit", "Venkatesh" };
            double[] balances = { 9992340.0, 34523.69, 3421.0, 36728.0, 23752.0 };
            for (int i = 0; i < customers.Length; ++i)
            {
                customers[i] = new Customer(101 + i, names[i], balances[i]);
            }

            Console.WriteLine("Enter your account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            int customerIndex = checkAccount(accountNumber, customers);
            if (customerIndex >= 0)
            {
                Boolean continueProcess = true;
                do
                {
                    Console.WriteLine("Enter your option");
                    Console.WriteLine("1. Show opening balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Exit");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            customers[customerIndex].showBalance();
                            break;
                        case 2:
                            customers[customerIndex].depositAmount();
                            break;
                        case 3:
                            customers[customerIndex].withdrawAmount();
                            break;
                        default:
                            System.Environment.Exit(0);
                            break;
                    }

                    Console.WriteLine("Want to Continue? Yes or No");
                    string userInput = Console.ReadLine();
                    if (string.Equals(userInput.ToUpper(), "NO"))
                    {
                        continueProcess = false;
                    }
                } while (continueProcess);
            }
            else
            {
                Console.WriteLine("This account number does not exist");
                Console.WriteLine("Enter valid account number");
            }
            Console.ReadLine();
        }

        public static int checkAccount(int accountNumber, Customer[] customers)
        {
            int i = 0;
            foreach (Customer c in customers)
            {
                if (c.accountNumber == accountNumber)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

    }
}