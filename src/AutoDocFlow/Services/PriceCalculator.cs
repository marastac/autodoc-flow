using AutoDocFlow.Models;

namespace AutoDocFlow.Services;

public static class PriceCalculator
{
    // Estimated value = grams * price per gram * purity
    public static decimal CalculateEstimatedValue(Alloy alloy, decimal weightInGrams)
    {
        if (weightInGrams <= 0) return 0;
        return weightInGrams * alloy.BaseMetal.PricePerGram * alloy.Purity;
    }
}
