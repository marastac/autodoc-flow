using AutoDocFlow.Models;

namespace AutoDocFlow.Services;

public static class PriceCalculator
{
    // Valor estimado = gramos * precioPorGramo * pureza
    public static decimal CalculateEstimatedValue(Alloy alloy, decimal weightInGrams)
    {
        if (weightInGrams <= 0) return 0;
        return weightInGrams * alloy.BaseMetal.PricePerGram * alloy.Purity;
    }
}
