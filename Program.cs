using be_m2_generics.Classes;
using be_m2_generics.Models;

namespace be_m2_generics;

class Program
{
    static void Main(string[] args)
    {
        var drinkStorage = new Storage<Drink>(StorageTypes.Drink(StorageTypes.DrinkTypes.Soda));
        var foodStorage = new Storage<Food>(StorageTypes.Food(StorageTypes.FoodTypes.Pizza));
        var weaponStorage = new Storage<Weapon>(StorageTypes.Weapon(StorageTypes.WeaponTypes.Sword));

        drinkStorage.AddItem(new Drink { Name = "Coca-Cola", Volume = 0.5 });
        foodStorage.AddItem(new Food { Name = "Pizza", Weight = 300 });
        weaponStorage.AddItem(new Weapon { Name = "Sword", Weight = 5 });
    }
}
