<<<<<<< HEAD
﻿using be_m2_generics.Models;
using be_m2_generics.Classes;
=======
﻿using be_m2_generics.Classes;
using be_m2_generics.Models;
>>>>>>> e71e1e1fb10e12c5522d4330ee276936050860a6

namespace be_m2_generics;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        var drinkStorage = new Storage<Drink>(StorageTypes.DrinkCategory);
=======
        var drinkStorage = new Storage<Drink>(StorageTypes.Drink(StorageTypes.DrinkTypes.Soda));
        var foodStorage = new Storage<Food>(StorageTypes.Food(StorageTypes.FoodTypes.Pizza));
        var weaponStorage = new Storage<Weapon>(StorageTypes.Weapon(StorageTypes.WeaponTypes.Sword));
>>>>>>> e71e1e1fb10e12c5522d4330ee276936050860a6

        drinkStorage.AddItem(new Drink { Name = "Coca-Cola", Volume = 0.5 });
        foodStorage.AddItem(new Food { Name = "Pizza", Weight = 300 });
        weaponStorage.AddItem(new Weapon { Name = "Sword", Weight = 5 });
    }
}
