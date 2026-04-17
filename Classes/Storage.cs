using be_m2_generics.Interfaces;

namespace be_m2_generics.Classes;


public class Storage<T>(StorageTypes storageTypes)
{
    private Storage<T> storage = new(); //? useful or pointless?

    //TODO start AddItem method
    //? IStorageService.AddItem<T>
    //? _storage.AddItem(T item) 
    //? _storage.Push()
    //TODO RETURN IENUMERABLE<T> on GetallItems method
    //* _storage.GetAllItems(T item)
    //* _storage.CountItems()
    //* _storage.RemoveItem() //* _storage.Pop();
}