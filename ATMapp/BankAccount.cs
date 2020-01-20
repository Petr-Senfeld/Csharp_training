using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class BankAccount
    {
        public string Number { get;  }
        public string Owner { get; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }

        }

        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            else
            {
                var deposit = new Transaction(amount, date, note);
                allTransactions.Add(deposit);
            }

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
                if (amount <= 0)
                {
                    Console.WriteLine("Amount of withdrawal must be positive");
                    Console.WriteLine("Please try again..");
                    //throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
                }
                else if (Balance - amount < 0)
                {
                    Console.WriteLine("Not sufficient funds for this withdrawal");
                    Console.WriteLine("Please try again..");
                    //throw new InvalidOperationException("Not sufficient funds for this withdrawal");
                }
                else
                {
                    var withdrawal = new Transaction(-amount, date, note);
                    allTransactions.Add(withdrawal);
                }
        }

        public void Transfer(decimal amount, BankAccount prijemce ,DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of tranfer must be positive");
            }
            else if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this tranfer");
            }
            else
            {
                var transfer = new Transaction(-amount, date, note);
                prijemce.MakeDeposit(amount, DateTime.Now, note);
                //MakeWithdrawal(amount, DateTime.Now, note);
                allTransactions.Add(transfer);
            }

        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            Console.WriteLine($"Balance history of {Owner}");
            report.AppendLine("Date     \tAmount \tNote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}
