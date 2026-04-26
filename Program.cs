using be_m2_generics.Models;
using be_m2_generics.Classes;

namespace be_m2_generics;

class Program
{
    static void Main(string[] args)
    {
        var drinkStorage = new Storage<Drink>(StorageTypes.DrinkCategory);

        drinkStorage.AddItem(new Drink { Name = "Coca-Cola", Volume = 0.5 });
    }
}
