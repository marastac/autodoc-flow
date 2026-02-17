using AutoDocFlow.Services;
using System.Globalization;

Console.WriteLine("=== AutoDoc Flow (Professional Demo) ===");

// Permite usar punto o coma en decimales
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

// Cargar metales desde archivo JSON
var metals = MetalLoader.LoadMetals("src/AutoDocFlow/Data/metals.json");

if (metals == null || metals.Count == 0)
{
    Console.WriteLine("No metals were loaded. Please verify Data/metals.json exists and has valid data.");
    return;
}

while (true)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1) Show metal estimates (default 10g)");
    Console.WriteLine("2) Calculate custom weight");
    Console.WriteLine("3) Exit");
    Console.Write("Choose an option: ");

    var option = Console.ReadLine()?.Trim();

    switch (option)
    {
        case "1":
            ShowEstimates(metals, 10m);
            break;

        case "2":
            Console.Write("\nEnter weight in grams (e.g., 10 or 10.5): ");
            var input = Console.ReadLine()?.Trim();

            // Acepta coma o punto
            input = input?.Replace(",", ".");

            if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal weight) && weight > 0)
            {
                ShowEstimates(metals, weight);
            }
            else
            {
                Console.WriteLine("Invalid weight input. Please enter a positive number (e.g., 10 or 10.5).");
            }
            break;

        case "3":
            Console.WriteLine("\nGoodbye!");
            return;

        default:
            Console.WriteLine("\nInvalid option. Try again.");
            break;
    }
}

// Método auxiliar profesional para mostrar cálculos
void ShowEstimates(List<AutoDocFlow.Models.Metal> metals, decimal weight)
{
    Console.WriteLine($"\n--- Metal Estimates ({weight}g) ---");

    foreach (var metal in metals)
    {
        decimal value = metal.CalculateValue(weight);
        Console.WriteLine($"{metal.Name} | Weight: {weight}g | Est. Value: S/ {value:F2}");
    }
}
