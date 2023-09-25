using System;

namespace Personal_Finance_Tracker.Models;

public class Transaction
{
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }

    public Transaction(DateTime date, string description, decimal amount, string category)
    {
        Date = date;
        Description = description;
        Amount = amount;
        Category = category;
    }
}