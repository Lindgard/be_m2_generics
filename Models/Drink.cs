using System.Dynamic;

namespace be_m2_generics.Models;

public class Drink<T>
{
    string Name { get; set; } = "";
    int Amount { get; set; }
}