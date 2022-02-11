namespace LimeAssistance.Models;

public class Purchase
{
    public Person Payer { get; set; } = new()
    {
        Name = "Not added",
        Total = 0.0,
        Diff = 0.0
    };

    public string? Description { get; set; }

    public double Amount { get; set; }

}