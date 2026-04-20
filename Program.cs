using be_m2_generics.Models;

namespace be_m2_generics;

class Program
{
    static void Main(string[] args)
    {
        var drinkStorage = new Storage<Drink>(StorageTypes.Drink);

        drinkStorage.AddItem(new Drink { Name = "Coca-Cola", Volume = 0.5 });
    }
}
