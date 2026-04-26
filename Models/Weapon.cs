using be_m2_generics.Classes;

namespace be_m2_generics.Models;

public class Weapon
{
    public string Name { get; set; } = "";
    public int Weight { get; set; }
    public string Category { get; set; } = "";
    public StorageTypes WeaponCategory { get; set; }
}