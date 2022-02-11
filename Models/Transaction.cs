namespace LimeAssistance.Models;

public class Transaction
{
    public Person Payer { get; set; } = new()
    {
        Name = "Not added",
        Total = 0.0,
        Diff = 0.0
    };

    public Person Receiver { get; set; } = new()
    {
        Name = "Not added",
        Total = 0.0,
        Diff = 0.0
    };

    public double Amount { get; set; }
}