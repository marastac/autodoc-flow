namespace AutoDocFlow.Models;

public class Metal
{
    public string Name { get; }
    public decimal PricePerGram { get; }  // Precio por gramo
    public decimal Purity { get; }        // Ejemplo: 0.75 para 18K

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
