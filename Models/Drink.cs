using System.Dynamic;
using be_m2_generics.Classes;

namespace be_m2_generics.Models;

public class Drink
{
    public string Name { get; set; } = "";
    public double Volume { get; set; }
    public string Category { get; set; } = "";
    public StorageTypes DrinkCategory { get; set; }
}