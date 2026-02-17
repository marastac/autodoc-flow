using AutoDocFlow.Models;
using AutoDocFlow.Services;

Console.WriteLine("=== AutoDoc Flow (Demo) ===");

// Datos “semilla” (demo). Luego puedes cambiarlos por lectura de JSON.
var gold = new Metal("Gold", 250.00m);     // S/ por gramo (ejemplo)
var silver = new Metal("Silver", 3.20m);   // S/ por gramo (ejemplo)

var gold18k = new Alloy("18K Gold", gold, 0.75m);
var gold24k = new Alloy("24K Gold", gold, 1.00m);
var sterling = new Alloy("Sterling Silver", silver, 0.925m);

decimal weight = 10m; // 10 gramos (ejemplo)

PrintValue(gold18k, weight);
PrintValue(gold24k, weight);
PrintValue(sterling, weight);

Console.WriteLine("\nNext step: cargar datos desde un archivo JSON y agregar más calculadoras.");

static void PrintValue(Alloy alloy, decimal grams)
{
    var value = PriceCalculator.CalculateEstimatedValue(alloy, grams);
    Console.WriteLine($"{alloy} | Peso: {grams}g | Valor estimado: S/ {value:N2}");
}
