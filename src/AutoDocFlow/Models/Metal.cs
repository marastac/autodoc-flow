namespace AutoDocFlow.Models;

public class Metal
{
    public string Name { get; }
    public decimal PricePerGram { get; } // Precio por gramo

    public Metal(string name, decimal pricePerGram)
    {
        Name = name;
        PricePerGram = pricePerGram;
    }

    public override string ToString() => $"{Name} (S/ {PricePerGram} por g)";
}
