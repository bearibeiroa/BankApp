using System;

namespace MySuperBankApp
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        // Constructor
        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }
}