namespace be_m2_generics.Models;

public class Weapon<T>
{
    string Name { get; set; } = "";
    int Weight { get; set; }
}