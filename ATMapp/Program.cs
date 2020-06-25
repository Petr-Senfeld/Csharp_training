using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            bool running2 = false;

            Console.WriteLine("***Welcome to ATMapp***\n");
            while (running)
            {
                Console.WriteLine("What would you like to do??");
                Console.WriteLine("(Press number and hit Enter)");
                Console.WriteLine("____________________________");
                Console.WriteLine("Press 1 - Open Account");
                Console.WriteLine("Press 2 - To exit");
                Console.WriteLine("____________________________");

                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice < 1 || choice > 2)
                {
                    Console.WriteLine("Invalid option, please try again..\n");
                }
                if (choice == 1)
                {
                    Console.WriteLine("Provide your name: ");
                    String namex = Console.ReadLine();
                    var account = new BankAccount(namex, 1000);
                    Console.WriteLine($"Your account: {account.Number} has been created.");
                    Console.WriteLine("Here, have a 1000 on US...");
                    running = false;
                    running2 = true;

                    while (running2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("What would you like to do??");
                        Console.WriteLine("(Press number and hit Enter)");
                        Console.WriteLine("____________________________");
                        Console.WriteLine("Press 1 - To make withdrawal");
                        Console.WriteLine("Press 2 - To make deposit");
                        Console.WriteLine("Press 3 - To get balance");
                        Console.WriteLine("Press 4 - To exit");
                        Console.WriteLine("____________________________\n");

                        int choice2 = Convert.ToInt32(Console.ReadLine());

                        if (choice2 < 1 || choice2 > 4)
                        {
                            Console.WriteLine("Invalid option, please try again..\n");
                        }

                        if (choice2 == 1)
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            int numberx = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Add some note:");
                            String notex = Console.ReadLine();
                            account.MakeWithdrawal(numberx, DateTime.Now, notex);
                        }
                        else if (choice2 == 2)
                        {
                            Console.WriteLine("How much would you like to deposit?");
                            int numberx = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Add some note:");
                            String notex = Console.ReadLine();
                            account.MakeDeposit(numberx, DateTime.Now, notex);
                        }
                        else if (choice2 == 3)
                        {
                            Console.WriteLine($"Your current balance is {account.Balance}");
                            Console.WriteLine(account.GetAccountHistory());
                        }
                        else if (choice2 == 4)
                        {
                            Console.WriteLine("Thank you for using ATMapp");
                            Console.WriteLine("Press \"Any key\" to exit...");
                            running2 = false;
                        }
                    }
                }
                else if(choice == 2)
                {
                    Console.WriteLine("Thank you for using ATMapp");
                    Console.WriteLine("Press \"Any key\" to exit...");
                    running = false;
                }
            }

            Console.ReadKey();
        }
    }
}
