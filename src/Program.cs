using be_m2_generics.Models;
using be_m2_generics.Classes;

namespace be_m2_generics;

class Program
{
    static void Main(string[] args)
    {
        var drinkStorage = new Storage<Drink>(StorageTypes.DrinkCategory);
        drinkStorage.AddItem(new Drink { Name = "Coca-Cola", Volume = 0.5 });

        var foodStorage = new Storage<Food>(StorageTypes.FoodCategory);
        foodStorage.AddItem(new Food { Name = "Pizza", Weight = 300 });

        var weaponStorage = new Storage<Weapon>(StorageTypes.WeaponsCategory);
        weaponStorage.AddItem(new Weapon { Name = "Sword", Weight = 5 });
    }
}
