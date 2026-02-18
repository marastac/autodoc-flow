namespace AutoDocFlow.Models;

public class Metal
{
    public string Name { get; }
    public decimal PricePerGram { get; }  // Price per gram
    public decimal Purity { get; }        // Example: 0.75 for 18K

    public Metal(string name, decimal pricePerGram, decimal purity)
    {
        Name = name;
        PricePerGram = pricePerGram;
        Purity = purity;
    }

    public decimal CalculateValue(decimal weight)
    {
        return PricePerGram * Purity * weight;
    }

    public override string ToString() =>
        $"{Name} | Precio por gramo: S/ {PricePerGram} | Pureza: {Purity * 100}%";
}
