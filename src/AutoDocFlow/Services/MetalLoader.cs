using System.Text.Json;
using AutoDocFlow.Models;

namespace AutoDocFlow.Services
{
    public class MetalLoader
    {
        public static List<Metal> LoadMetals(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<Metal>>(json) ?? new List<Metal>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading metals: {ex.Message}");
                return new List<Metal>();
            }
        }
    }
}
