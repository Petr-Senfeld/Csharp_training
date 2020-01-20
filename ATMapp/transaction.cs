using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Transaction
    {
        public string User { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal Amount, DateTime date, string note)
        {
            this.Amount = Amount;
            this.Date = date;
            this.Notes = note;
        }

    }
    public class user_Transaction
    {
        public string User { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public user_Transaction(decimal Amount, DateTime date, string note)

        {
            this.Amount = Amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
