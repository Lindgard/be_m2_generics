using System.Dynamic;

namespace be_m2_generics.Models;

public class Drink<T>
{
    public string name { get; set; } = "";
    public int amount { get; set; }
    public string category { get; set; } = "";
}