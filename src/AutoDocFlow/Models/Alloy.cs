namespace AutoDocFlow.Models;

public class Alloy
{
    public string Name { get; }
    public Metal BaseMetal { get; }
    public decimal Purity { get; } // 0.0 a 1.0 (ej: 0.75 = 18k)

    public Alloy(string name, Metal baseMetal, decimal purity)
    {
        Name = name;
        BaseMetal = baseMetal;
        Purity = purity;
    }

    public override string ToString() => $"{Name} (Pureza {Purity:P0})";
}
